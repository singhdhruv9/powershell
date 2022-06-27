//
// Copyright (c) Microsoft and contributors.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//
// See the License for the specific language governing permissions and
// limitations under the License.
//

// Warning: This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Management.Automation;
using Microsoft.Azure.Commands.Compute.Automation.Models;
using Microsoft.Azure.Commands.Common.Strategies;
using Microsoft.Azure.Commands.Compute.Strategies;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Management.Compute;
using Microsoft.Azure.Management.Compute.Models;
using Microsoft.WindowsAzure.Commands.Utilities.Common;
using Microsoft.Azure.Commands.Compute.Common;
using AutoMapper;
using Microsoft.Azure.Commands.Compute.Strategies.ComputeRp;



namespace Microsoft.Azure.Commands.Compute.Automation
{
    [Cmdlet(VerbsCommon.New, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "Vmss", DefaultParameterSetName = "DefaultParameter", SupportsShouldProcess = true)]
    [OutputType(typeof(PSVirtualMachineScaleSet))]
    public partial class NewAzureRmVmss : ComputeAutomationBaseCmdlet
    {
        public const string SimpleParameterSet = "SimpleParameterSet", DefaultParameter = "DefaultParameter";
        public const int vmssFlexibleOrchestrationModeNetworkAPIVersionMinimumInt = 20201101;
        public const string vmssFlexibleOrchestrationModeNetworkAPIVersionMinimum = "2020-11-01";

        public override void ExecuteCmdlet()
        {
            if (this.IsParameterBound(c => c.UserData))
            {
                if (!ValidateBase64EncodedString.ValidateStringIsBase64Encoded(this.UserData))
                {
                    this.UserData = ValidateBase64EncodedString.EncodeStringToBase64(this.UserData);
                    this.WriteInformation(ValidateBase64EncodedString.UserDataEncodeNotification, new string[] { "PSHOST" });
                }
            }

            base.ExecuteCmdlet();
            switch (ParameterSetName)
            {
                case SimpleParameterSet:
                    this.StartAndWait(SimpleParameterSetExecuteCmdlet);
                    break;
                default:
                    ExecuteClientAction(() =>
                    {
                        if (ShouldProcess(this.VMScaleSetName, VerbsCommon.New))
                        {
                            string resourceGroupName = this.ResourceGroupName;
                            string vmScaleSetName = this.VMScaleSetName;
                            VirtualMachineScaleSet parameters = new VirtualMachineScaleSet();
                            ComputeAutomationAutoMapperProfile.Mapper.Map<PSVirtualMachineScaleSet, VirtualMachineScaleSet>(this.VirtualMachineScaleSet, parameters);
                            if (parameters?.VirtualMachineProfile?.StorageProfile?.ImageReference?.Version?.ToLower() != "latest")
                            {
                                WriteWarning("You are deploying VMSS pinned to a specific image version from Azure Marketplace. \n" +
                                    "Consider using \"latest\" as the image version. This allows VMSS to auto upgrade when a newer version is available.");
                            }

                            if (parameters?.OrchestrationMode == "Flexible")
                            {
                                if (parameters?.VirtualMachineProfile?.NetworkProfile?.NetworkInterfaceConfigurations != null)
                                {
                                    foreach (var nicConfig in parameters.VirtualMachineProfile.NetworkProfile.NetworkInterfaceConfigurations)
                                    {
                                        if (nicConfig.IpConfigurations != null)
                                        {
                                            foreach (var ipConfig in nicConfig.IpConfigurations)
                                            {
                                                ipConfig.LoadBalancerInboundNatPools = null;
                                            }
                                        }
                                    }
                                }

                                parameters.UpgradePolicy = null;

                                flexibleOrchestrationModeDefaultParameters(parameters);
                                checkFlexibleOrchestrationModeParamsDefaultParamSet(parameters);
                            }

                            // For Cross-tenant RBAC sharing
                            Dictionary<string, List<string>> auxAuthHeader = null;
                            if (!string.IsNullOrEmpty(parameters.VirtualMachineProfile?.StorageProfile?.ImageReference?.Id))
                            {
                                var resourceId = ResourceId.TryParse(parameters.VirtualMachineProfile?.StorageProfile.ImageReference.Id);

                                if (string.Equals(ComputeStrategy.Namespace, resourceId?.ResourceType?.Namespace, StringComparison.OrdinalIgnoreCase)
                                 && string.Equals("galleries", resourceId?.ResourceType?.Provider, StringComparison.OrdinalIgnoreCase)
                                 && !string.Equals(this.ComputeClient?.ComputeManagementClient?.SubscriptionId, resourceId?.SubscriptionId, StringComparison.OrdinalIgnoreCase))
                                {
                                    List<string> resourceIds = new List<string>();
                                    resourceIds.Add(parameters.VirtualMachineProfile?.StorageProfile.ImageReference.Id);
                                    var auxHeaderDictionary = GetAuxilaryAuthHeaderFromResourceIds(resourceIds);
                                    if (auxHeaderDictionary != null && auxHeaderDictionary.Count > 0)
                                    {
                                        auxAuthHeader = new Dictionary<string, List<string>>(auxHeaderDictionary);
                                    }
                                }
                            }
                            // END: For Cross-tenant RBAC sharing

                            VirtualMachineScaleSet result;
                            if (auxAuthHeader != null)
                            {
                                var res = VirtualMachineScaleSetsClient.CreateOrUpdateWithHttpMessagesAsync(
                                        resourceGroupName,
                                        vmScaleSetName,
                                        parameters,
                                        auxAuthHeader).GetAwaiter().GetResult();

                                result = res.Body;
                            }
                            else
                            {
                                result = VirtualMachineScaleSetsClient.CreateOrUpdate(resourceGroupName, vmScaleSetName, parameters);
                            }
                            var psObject = new PSVirtualMachineScaleSet();
                            ComputeAutomationAutoMapperProfile.Mapper.Map<VirtualMachineScaleSet, PSVirtualMachineScaleSet>(result, psObject);
                            WriteObject(psObject);
                        }
                    });
                    break;
            }
        }

