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
using Microsoft.Azure.Management.Network;
using Microsoft.Azure.Management.Network.Models;
using System.Net;

namespace Microsoft.Azure.Commands.Network
{
    public abstract class VirtualApplianceSiteBaseCmdlet : NetworkBaseCmdlet
    {
        public IVirtualApplianceSitesOperations VirtualApplianceSitesClient
        {
            get
            {
                return NetworkClient.NetworkManagementClient.VirtualApplianceSites;
            }
        }

        public bool IsVirtualApplianceSitePresent(string resourceGroupName, string nvaName, string name)
        {
            try
            {
                GetVirtualApplianceSite(resourceGroupName, nvaName, name);
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

        public PSVirtualApplianceSite GetVirtualApplianceSite(string resourceGroupName, string nvaName, string name)
        {
            var nvaSite = this.VirtualApplianceSitesClient.Get(resourceGroupName, nvaName, name);

            var psSite = NetworkResourceManagerProfile.Mapper.Map<PSVirtualApplianceSite>(nvaSite);
            return psSite;
        }
        public PSVirtualApplianceSite ToPsVirtualApplianceSite(VirtualApplianceSite nvasite)
        {
            var psSite = NetworkResourceManagerProfile.Mapper.Map<PSVirtualApplianceSite>(nvasite);
            return psSite;
        }
    }
}
