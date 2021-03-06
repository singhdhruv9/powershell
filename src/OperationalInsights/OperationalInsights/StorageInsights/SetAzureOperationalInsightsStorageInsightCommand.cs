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

using Microsoft.Azure.Commands.OperationalInsights.Models;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using System.Linq;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.OperationalInsights
{
    [Cmdlet("Set", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "OperationalInsightsStorageInsight", DefaultParameterSetName = ByWorkspaceName), OutputType(typeof(PSStorageInsight))]
    public class SetAzureOperationalInsightsStorageInsightCommand : OperationalInsightsBaseCmdlet
    {
        [Parameter(Position = 0, ParameterSetName = ByWorkspaceObject, Mandatory = true, ValueFromPipeline = true,
            HelpMessage = "The workspace that will contain the storage insight.")]
        [ValidateNotNull]
        public PSWorkspace Workspace { get; set; }

        [Parameter(Position = 1, ParameterSetName = ByWorkspaceName, Mandatory = true, ValueFromPipelineByPropertyName = true,
            HelpMessage = "The resource group name.")]
        [ResourceGroupCompleter]
        [ValidateNotNullOrEmpty]
        public string ResourceGroupName { get; set; }

        [Parameter(Position = 2, ParameterSetName = ByWorkspaceName, Mandatory = true, ValueFromPipelineByPropertyName = true,
            HelpMessage = "The name of the workspace that will contain the storage insight.")]
        [ValidateNotNullOrEmpty]
        public string WorkspaceName { get; set; }

        [Parameter(Position = 3, Mandatory = true, ValueFromPipelineByPropertyName = true,
            HelpMessage = "The storage insight name.")]
        [ValidateNotNullOrEmpty]
        public string Name { get; set; }

        [Parameter(Position = 4, Mandatory = false, ValueFromPipelineByPropertyName = true,
            HelpMessage = "The access key for the storage account.")]
        [ValidateNotNullOrEmpty]
        public string StorageAccountKey { get; set; }

        [Parameter(Position = 5, Mandatory = false, ValueFromPipelineByPropertyName = true,
            HelpMessage = "The Azure Storage tables that the storage insight will read data from.")]
        public string[] Tables { get; set; }

        [Parameter(Position = 6, Mandatory = false, ValueFromPipelineByPropertyName = true,
            HelpMessage = "The Azure Storage blob containers that the storage insight will read data from.")]
        public string[] Containers { get; set; }

        public override void ExecuteCmdlet()
        {
            if (ParameterSetName == ByWorkspaceObject)
            {
                ResourceGroupName = Workspace.ResourceGroupName;
                WorkspaceName = Workspace.Name;
            }

            UpdatePSStorageInsightParameters parameters = new UpdatePSStorageInsightParameters
            {
                ResourceGroupName = ResourceGroupName,
                WorkspaceName = WorkspaceName,
                Name = Name,
                StorageAccountKey = StorageAccountKey,
                Containers = Containers != null ? Containers.ToList() : null,
                Tables = Tables != null ? Tables.ToList() : null
            };

            WriteObject(OperationalInsightsClient.UpdatePSStorageInsight(parameters));
        }
    }
}