        /// This somewhat contradicts with the above behavior that sets UpgradePolicy to null.
        /// There is some concern with the above behavior being correct or not, and requires additional testing before changing.
        private void checkFlexibleOrchestrationModeParamsDefaultParamSet(VirtualMachineScaleSet parameters)
        {
            if (parameters?.UpgradePolicy != null)
            {
                throw new Exception("UpgradePolicy is not currently supported for a VMSS with OrchestrationMode set to Flexible.");
            }
            else if (parameters?.VirtualMachineProfile?.NetworkProfile?.NetworkApiVersion != null
                && convertAPIVersionToInt(parameters?.VirtualMachineProfile?.NetworkProfile?.NetworkApiVersion) < vmssFlexibleOrchestrationModeNetworkAPIVersionMinimumInt)
            {
                throw new Exception("The value for NetworkApiVersion is not valid for a VMSS with OrchestrationMode set to Flexible. You must use a valid Network API Version equal to or greater than " + vmssFlexibleOrchestrationModeNetworkAPIVersionMinimum);
            }
            //else if (convertAPIVersionToInt(parameters?.VirtualMachineProfile?.NetworkProfile?.NetworkApiVersion) < vmssFlexibleOrchestrationModeNetworkAPIVersionMinimumInt)
            //{
            //    throw new Exception("The value for NetworkApiVersion is not valid for a VMSS with OrchestrationMode set to Flexible. You must use a valid Network API Version equal to or greater than " + vmssFlexibleOrchestrationModeNetworkAPIVersionMinimum);
            //}
            else if (parameters?.SinglePlacementGroup == true)
            {
                throw new Exception("The value provided for SinglePlacementGroup cannot be used for a VMSS with OrchestrationMode set to Flexible. Please use SinglePlacementGroup 'false' instead.");
            }
        }

        private void flexibleOrchestrationModeDefaultParameters(VirtualMachineScaleSet parameters)
        {
            if (parameters?.SinglePlacementGroup == null)
            {
                parameters.SinglePlacementGroup = false;
            }
            if (parameters?.VirtualMachineProfile?.NetworkProfile != null &&
                parameters?.VirtualMachineProfile?.NetworkProfile.NetworkApiVersion == null)
            {
                parameters.VirtualMachineProfile.NetworkProfile.NetworkApiVersion = vmssFlexibleOrchestrationModeNetworkAPIVersionMinimum;
            }
            /*if (parameters?.VirtualMachineProfile?.NetworkProfile?.NetworkApiVersion == null)
            {
                parameters.VirtualMachineProfile.NetworkProfile.NetworkApiVersion = vmssFlexibleOrchestrationModeNetworkAPIVersionMinimum;
            }*/
            if (parameters?.PlatformFaultDomainCount == null)
            {
                parameters.PlatformFaultDomainCount = 1;
            }
        }

        private int convertAPIVersionToInt(string networkAPIVersion)
        {
            string networkAPIVersionString = String.Join("", networkAPIVersion.Split('-'));
            int apiversionInt = Convert.ToInt32(networkAPIVersionString);

            return apiversionInt;
        }

        [Parameter(
            ParameterSetName = "DefaultParameter",
            Position = 0,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true)]
        [Parameter(
            ParameterSetName = SimpleParameterSet,
            Mandatory = false)]
        [ResourceGroupCompleter]
        public string ResourceGroupName { get; set; }

        [Parameter(
            ParameterSetName = DefaultParameter,
            Position = 1,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true)]
        [Parameter(
            ParameterSetName = SimpleParameterSet,
            Mandatory = true)]
        [Alias("Name")]
        public string VMScaleSetName { get; set; }

        [Parameter(
            ParameterSetName = DefaultParameter,
            Position = 2,
            Mandatory = true,
            ValueFromPipeline = true)]
        public PSVirtualMachineScaleSet VirtualMachineScaleSet { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "Run cmdlet in the background")]
        public SwitchParameter AsJob { get; set; }

        [Parameter(
            Mandatory = false,
            ParameterSetName = SimpleParameterSet,
            HelpMessage = "UserData for the Vmss, which will be Base64 encoded. Customer should not pass any secrets in here.",
            ValueFromPipelineByPropertyName = true)]
        public string UserData { get; set; }
    }
}