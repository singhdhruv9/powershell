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

using Microsoft.Azure.Commands.DevTestLabs.Models;
using Microsoft.Azure.Commands.DevTestLabs.Properties;
using Microsoft.Azure.Management.DevTestLabs;
using Microsoft.Azure.Management.DevTestLabs.Models;
using Microsoft.Rest.Azure;
using System;
using System.Globalization;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.DevTestLabs
{
    [Cmdlet("Set", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "DtlAutoShutdownPolicy",HelpUri = Constants.DevTestLabsHelpUri,DefaultParameterSetName = ParameterSetEnable,SupportsShouldProcess = true)]
    [OutputType(typeof(PSSchedule))]
    public class SetAzureRmDtlAutoShutdownPolicy : DtlPolicyCmdletBase
    {
        protected override string PolicyName
        {
            get
            {
                return WellKnownPolicyNames.LabVmsShutdown;
            }
        }

        #region Input Parameter Definitions

        /// <summary>
        /// Time of day for shutting down the virtual machine.
        /// </summary>
        [Parameter(Mandatory = false,
            Position = 4,
            HelpMessage = "Time of day for shutting down the virtual machine.")]
        public DateTime? Time { get; set; }

        #endregion Input Parameter Definitions

        public override void ExecuteCmdlet()
        {
            Schedule inputSchedule = null;

            try
            {
                inputSchedule = DataServiceClient.Schedules.Get(
                                LabName,
                                PolicyName);
            }
            catch (CloudException ex)
            {
                if (ex.Response.StatusCode != System.Net.HttpStatusCode.NotFound
                    || Time == null)
                {
                    throw;
                }
            }

            // Do nothing if user cancelled the operation
            var actionDescription = string.Format(CultureInfo.CurrentCulture, Resources.SavePolicyDescription, PolicyName, LabName);
            string actionWarning;

            if (inputSchedule == null)
            {
                inputSchedule = new Schedule
                {
                    TimeZoneId = TimeZoneInfo.Local.Id,
                    TaskType = "LabVmsShutdownTask",
                    DailyRecurrence = new DayDetails
                    {
                        Time = Time.Value.ToString("HHmm")
                    },
                    Status = Disable ? PolicyStatus.Disabled : PolicyStatus.Enabled
                };

                actionWarning = string.Format(CultureInfo.CurrentCulture,
                    Resources.CreatePolicyWarning,
                    PolicyName);
            }
            else
            {
                actionWarning = string.Format(CultureInfo.CurrentCulture,
                    Resources.AlterPolicyWarning,
                    PolicyName);

                if (Time.HasValue)
                {
                    inputSchedule.DailyRecurrence = new DayDetails
                    {
                        Time = Time.Value.ToString("HHmm")
                    };
                }

                if (Disable)
                {
                    inputSchedule.Status = PolicyStatus.Disabled;
                }

                if (Enable)
                {
                    inputSchedule.Status = PolicyStatus.Enabled;
                }
            }

            if (!ShouldProcess(
                actionDescription,
                actionWarning,
                Resources.ShouldProcessCaption))
            {
                return;
            }

            var outputSchedule = DataServiceClient.Schedules.CreateOrUpdate(
                LabName,
                PolicyName,
                inputSchedule);

            WriteObject(outputSchedule.DuckType<PSSchedule>());
        }
    }
}
