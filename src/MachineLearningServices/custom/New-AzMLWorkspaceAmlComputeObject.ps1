
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Create an in-memory object for AmlCompute.
.Description
Create an in-memory object for AmlCompute.

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.MachineLearningWorkspaces.Models.Api20220501.AmlCompute
.Link
https://docs.microsoft.com/powershell/module/az.MLWorkspace/new-AzMLWorkspaceAmlComputeObject
#>
function New-AzMLWorkspaceAmlComputeObject {
    [OutputType('Microsoft.Azure.PowerShell.Cmdlets.MachineLearningWorkspaces.Models.Api20220501.AmlCompute')]
    [CmdletBinding(PositionalBinding=$false)]
    Param(

        [Parameter(HelpMessage="The description of the Machine Learning compute.")]
        [string]
        $Description,
        [Parameter(HelpMessage="Opt-out of local authentication and ensure customers can use only MSI and AAD exclusively for authentication.")]
        [bool]
        $DisableLocalAuth,
        [Parameter(HelpMessage="ARM resource id of the underlying compute.")]
        [string]
        $ResourceId,
        [Parameter(HelpMessage="Enable or disable node public IP address provisioning. Possible values are: Possible values are: true - Indicates that the compute nodes will have public IPs provisioned. false - Indicates that the compute nodes will have a private endpoint and no public IPs.")]
        [bool]
        $EnableNodePublicIP,
        [Parameter(HelpMessage="Network is isolated or not.")]
        [bool]
        $IsolatedNetwork,
        [Parameter(HelpMessage="Compute OS Type.")]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.MachineLearningWorkspaces.Support.OSType])]
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningWorkspaces.Support.OSType]
        $OSType,
        [Parameter(HelpMessage="A property bag containing additional properties.")]
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningWorkspaces.Models.IAny]
        $PropertyBag,
        [Parameter(HelpMessage="State of the public SSH port. Possible values are: Disabled - Indicates that the public ssh port is closed on all nodes of the cluster. Enabled - Indicates that the public ssh port is open on all nodes of the cluster. NotSpecified - Indicates that the public ssh port is closed on all nodes of the cluster if VNet is defined, else is open all public nodes. It can be default only during cluster creation time, after creation it will be either enabled or disabled.")]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.MachineLearningWorkspaces.Support.RemoteLoginPortPublicAccess])]
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningWorkspaces.Support.RemoteLoginPortPublicAccess]
        $RemoteLoginPortPublicAccess,
        [Parameter(HelpMessage="Max number of nodes to use.")]
        [int]
        $ScaleMaxNodeCount,
        [Parameter(HelpMessage="Min number of nodes to use.")]
        [int]
        $ScaleMinNodeCount,
        [Parameter(HelpMessage="Node Idle Time before scaling down amlCompute. This string needs to be in the RFC Format.")]
        [System.TimeSpan]
        $ScaleNodeIdleTimeBeforeScaleDown,
        [Parameter(HelpMessage="The ID of the resource.")]
        [string]
        $SubnetId,
        [Parameter(HelpMessage="Name of the administrator user account which can be used to SSH to nodes.")]
        [string]
        $AdminUserName,
        [Parameter(HelpMessage="Password of the administrator user account.")]
        [string]
        $AdminUserPassword,
        [Parameter(HelpMessage="SSH public key of the administrator user account.")]
        [string]
        $AdminUserSshPublicKey,
        [Parameter(HelpMessage="Virtual Machine priority.")]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.MachineLearningWorkspaces.Support.VMPriority])]
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningWorkspaces.Support.VMPriority]
        $VMPriority,
        [Parameter(HelpMessage="Virtual Machine Size.")]
        [string]
        $VMSize,
        [Parameter(HelpMessage="Virtual Machine image path.")]
        [string]
        $VirtualMachineImageId
    )

    process {
        $Object = [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningWorkspaces.Models.Api20220501.AmlCompute]::New()
        $Object.Type = 'AmlCompute'

        if ($PSBoundParameters.ContainsKey('Description')) {
            $Object.Description = $Description
        }
        if ($PSBoundParameters.ContainsKey('DisableLocalAuth')) {
            $Object.DisableLocalAuth = $DisableLocalAuth
        }
        if ($PSBoundParameters.ContainsKey('ResourceId')) {
            $Object.ResourceId = $ResourceId
        }
        if ($PSBoundParameters.ContainsKey('EnableNodePublicIP')) {
            $Object.EnableNodePublicIP = $EnableNodePublicIP
        }
        if ($PSBoundParameters.ContainsKey('IsolatedNetwork')) {
            $Object.IsolatedNetwork = $IsolatedNetwork
        }
        if ($PSBoundParameters.ContainsKey('OSType')) {
            $Object.OSType = $OSType
        }
        if ($PSBoundParameters.ContainsKey('PropertyBag')) {
            $Object.PropertyBag = $PropertyBag
        }
        if ($PSBoundParameters.ContainsKey('RemoteLoginPortPublicAccess')) {
            $Object.RemoteLoginPortPublicAccess = $RemoteLoginPortPublicAccess
        }
        if ($PSBoundParameters.ContainsKey('ScaleMaxNodeCount')) {
            $Object.ScaleSettingMaxNodeCount = $ScaleMaxNodeCount
        }
        if ($PSBoundParameters.ContainsKey('ScaleMinNodeCount')) {
            $Object.ScaleSettingMinNodeCount = $ScaleMinNodeCount
        }
        if ($PSBoundParameters.ContainsKey('ScaleNodeIdleTimeBeforeScaleDown')) {
            $Object.ScaleSettingNodeIdleTimeBeforeScaleDown = $ScaleNodeIdleTimeBeforeScaleDown
        }
        if ($PSBoundParameters.ContainsKey('SubnetId')) {
            $Object.SubnetId = $SubnetId
        }
        if ($PSBoundParameters.ContainsKey('AdminUserName')) {
            $Object.UserAccountCredentialsAdminUserName = $AdminUserName
        }
        if ($PSBoundParameters.ContainsKey('AdminUserPassword')) {
            $Object.UserAccountCredentialsAdminUserPassword = $AdminUserPassword
        }
        if ($PSBoundParameters.ContainsKey('AdminUserSshPublicKey')) {
            $Object.UserAccountCredentialsAdminUserSshPublicKey = $AdminUserSshPublicKey
        }
        if ($PSBoundParameters.ContainsKey('VMPriority')) {
            $Object.VMPriority = $VMPriority
        }
        if ($PSBoundParameters.ContainsKey('VMSize')) {
            $Object.VMSize = $VMSize
        }
        if ($PSBoundParameters.ContainsKey('VirtualMachineImageId')) {
            $Object.VirtualMachineImageId = $VirtualMachineImageId
        }
        return $Object
    }
}

