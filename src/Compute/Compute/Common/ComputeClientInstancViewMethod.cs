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

using Microsoft.Azure.Management.Compute;
using Microsoft.Azure.Management.Compute.Models;
using Microsoft.Rest.Azure;


namespace Microsoft.Azure.Commands.Compute.Common
{
    public static class InstanceViewMethod
    {
        public static AzureOperationResponse<VirtualMachineExtension> GetWithInstanceView(this IVirtualMachineExtensionsOperations iVmExtensionOperations,
            string rgName, string vmName, string name)
        {
            string expand = "instanceView";
            var result = iVmExtensionOperations.GetWithHttpMessagesAsync(rgName, vmName, name, expand).GetAwaiter().GetResult();
            return result;
        }

        public static AzureOperationResponse<VirtualMachineExtensionsListResult> ListWithInstanceView(this IVirtualMachineExtensionsOperations iVmExtensionOperations,
           string rgName, string vmName)
        {
            string expand = "instanceView";
            var result = iVmExtensionOperations.ListWithHttpMessagesAsync(rgName, vmName, expand).GetAwaiter().GetResult();

            foreach (var vmExtension in result.Body.Value)
            {
                if (vmExtension.InstanceView == null)
                {
                    vmExtension.InstanceView = iVmExtensionOperations.GetWithInstanceView(rgName, vmName, vmExtension.Name).Body.InstanceView;
                }
            }

            return result;
        }

        public static AzureOperationResponse<VirtualMachine> GetWithInstanceView(this IVirtualMachinesOperations iVmExtensionOperations,
            string rgName, string vmName)
        {
            const InstanceViewTypes expand = InstanceViewTypes.InstanceView;
            var result = iVmExtensionOperations.GetWithHttpMessagesAsync(rgName, vmName, expand).GetAwaiter().GetResult();
            return result;
        }
    }


}
