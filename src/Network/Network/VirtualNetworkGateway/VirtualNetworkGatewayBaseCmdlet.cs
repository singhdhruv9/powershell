
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

using AutoMapper;
using Microsoft.Azure.Commands.Network.Models;
using Microsoft.Azure.Commands.ResourceManager.Common.Tags;
using Microsoft.Azure.Management.Network;
using System.Net;

namespace Microsoft.Azure.Commands.Network
{
    public abstract class VirtualNetworkGatewayBaseCmdlet : NetworkBaseCmdlet
    {
        public IVirtualNetworkGatewaysOperations VirtualNetworkGatewayClient
        {
            get
            {
                return NetworkClient.NetworkManagementClient.VirtualNetworkGateways;
            }
        }

        public bool IsVirtualNetworkGatewayPresent(string resourceGroupName, string name)
        {
            try
            {
                GetVirtualNetworkGateway(resourceGroupName, name);
            }
            catch (Microsoft.Rest.Azure.CloudException exception)
            {
                if (exception.Response.StatusCode == HttpStatusCode.NotFound)
                {
                    // Resource is not present
                    return false;
                }
                throw;
            }

            return true;
        }

        public PSVirtualNetworkGateway GetVirtualNetworkGateway(string resourceGroupName, string name)
        {
            var vnetGateway = this.VirtualNetworkGatewayClient.Get(resourceGroupName, name);

            var psVirtualNetworkGateway = ToPsVirtualNetworkGateway(vnetGateway);
            psVirtualNetworkGateway.ResourceGroupName = resourceGroupName;

            return psVirtualNetworkGateway;
        }

        public PSVirtualNetworkGateway ToPsVirtualNetworkGateway(Management.Network.Models.VirtualNetworkGateway vnetGateway)
        {
            var psVirtualNetworkGateway = NetworkResourceManagerProfile.Mapper.Map<PSVirtualNetworkGateway>(vnetGateway);

            psVirtualNetworkGateway.Tag = TagsConversionHelper.CreateTagHashtable(vnetGateway.Tags);

            return psVirtualNetworkGateway;
        }

        public PSVpnClientIPsecParameters GetVpnClientIpsecParameters(string resourceGroupName, string name)
        {
            var vpnClientIPsecParameters = this.VirtualNetworkGatewayClient.GetVpnclientIpsecParameters(resourceGroupName, name);

            var psVpnClientIPsecParameters = NetworkResourceManagerProfile.Mapper.Map<PSVpnClientIPsecParameters>(vpnClientIPsecParameters);

            return psVpnClientIPsecParameters;
        }

        public string FormatIdBgpPeeringAddresses(string id, string resourceGroupName, string resourceName)
        {
            string result = ChildResourceHelp.NormalizeVirtualNetworkGatewayChildResourceIds(id, resourceGroupName, resourceName);
            result = result.Replace("virtualNetworkGatewayIpConfiguration", "ipConfigurations");
            return result;
        }
    }
}