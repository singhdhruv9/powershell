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

namespace Microsoft.Azure.Commands.LogicApp.Cmdlets
{
    using System;
    using System.Management.Automation;
    using Microsoft.Azure.Commands.LogicApp.Utilities;
    using Microsoft.Azure.Management.Logic.Models;
    using Newtonsoft.Json.Linq;
    using ResourceManager.Common.ArgumentCompleters;

    /// <summary>
    /// Creates a new integration account 
    /// </summary>
    [Cmdlet("New", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "IntegrationAccount", SupportsShouldProcess = true)]
    [OutputType(typeof(IntegrationAccount))]
    public class NewAzureIntegrationAccountCommand : LogicAppBaseCmdlet
    {

        #region Input Parameters

        [Parameter(Mandatory = true, HelpMessage = "The integration account resource group name.",
            ValueFromPipelineByPropertyName = true)]
        [ResourceGroupCompleter]
        [ValidateNotNullOrEmpty]
        public string ResourceGroupName { get; set; }

        [Parameter(Mandatory = true, HelpMessage = "The integration account name.",
            ValueFromPipelineByPropertyName = true)]
        [ValidateNotNullOrEmpty]
        [Alias("IntegrationAccountName", "ResourceName")]
        public string Name { get; set; }

        [Parameter(Mandatory = true, HelpMessage = "The integration account location.",
            ValueFromPipelineByPropertyName = true)]
        [LocationCompleter("Microsoft.Logic/integrationAccounts")]
        [ValidateNotNullOrEmpty]
        public string Location { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "The integration account SKU.",
            ValueFromPipelineByPropertyName = true)]
        [ValidateSet("Free", "Basic", "Standard", IgnoreCase = true)]
        [ValidateNotNullOrEmpty]
        public string Sku { get; set; }

        #endregion Input Parameters

        /// <summary>
        /// Executes the integration account create command
        /// </summary>
        public override void ExecuteCmdlet()
        {
            base.ExecuteCmdlet();

            this.WriteObject(
                IntegrationAccountClient.CreateIntegrationAccount(this.ResourceGroupName, this.Name, new IntegrationAccount
                {
                    Location = this.Location,
                    Sku = new IntegrationAccountSku
                    {
                        Name = this.Sku
                    },
                    Properties = new JObject()

                }), true);
        }
    }
}
