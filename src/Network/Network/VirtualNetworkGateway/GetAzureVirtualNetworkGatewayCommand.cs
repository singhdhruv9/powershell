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

using Microsoft.Azure.Commands.Network.Models;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Management.Network;
using Microsoft.Azure.Management.Network.Models;
using System.Collections.Generic;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.Network
{
    [Cmdlet("Get", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "VirtualNetworkGateway"), OutputType(typeof(PSVirtualNetworkGateway))]
    public class GetAzureVirtualNetworkGatewayCommand : VirtualNetworkGatewayBaseCmdlet
    {
        [Alias("ResourceName")]
        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The resource name.")]
        [ResourceNameCompleter("Microsoft.Network/virtualNetworkGateways", "ResourceGroupName")]
        [ValidateNotNullOrEmpty]
        [SupportsWildcards]
        public virtual string Name { get; set; }

        [Parameter(
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The resource group name.")]
        [ResourceGroupCompleter]
        [ValidateNotNullOrEmpty]
        [SupportsWildcards]
        public virtual string ResourceGroupName { get; set; }

        public override void Execute()
        {
            base.Execute();
            if (ShouldGetByName(ResourceGroupName, Name))
            {
                var vnetGateway = this.GetVirtualNetworkGateway(this.ResourceGroupName, this.Name);

                WriteObject(vnetGateway);
            }
            else if (!string.IsNullOrEmpty(this.ResourceGroupName))
            {
                var vnetGatewayPage = this.VirtualNetworkGatewayClient.List(this.ResourceGroupName);

                // Get all resources by polling on next page link
                var vnetGatewayList = ListNextLink<Management.Network.Models.VirtualNetworkGateway>.GetAllResourcesByPollingNextLink(vnetGatewayPage, this.VirtualNetworkGatewayClient.ListNext);

                var psVnetGateways = new List<PSVirtualNetworkGateway>();
                foreach (var virtualNetworkGateway in vnetGatewayList)
                {
                    var psVnetGateway = this.ToPsVirtualNetworkGateway(virtualNetworkGateway);
                    psVnetGateway.ResourceGroupName = this.ResourceGroupName;
                    psVnetGateways.Add(psVnetGateway);
                }

                WriteObject(TopLevelWildcardFilter(ResourceGroupName, Name, psVnetGateways), true);
            }
        }
    }
}
