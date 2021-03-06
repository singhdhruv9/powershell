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

using Microsoft.Azure.Commands.Aks.Generated.Version2017_08_31;
using Microsoft.Azure.Commands.Common.Authentication;
using Microsoft.Azure.Management.DevSpaces;
using Microsoft.Azure.ServiceManagement.Common.Models;
using Microsoft.Azure.Test.HttpRecorder;
using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
using Microsoft.WindowsAzure.Commands.ScenarioTest;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using InternalResourceManagementClient = Microsoft.Azure.Management.Internal.Resources.ResourceManagementClient;
using ResourceManagementClient = Microsoft.Azure.Management.ResourceManager.ResourceManagementClient;
using TestEnvironmentFactory = Microsoft.Rest.ClientRuntime.Azure.TestFramework.TestEnvironmentFactory;

namespace Microsoft.Azure.Commands.DevSpaces.Test.ScenarioTests
{
    public class TestController
    {
        private readonly EnvironmentSetupHelper _helper;

        public TestController()
        {
            _helper = new EnvironmentSetupHelper();
        }

        public static TestController NewInstance => new TestController();

        private void SetupManagementClients(MockContext context)
        {
            _helper.SetupManagementClients(
                context.GetServiceClient<ContainerServiceClient>(TestEnvironmentFactory.GetTestEnvironment()),
                context.GetServiceClient<ResourceManagementClient>(TestEnvironmentFactory.GetTestEnvironment()),
                context.GetServiceClient<InternalResourceManagementClient>(TestEnvironmentFactory.GetTestEnvironment()),
                context.GetServiceClient<DevSpacesManagementClient>(TestEnvironmentFactory.GetTestEnvironment()));
        }

        public void RunPowerShellTest(XunitTracingInterceptor logger, params string[] scripts)
        {
            var sf = new StackTrace().GetFrame(1);
            var callingClassType = sf.GetMethod().ReflectedType?.ToString();
            var mockName = sf.GetMethod().Name;

            _helper.TracingInterceptor = logger;

            var d = new Dictionary<string, string>
            {
                {"Microsoft.Resources", null},
                {"Microsoft.Features", null},
                {"Microsoft.Authorization", null}
            };
            var providersToIgnore = new Dictionary<string, string>
            {
                {"Microsoft.Azure.Management.Resources.ResourceManagementClient", "2016-02-01"}
            };
            HttpMockServer.Matcher = new PermissiveRecordMatcherWithApiExclusion(true, d, providersToIgnore);
            HttpMockServer.RecordsDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SessionRecords");
            using (var context = MockContext.Start(callingClassType, mockName))
            {
                SetupManagementClients(context);

                var callingClassName = callingClassType?.Split(new[] { "." }, StringSplitOptions.RemoveEmptyEntries).Last();
                _helper.SetupEnvironment(AzureModule.AzureResourceManager);
                _helper.SetupModules(AzureModule.AzureResourceManager,
                    
                    "ScenarioTests\\" + callingClassName + ".ps1",
                    "ScenarioTests\\Common.ps1",
                    _helper.RMProfileModule,
                    _helper.RMResourceModule,
                    _helper.GetRMModulePath(@"AzureRM.DevSpaces.psd1"));

                if (scripts != null)
                {
                    _helper.RunPowerShellTest(scripts);
                }
            }
        }

    }
}
