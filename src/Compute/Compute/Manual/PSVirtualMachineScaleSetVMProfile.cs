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

using Microsoft.Azure.Management.Compute.Models;

namespace Microsoft.Azure.Commands.Compute.Automation.Models
{
    public class PSVirtualMachineScaleSetVMProfile
    {
        public VirtualMachineScaleSetOSProfile OsProfile { get; set; }
        public VirtualMachineScaleSetStorageProfile StorageProfile { get; set; }
        public VirtualMachineScaleSetNetworkProfile NetworkProfile { get; set; }
        public DiagnosticsProfile DiagnosticsProfile { get; set; }
        public SecurityProfile SecurityProfile { get; set; }
        public PSVirtualMachineScaleSetExtensionProfile ExtensionProfile { get; set; } // To hide a breaking change
        public string LicenseType { get; set; }
        public string Priority { get; set; }
        public string EvictionPolicy { get; set; }
        public BillingProfile BillingProfile { get; set; }
        public ScheduledEventsProfile ScheduledEventsProfile { get; set; }
        public CapacityReservationProfile CapacityReservation { get; set; }
        public string UserData { get; set; }
        public PSApplicationProfile ApplicationProfile { get; set; }

        public VirtualMachineScaleSetHardwareProfile HardwareProfile { get; set; }
    }
}
