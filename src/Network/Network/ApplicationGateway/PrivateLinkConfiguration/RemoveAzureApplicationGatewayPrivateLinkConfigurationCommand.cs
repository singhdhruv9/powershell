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
using Microsoft.Azure.Commands.Network.Models;
using System.Management.Automation;
using System.Linq;

namespace Microsoft.Azure.Commands.Network
{
    [Cmdlet(VerbsCommon.Remove, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "ApplicationGatewayPrivateLinkConfiguration"), OutputType(typeof(PSApplicationGateway))]
    public class RemoveAzureApplicationGatewayPrivateLinkConfigurationCommand : NetworkBaseCmdlet
    {
        [Parameter(Mandatory = true, HelpMessage = "The name of the application gateway privateLink configuration")]
        [ValidateNotNullOrEmpty]
        public string Name { get; set; }

        [Parameter(
             Mandatory = true,
             ValueFromPipeline = true,
             HelpMessage = "The applicationGateway")]
        public PSApplicationGateway ApplicationGateway { get; set; }

        public override void ExecuteCmdlet()
        {
            base.ExecuteCmdlet();

            var privateLinkConfiguration = this.ApplicationGateway.PrivateLinkConfigurations.SingleOrDefault
                (resource => string.Equals(resource.Name, this.Name, System.StringComparison.CurrentCultureIgnoreCase));

            if (privateLinkConfiguration != null)
            {
                this.ApplicationGateway.PrivateLinkConfigurations.Remove(privateLinkConfiguration);
            }

            WriteObject(this.ApplicationGateway);
        }
    }
}
