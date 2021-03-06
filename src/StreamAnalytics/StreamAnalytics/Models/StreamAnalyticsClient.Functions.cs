// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.StreamAnalytics.Properties;
using Microsoft.Azure.Management.StreamAnalytics;
using Microsoft.Azure.Management.StreamAnalytics.Models;
using Microsoft.Rest.Azure;
using Microsoft.Rest.Serialization;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;

namespace Microsoft.Azure.Commands.StreamAnalytics.Models
{
    public partial class StreamAnalyticsClient
    {
        public virtual PSFunction GetFunction(string resourceGroupName, string jobName, string name)
        {
            var response = StreamAnalyticsManagementClient.Functions.Get(
                resourceGroupName, jobName, name);

            return new PSFunction(response)
            {
                ResourceGroupName = resourceGroupName,
                JobName = jobName
            };
        }

        public virtual List<PSFunction> ListFunctions(string resourceGroupName, string jobName)
        {
            List<PSFunction> functions = new List<PSFunction>();

            var response = StreamAnalyticsManagementClient.Functions.ListByStreamingJob(resourceGroupName, jobName);

            if (response != null)
            {
                foreach (var function in response)
                {
                    functions.Add(new PSFunction(function)
                    {
                        ResourceGroupName = resourceGroupName,
                        JobName = jobName
                    });
                }
            }

            return functions;
        }

        public virtual List<PSFunction> FilterPSFunctions(FunctionFilterOptions filterOptions)
        {
            if (filterOptions == null)
            {
                throw new ArgumentNullException("filterOptions");
            }

            if (string.IsNullOrWhiteSpace(filterOptions.ResourceGroupName))
            {
                throw new ArgumentException(Resources.ResourceGroupNameCannotBeEmpty);
            }

            if (string.IsNullOrWhiteSpace(filterOptions.JobName))
            {
                throw new ArgumentException(Resources.JobNameCannotBeEmpty);
            }

            List<PSFunction> functions = new List<PSFunction>();

            if (!string.IsNullOrWhiteSpace(filterOptions.Name))
            {
                functions.Add(GetFunction(filterOptions.ResourceGroupName, filterOptions.JobName, filterOptions.Name));
            }
            else
            {
                functions.AddRange(ListFunctions(filterOptions.ResourceGroupName, filterOptions.JobName));
            }

            return functions;
        }

        protected virtual Function CreateOrUpdatePSFunction(string resourceGroupName, string jobName, string functionName, string rawJsonContent)
        {
            if (string.IsNullOrWhiteSpace(rawJsonContent))
            {
                throw new ArgumentNullException("rawJsonContent");
            }

            Function function = SafeJsonConvert.DeserializeObject<Function>(
                rawJsonContent,
                StreamAnalyticsClientExtensions.DeserializationSettings);

            // If create failed, the current behavior is to throw
            var response = StreamAnalyticsManagementClient.Functions.CreateOrReplace(
                    function,
                    resourceGroupName,
                    jobName,
                    functionName);

            return response;
        }

        public virtual PSFunction CreatePSFunction(CreatePSFunctionParameter parameter)
        {
            if (parameter == null)
            {
                throw new ArgumentNullException("parameter");
            }

            PSFunction function = null;
            parameter.ConfirmAction(
                    parameter.Force,
                    string.Format(
                        CultureInfo.InvariantCulture,
                        Resources.FunctionExists,
                        parameter.FunctionName,
                        parameter.JobName,
                        parameter.ResourceGroupName),
                    string.Format(
                        CultureInfo.InvariantCulture,
                        Resources.FunctionCreating,
                        parameter.FunctionName,
                        parameter.JobName,
                        parameter.ResourceGroupName),
                    parameter.FunctionName,
                    () =>
                    {
                        function = new PSFunction(
                            CreateOrUpdatePSFunction(parameter.ResourceGroupName,
                                parameter.JobName,
                                parameter.FunctionName,
                                parameter.RawJsonContent))
                        {
                            ResourceGroupName = parameter.ResourceGroupName,
                            JobName = parameter.JobName
                        };
                    },
                    () => CheckFunctionExists(parameter.ResourceGroupName, parameter.JobName, parameter.FunctionName));

            return function;
        }

        public virtual void RemovePSFunction(string resourceGroupName, string jobName, string functionName)
        {
            StreamAnalyticsManagementClient.Functions.Delete(resourceGroupName, jobName, functionName);
        }

        public virtual ResourceTestStatus TestPSFunction(string resourceGroupName, string jobName, string functionName)
        {
            return StreamAnalyticsManagementClient.Functions.Test(resourceGroupName, jobName, functionName);
        }

        public virtual PSFunction RetrieveDefaultPSFunctionDefinition(RetrieveDefaultPSFunctionDefinitionParameter parameter)
        {
            if (parameter == null)
            {
                throw new ArgumentNullException("parameter");
            }

            FunctionRetrieveDefaultDefinitionParameters functionRetrieveDefaultDefinitionParameters = SafeJsonConvert.DeserializeObject<FunctionRetrieveDefaultDefinitionParameters>(
                parameter.RawJsonContent,
                StreamAnalyticsClientExtensions.DeserializationSettings);

            var response = StreamAnalyticsManagementClient.Functions.RetrieveDefaultDefinition(
                parameter.ResourceGroupName, parameter.JobName, parameter.FunctionName, functionRetrieveDefaultDefinitionParameters);

            return new PSFunction(response)
            {
                ResourceGroupName = parameter.ResourceGroupName,
                JobName = parameter.JobName
            };
        }

        private bool CheckFunctionExists(string resourceGroupName, string jobName, string functionName)
        {
            try
            {
                PSFunction function = GetFunction(resourceGroupName, jobName, functionName);
                return true;
            }
            catch (CloudException e)
            {
                //Get throws Exception message with NotFound Status
                if (e.Response.StatusCode == HttpStatusCode.NotFound)
                {
                    return false;
                }
                else
                {
                    throw;
                }
            }
        }
    }
}
