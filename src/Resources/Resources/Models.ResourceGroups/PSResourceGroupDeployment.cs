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

using System;
using System.Collections.Generic;

using Microsoft.Azure.Management.ResourceManager.Models;

namespace Microsoft.Azure.Commands.Resources.Models
{
    public class PSResourceGroupDeployment
    {
        public string DeploymentName { get; set; }

        public string CorrelationId { get; set; }

        public string ResourceGroupName { get; set; }

        public string ProvisioningState { get; set; }

        public DateTime Timestamp { get; set; }

        public DeploymentMode Mode { get; set; }

        public TemplateLink TemplateLink { get; set; }

        public string TemplateLinkString { get; set; }

        public string DeploymentDebugLogLevel { get; set; }

        public Dictionary<string, DeploymentVariable> Parameters { get; set; }

        public string ParametersString
        {
            get { return ResourcesExtensions.ConstructDeploymentVariableTable(Parameters); }
        }

        public Dictionary<string, DeploymentVariable> Outputs { get; set; }

        public string OutputsString
        {
            get { return ResourcesExtensions.ConstructDeploymentVariableTable(Outputs); }
        }

        public OnErrorDeploymentExtended OnErrorDeployment { get; set; }
    }
}
