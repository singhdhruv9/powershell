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

namespace Microsoft.Azure.Commands.PolicyInsights.Cmdlets
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Management.Automation;
    using Microsoft.Azure.Commands.PolicyInsights.Common;
    using Microsoft.Azure.Commands.PolicyInsights.Models;
    using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
    using Microsoft.Azure.Management.PolicyInsights;
    using RestApiModels = Microsoft.Azure.Management.PolicyInsights.Models;

    /// <summary>
    /// Gets policy events
    /// </summary>
    [Cmdlet("Get", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "PolicyEvent", DefaultParameterSetName = ParameterSetNames.SubscriptionScope), OutputType(typeof(PolicyEvent))]
    public class GetAzureRmPolicyEvent : PolicyInsightsCmdletBase
    {
        [Parameter(ParameterSetName = ParameterSetNames.ManagementGroupScope, Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = ParameterHelpMessages.ManagementGroupName)]
        [ValidateNotNullOrEmpty]
        public string ManagementGroupName { get; set; }

        [Parameter(ParameterSetName = ParameterSetNames.SubscriptionScope, Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = ParameterHelpMessages.SubscriptionId)]
        [Parameter(ParameterSetName = ParameterSetNames.ResourceGroupScope, Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = ParameterHelpMessages.SubscriptionId)]
        [Parameter(ParameterSetName = ParameterSetNames.PolicySetDefinitionScope, Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = ParameterHelpMessages.SubscriptionId)]
        [Parameter(ParameterSetName = ParameterSetNames.PolicyDefinitionScope, Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = ParameterHelpMessages.SubscriptionId)]
        [Parameter(ParameterSetName = ParameterSetNames.SubscriptionLevelPolicyAssignmentScope, Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = ParameterHelpMessages.SubscriptionId)]
        [Parameter(ParameterSetName = ParameterSetNames.ResourceGroupLevelPolicyAssignmentScope, Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = ParameterHelpMessages.SubscriptionId)]
        [ValidateNotNullOrEmpty]
        public string SubscriptionId { get; set; }

        [Parameter(ParameterSetName = ParameterSetNames.ResourceGroupScope, Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = ParameterHelpMessages.ResourceGroupName)]
        [Parameter(ParameterSetName = ParameterSetNames.ResourceGroupLevelPolicyAssignmentScope, Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = ParameterHelpMessages.ResourceGroupName)]
        [ResourceGroupCompleter]
        [ValidateNotNullOrEmpty]
        public string ResourceGroupName { get; set; }

        [Parameter(ParameterSetName = ParameterSetNames.ResourceScope, Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = ParameterHelpMessages.ResourceId)]
        [ValidateNotNullOrEmpty]
        public string ResourceId { get; set; }

        [Parameter(ParameterSetName = ParameterSetNames.PolicySetDefinitionScope, Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = ParameterHelpMessages.PolicySetDefinitionName)]
        [ValidateNotNullOrEmpty]
        public string PolicySetDefinitionName { get; set; }

        [Parameter(ParameterSetName = ParameterSetNames.PolicyDefinitionScope, Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = ParameterHelpMessages.PolicyDefinitionName)]
        [ValidateNotNullOrEmpty]
        public string PolicyDefinitionName { get; set; }

        [Parameter(ParameterSetName = ParameterSetNames.SubscriptionLevelPolicyAssignmentScope, Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = ParameterHelpMessages.PolicyAssignmentName)]
        [Parameter(ParameterSetName = ParameterSetNames.ResourceGroupLevelPolicyAssignmentScope, Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = ParameterHelpMessages.PolicyAssignmentName)]
        [ValidateNotNullOrEmpty]
        public string PolicyAssignmentName { get; set; }

        [Parameter(ParameterSetName = ParameterSetNames.ManagementGroupScope, Mandatory = false, HelpMessage = ParameterHelpMessages.Top)]
        [Parameter(ParameterSetName = ParameterSetNames.SubscriptionScope, Mandatory = false, HelpMessage = ParameterHelpMessages.Top)]
        [Parameter(ParameterSetName = ParameterSetNames.ResourceGroupScope, Mandatory = false, HelpMessage = ParameterHelpMessages.Top)]
        [Parameter(ParameterSetName = ParameterSetNames.ResourceScope, Mandatory = false, HelpMessage = ParameterHelpMessages.Top)]
        [Parameter(ParameterSetName = ParameterSetNames.PolicySetDefinitionScope, Mandatory = false, HelpMessage = ParameterHelpMessages.Top)]
        [Parameter(ParameterSetName = ParameterSetNames.PolicyDefinitionScope, Mandatory = false, HelpMessage = ParameterHelpMessages.Top)]
        [Parameter(ParameterSetName = ParameterSetNames.SubscriptionLevelPolicyAssignmentScope, Mandatory = false, HelpMessage = ParameterHelpMessages.Top)]
        [Parameter(ParameterSetName = ParameterSetNames.ResourceGroupLevelPolicyAssignmentScope, Mandatory = false, HelpMessage = ParameterHelpMessages.Top)]
        public int Top { get; set; }

        [Parameter(ParameterSetName = ParameterSetNames.ManagementGroupScope, Mandatory = false, HelpMessage = ParameterHelpMessages.OrderBy)]
        [Parameter(ParameterSetName = ParameterSetNames.SubscriptionScope, Mandatory = false, HelpMessage = ParameterHelpMessages.OrderBy)]
        [Parameter(ParameterSetName = ParameterSetNames.ResourceGroupScope, Mandatory = false, HelpMessage = ParameterHelpMessages.OrderBy)]
        [Parameter(ParameterSetName = ParameterSetNames.ResourceScope, Mandatory = false, HelpMessage = ParameterHelpMessages.OrderBy)]
        [Parameter(ParameterSetName = ParameterSetNames.PolicySetDefinitionScope, Mandatory = false, HelpMessage = ParameterHelpMessages.OrderBy)]
        [Parameter(ParameterSetName = ParameterSetNames.PolicyDefinitionScope, Mandatory = false, HelpMessage = ParameterHelpMessages.OrderBy)]
        [Parameter(ParameterSetName = ParameterSetNames.SubscriptionLevelPolicyAssignmentScope, Mandatory = false, HelpMessage = ParameterHelpMessages.OrderBy)]
        [Parameter(ParameterSetName = ParameterSetNames.ResourceGroupLevelPolicyAssignmentScope, Mandatory = false, HelpMessage = ParameterHelpMessages.OrderBy)]
        [ValidateNotNullOrEmpty]
        public string OrderBy { get; set; }

        [Parameter(ParameterSetName = ParameterSetNames.ManagementGroupScope, Mandatory = false, HelpMessage = ParameterHelpMessages.Select)]
        [Parameter(ParameterSetName = ParameterSetNames.SubscriptionScope, Mandatory = false, HelpMessage = ParameterHelpMessages.Select)]
        [Parameter(ParameterSetName = ParameterSetNames.ResourceGroupScope, Mandatory = false, HelpMessage = ParameterHelpMessages.Select)]
        [Parameter(ParameterSetName = ParameterSetNames.ResourceScope, Mandatory = false, HelpMessage = ParameterHelpMessages.Select)]
        [Parameter(ParameterSetName = ParameterSetNames.PolicySetDefinitionScope, Mandatory = false, HelpMessage = ParameterHelpMessages.Select)]
        [Parameter(ParameterSetName = ParameterSetNames.PolicyDefinitionScope, Mandatory = false, HelpMessage = ParameterHelpMessages.Select)]
        [Parameter(ParameterSetName = ParameterSetNames.SubscriptionLevelPolicyAssignmentScope, Mandatory = false, HelpMessage = ParameterHelpMessages.Select)]
        [Parameter(ParameterSetName = ParameterSetNames.ResourceGroupLevelPolicyAssignmentScope, Mandatory = false, HelpMessage = ParameterHelpMessages.Select)]
        [ValidateNotNullOrEmpty]
        public string Select { get; set; }

        [Parameter(ParameterSetName = ParameterSetNames.ManagementGroupScope, Mandatory = false, HelpMessage = ParameterHelpMessages.From)]
        [Parameter(ParameterSetName = ParameterSetNames.SubscriptionScope, Mandatory = false, HelpMessage = ParameterHelpMessages.From)]
        [Parameter(ParameterSetName = ParameterSetNames.ResourceGroupScope, Mandatory = false, HelpMessage = ParameterHelpMessages.From)]
        [Parameter(ParameterSetName = ParameterSetNames.ResourceScope, Mandatory = false, HelpMessage = ParameterHelpMessages.From)]
        [Parameter(ParameterSetName = ParameterSetNames.PolicySetDefinitionScope, Mandatory = false, HelpMessage = ParameterHelpMessages.From)]
        [Parameter(ParameterSetName = ParameterSetNames.PolicyDefinitionScope, Mandatory = false, HelpMessage = ParameterHelpMessages.From)]
        [Parameter(ParameterSetName = ParameterSetNames.SubscriptionLevelPolicyAssignmentScope, Mandatory = false, HelpMessage = ParameterHelpMessages.From)]
        [Parameter(ParameterSetName = ParameterSetNames.ResourceGroupLevelPolicyAssignmentScope, Mandatory = false, HelpMessage = ParameterHelpMessages.From)]
        public DateTime From { get; set; }

        [Parameter(ParameterSetName = ParameterSetNames.ManagementGroupScope, Mandatory = false, HelpMessage = ParameterHelpMessages.To)]
        [Parameter(ParameterSetName = ParameterSetNames.SubscriptionScope, Mandatory = false, HelpMessage = ParameterHelpMessages.To)]
        [Parameter(ParameterSetName = ParameterSetNames.ResourceGroupScope, Mandatory = false, HelpMessage = ParameterHelpMessages.To)]
        [Parameter(ParameterSetName = ParameterSetNames.ResourceScope, Mandatory = false, HelpMessage = ParameterHelpMessages.To)]
        [Parameter(ParameterSetName = ParameterSetNames.PolicySetDefinitionScope, Mandatory = false, HelpMessage = ParameterHelpMessages.To)]
        [Parameter(ParameterSetName = ParameterSetNames.PolicyDefinitionScope, Mandatory = false, HelpMessage = ParameterHelpMessages.To)]
        [Parameter(ParameterSetName = ParameterSetNames.SubscriptionLevelPolicyAssignmentScope, Mandatory = false, HelpMessage = ParameterHelpMessages.To)]
        [Parameter(ParameterSetName = ParameterSetNames.ResourceGroupLevelPolicyAssignmentScope, Mandatory = false, HelpMessage = ParameterHelpMessages.To)]
        public DateTime To { get; set; }

        [Parameter(ParameterSetName = ParameterSetNames.ManagementGroupScope, Mandatory = false, HelpMessage = ParameterHelpMessages.Filter)]
        [Parameter(ParameterSetName = ParameterSetNames.SubscriptionScope, Mandatory = false, HelpMessage = ParameterHelpMessages.Filter)]
        [Parameter(ParameterSetName = ParameterSetNames.ResourceGroupScope, Mandatory = false, HelpMessage = ParameterHelpMessages.Filter)]
        [Parameter(ParameterSetName = ParameterSetNames.ResourceScope, Mandatory = false, HelpMessage = ParameterHelpMessages.Filter)]
        [Parameter(ParameterSetName = ParameterSetNames.PolicySetDefinitionScope, Mandatory = false, HelpMessage = ParameterHelpMessages.Filter)]
        [Parameter(ParameterSetName = ParameterSetNames.PolicyDefinitionScope, Mandatory = false, HelpMessage = ParameterHelpMessages.Filter)]
        [Parameter(ParameterSetName = ParameterSetNames.SubscriptionLevelPolicyAssignmentScope, Mandatory = false, HelpMessage = ParameterHelpMessages.Filter)]
        [Parameter(ParameterSetName = ParameterSetNames.ResourceGroupLevelPolicyAssignmentScope, Mandatory = false, HelpMessage = ParameterHelpMessages.Filter)]
        [ValidateNotNullOrEmpty]
        public string Filter { get; set; }

        [Parameter(ParameterSetName = ParameterSetNames.ManagementGroupScope, Mandatory = false, HelpMessage = ParameterHelpMessages.Apply)]
        [Parameter(ParameterSetName = ParameterSetNames.SubscriptionScope, Mandatory = false, HelpMessage = ParameterHelpMessages.Apply)]
        [Parameter(ParameterSetName = ParameterSetNames.ResourceGroupScope, Mandatory = false, HelpMessage = ParameterHelpMessages.Apply)]
        [Parameter(ParameterSetName = ParameterSetNames.ResourceScope, Mandatory = false, HelpMessage = ParameterHelpMessages.Apply)]
        [Parameter(ParameterSetName = ParameterSetNames.PolicySetDefinitionScope, Mandatory = false, HelpMessage = ParameterHelpMessages.Apply)]
        [Parameter(ParameterSetName = ParameterSetNames.PolicyDefinitionScope, Mandatory = false, HelpMessage = ParameterHelpMessages.Apply)]
        [Parameter(ParameterSetName = ParameterSetNames.SubscriptionLevelPolicyAssignmentScope, Mandatory = false, HelpMessage = ParameterHelpMessages.Apply)]
        [Parameter(ParameterSetName = ParameterSetNames.ResourceGroupLevelPolicyAssignmentScope, Mandatory = false, HelpMessage = ParameterHelpMessages.Apply)]
        [ValidateNotNullOrEmpty]
        public string Apply { get; set; }

        /// <summary>
        /// Executes the cmdlet
        /// </summary>
        public override void Execute()
        {
            var queryOptions = new RestApiModels.QueryOptions
            {
                Top = MyInvocation.BoundParameters.ContainsKey("Top") ? (int?)Top : null,
                OrderBy = OrderBy,
                Select = Select,
                FromProperty = MyInvocation.BoundParameters.ContainsKey("From") ? (DateTime?)From : null,
                To = MyInvocation.BoundParameters.ContainsKey("To") ? (DateTime?)To : null,
                Filter = Filter,
                Apply = Apply
            };

            RestApiModels.PolicyEventsQueryResults policyEventsQueryResults;

            switch (ParameterSetName)
            {
                case ParameterSetNames.ManagementGroupScope:
                    policyEventsQueryResults = PolicyInsightsClient.PolicyEvents.ListQueryResultsForManagementGroup(
                        ManagementGroupName,
                        queryOptions);
                    break;
                case ParameterSetNames.SubscriptionScope:
                    policyEventsQueryResults = PolicyInsightsClient.PolicyEvents.ListQueryResultsForSubscription(
                        SubscriptionId ?? DefaultContext.Subscription.Id,
                        queryOptions);
                    break;
                case ParameterSetNames.ResourceGroupScope:
                    policyEventsQueryResults = PolicyInsightsClient.PolicyEvents.ListQueryResultsForResourceGroup(
                        SubscriptionId ?? DefaultContext.Subscription.Id,
                        ResourceGroupName,
                        queryOptions);
                    break;
                case ParameterSetNames.ResourceScope:
                    policyEventsQueryResults = PolicyInsightsClient.PolicyEvents.ListQueryResultsForResource(
                        ResourceId,
                        queryOptions);
                    break;
                case ParameterSetNames.PolicySetDefinitionScope:
                    policyEventsQueryResults = PolicyInsightsClient.PolicyEvents.ListQueryResultsForPolicySetDefinition(
                        SubscriptionId ?? DefaultContext.Subscription.Id,
                        PolicySetDefinitionName,
                        queryOptions);
                    break;
                case ParameterSetNames.PolicyDefinitionScope:
                    policyEventsQueryResults = PolicyInsightsClient.PolicyEvents.ListQueryResultsForPolicyDefinition(
                        SubscriptionId ?? DefaultContext.Subscription.Id,
                        PolicyDefinitionName,
                        queryOptions);
                    break;
                case ParameterSetNames.SubscriptionLevelPolicyAssignmentScope:
                    policyEventsQueryResults = PolicyInsightsClient.PolicyEvents.ListQueryResultsForSubscriptionLevelPolicyAssignment(
                        SubscriptionId ?? DefaultContext.Subscription.Id,
                        PolicyAssignmentName,
                        queryOptions);
                    break;
                case ParameterSetNames.ResourceGroupLevelPolicyAssignmentScope:
                    policyEventsQueryResults = PolicyInsightsClient.PolicyEvents.ListQueryResultsForResourceGroupLevelPolicyAssignment(
                        SubscriptionId ?? DefaultContext.Subscription.Id,
                        ResourceGroupName,
                        PolicyAssignmentName,
                        queryOptions);
                    break;
                default:
                    throw new PSInvalidOperationException();
            }

            WriteObject(policyEventsQueryResults.Value.Select(policyEvent => new PolicyEvent(policyEvent)), true);
        }
    }
}
