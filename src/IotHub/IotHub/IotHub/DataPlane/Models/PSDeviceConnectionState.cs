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

namespace Microsoft.Azure.Commands.Management.IotHub.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Specifies the different connection states of a device.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PSDeviceConnectionState
    {
        /// <summary>
        /// Represents a device in the Disconnected state.
        /// </summary>
        Disconnected = 0,

        /// <summary>
        /// Represents a device in the Connected state.
        /// </summary>
        Connected = 1
    }
}
