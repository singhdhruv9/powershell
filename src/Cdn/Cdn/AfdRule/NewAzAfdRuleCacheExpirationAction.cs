// ----------------------------------------------------------------------------------
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

using Microsoft.Azure.Commands.Cdn.AfdModels;
using Microsoft.Azure.Commands.Cdn.Common;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.Cdn.AfdRule
{
    [Cmdlet("New", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "AfdRuleCacheExpirationAction", DefaultParameterSetName = AfdParameterSet.AfdRuleBypassCache), OutputType(typeof(PSAfdRuleCacheExpirationAction))]
    public class NewAzAfdRuleCacheExpirationAction : AzureCdnCmdletBase
    {
        [Parameter(Mandatory = true, HelpMessage = HelpMessageConstants.AfdRuleBypassCache, ParameterSetName = AfdParameterSet.AfdRuleBypassCache)]
        [ValidateNotNullOrEmpty]
        public SwitchParameter BypassCache { get; set; }

        [Parameter(Mandatory = true, HelpMessage = HelpMessageConstants.AfdRuleOverride, ParameterSetName = AfdParameterSet.AfdRuleOverride)]
        [ValidateNotNullOrEmpty]
        public SwitchParameter Override { get; set; }

        [Parameter(Mandatory = true, HelpMessage = HelpMessageConstants.AfdRuleSetIfMissing, ParameterSetName = AfdParameterSet.AfdRuleSetIfMissing)]
        [ValidateNotNullOrEmpty]
        public SwitchParameter SetIfMissing { get; set; }

        [Parameter(Mandatory = true, HelpMessage = HelpMessageConstants.AfdRuleCacheDuration, ParameterSetName = AfdParameterSet.AfdRuleOverride)]
        [Parameter(Mandatory = true, HelpMessage = HelpMessageConstants.AfdRuleCacheDuration, ParameterSetName = AfdParameterSet.AfdRuleSetIfMissing)]
        [ValidateNotNullOrEmpty]
        public string CacheDuration { get; set; }

        public override void ExecuteCmdlet()
        {
            PSAfdRuleCacheExpirationAction afdRuleCacheExpirationAction = new PSAfdRuleCacheExpirationAction();

            if (ParameterSetName == AfdParameterSet.AfdRuleBypassCache)
            {
                afdRuleCacheExpirationAction.CacheBehavior = "BypassCache";
            }

            if (ParameterSetName == AfdParameterSet.AfdRuleOverride)
            {
                afdRuleCacheExpirationAction.CacheBehavior = "Override";
                afdRuleCacheExpirationAction.CacheDuration = this.CacheDuration;
            }

            if (ParameterSetName == AfdParameterSet.AfdRuleSetIfMissing)
            {
                afdRuleCacheExpirationAction.CacheBehavior = "SetIfMissing";
                afdRuleCacheExpirationAction.CacheDuration = this.CacheDuration;
            }

            WriteObject(afdRuleCacheExpirationAction);
        }
    }
}
