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

namespace Microsoft.Azure.Commands.ResourceManager.Cmdlets.Implementation
{
    using Common.ArgumentCompleters;
    using Microsoft.Azure.Commands.ResourceManager.Cmdlets.SdkModels;
    using System.Collections;
    using System.Collections.Generic;
    using System.Management.Automation;

    /// <summary>
    /// Filters resource groups.
    /// </summary>
    [Cmdlet("New", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "ResourceGroup", SupportsShouldProcess = true), OutputType(typeof(PSResourceGroup))]
    public class NewAzureResourceGroupCmdlet : ResourceManagerCmdletBaseWithApiVersion
    {
        [Alias("ResourceGroupName")]
        [Parameter(Position = 0, Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The resource group name.")]
        [ResourceGroupCompleter]
        [ValidateNotNullOrEmpty]
        public string Name { get; set; }

        [Parameter(Position = 1, Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The resource group location.")]
        [LocationCompleter("Microsoft.Resources/resourceGroups")]
        [ValidateNotNullOrEmpty]
        public string Location { get; set; }

        [Alias("Tags")]
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = "A hashtable which represents resource tags.")]
        public Hashtable Tag { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "Do not ask for confirmation.")]
        public SwitchParameter Force { get; set; }

        protected override void OnProcessRecord()
        {
            PSCreateResourceGroupParameters parameters = new PSCreateResourceGroupParameters
            {
                ResourceGroupName = Name,
                Location = Location,
                Force = Force.IsPresent,
                Tag = Tag,
                ConfirmAction = ConfirmAction
            };

            WriteObject(ResourceManagerSdkClient.CreatePSResourceGroup(parameters));
        }
    }
}
