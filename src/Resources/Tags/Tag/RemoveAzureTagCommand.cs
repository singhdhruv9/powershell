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

using System.Linq;
using System.Management.Automation;
using Microsoft.Azure.Commands.ResourceManager.Common.Tags;
using Microsoft.Azure.Commands.Tags.Client;
using Microsoft.Azure.Commands.Tags.Model;
using Microsoft.Azure.Commands.Tags.Properties;

namespace Microsoft.Azure.Commands.Tags.Tag
{
    /// <summary>
    /// Deletes predefined Azure tags or values | Deletes the entire set of tags on a resource or subscription.
    /// </summary>
    [Cmdlet("Remove", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "Tag", SupportsShouldProcess = true), OutputType(typeof(PSTag), typeof(PSTagResource))]
    public class RemoveAzureTagCommand : TagBaseCmdlet
    {
        #region Parameter Set Names

        private const string RemovePredefinedTagParameterSet = "RemovePredefinedTagParameterSet";
        private const string RemoveByResourceIdParameterSet = "RemoveByResourceIdParameterSet";

        #endregion

        #region Input Parameter Definitions

        [Parameter(Position = 0, 
            Mandatory = true, 
            ValueFromPipelineByPropertyName = true,
            ParameterSetName = RemovePredefinedTagParameterSet,
            HelpMessage = "Name of the predefined tag to remove.")]
        [ValidateNotNullOrEmpty]
        public string Name { get; set; }

        [Parameter(Position = 1, 
            Mandatory = false, 
            ValueFromPipelineByPropertyName = true,
            ParameterSetName = RemovePredefinedTagParameterSet,
            HelpMessage = "Predefined tag value to remove.")]
        [ValidateNotNullOrEmpty]
        public string[] Value { get; set; }

        [Parameter(Mandatory = false, 
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "Return object if specified.")]
        public SwitchParameter PassThru { get; set; }

        [Parameter(Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            ParameterSetName = RemoveByResourceIdParameterSet,
            HelpMessage = "The resource identifier for the tagged entity. A resource, a resource group or a subscription may be tagged.")]
        [ValidateNotNullOrEmpty]
        public string ResourceId { get; set; }

        #endregion

        public override void ExecuteCmdlet()
        {
            if (!string.IsNullOrWhiteSpace(this.ResourceId))
            {
                if(ShouldProcess(this.ResourceId, Resources.RemoveTagMessage))        
                {
                    var res = TagsClient.DeleteTagAtScope(this.ResourceId);
                    if (this.PassThru.IsPresent)
                    {
                        WriteObject(res);
                    }
                }
            }
            else
            {
                PSTag tag = null;

                ConfirmAction(
                    Resources.RemovePredefinedTagMessage,
                    Name,
                    () =>
                    {
                        tag = TagsClient.DeleteTag(Name, Value != null ? Value.ToList() : null);
                        if (PassThru)
                        {
                            WriteObject(tag);
                        }
                    });
            }
        }
    }
}
