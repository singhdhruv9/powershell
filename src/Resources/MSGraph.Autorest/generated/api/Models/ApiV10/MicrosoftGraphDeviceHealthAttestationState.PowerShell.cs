// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10
{
    using Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.PowerShell;

    /// <summary>deviceHealthAttestationState</summary>
    [System.ComponentModel.TypeConverter(typeof(MicrosoftGraphDeviceHealthAttestationStateTypeConverter))]
    public partial class MicrosoftGraphDeviceHealthAttestationState
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.MicrosoftGraphDeviceHealthAttestationState"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationState"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationState DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new MicrosoftGraphDeviceHealthAttestationState(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.MicrosoftGraphDeviceHealthAttestationState"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationState"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationState DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new MicrosoftGraphDeviceHealthAttestationState(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="MicrosoftGraphDeviceHealthAttestationState" />, deserializing the content from a
        /// json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationState FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.MicrosoftGraphDeviceHealthAttestationState"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal MicrosoftGraphDeviceHealthAttestationState(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).AttestationIdentityKey = (string) content.GetValueForProperty("AttestationIdentityKey",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).AttestationIdentityKey, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).BitLockerStatus = (string) content.GetValueForProperty("BitLockerStatus",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).BitLockerStatus, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).BootAppSecurityVersion = (string) content.GetValueForProperty("BootAppSecurityVersion",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).BootAppSecurityVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).BootDebugging = (string) content.GetValueForProperty("BootDebugging",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).BootDebugging, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).BootManagerSecurityVersion = (string) content.GetValueForProperty("BootManagerSecurityVersion",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).BootManagerSecurityVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).BootManagerVersion = (string) content.GetValueForProperty("BootManagerVersion",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).BootManagerVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).BootRevisionListInfo = (string) content.GetValueForProperty("BootRevisionListInfo",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).BootRevisionListInfo, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).CodeIntegrity = (string) content.GetValueForProperty("CodeIntegrity",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).CodeIntegrity, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).CodeIntegrityCheckVersion = (string) content.GetValueForProperty("CodeIntegrityCheckVersion",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).CodeIntegrityCheckVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).CodeIntegrityPolicy = (string) content.GetValueForProperty("CodeIntegrityPolicy",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).CodeIntegrityPolicy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).ContentNamespaceUrl = (string) content.GetValueForProperty("ContentNamespaceUrl",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).ContentNamespaceUrl, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).ContentVersion = (string) content.GetValueForProperty("ContentVersion",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).ContentVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).DataExcutionPolicy = (string) content.GetValueForProperty("DataExcutionPolicy",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).DataExcutionPolicy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).DeviceHealthAttestationStatus = (string) content.GetValueForProperty("DeviceHealthAttestationStatus",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).DeviceHealthAttestationStatus, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).EarlyLaunchAntiMalwareDriverProtection = (string) content.GetValueForProperty("EarlyLaunchAntiMalwareDriverProtection",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).EarlyLaunchAntiMalwareDriverProtection, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).HealthAttestationSupportedStatus = (string) content.GetValueForProperty("HealthAttestationSupportedStatus",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).HealthAttestationSupportedStatus, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).HealthStatusMismatchInfo = (string) content.GetValueForProperty("HealthStatusMismatchInfo",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).HealthStatusMismatchInfo, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).IssuedDateTime = (global::System.DateTime?) content.GetValueForProperty("IssuedDateTime",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).IssuedDateTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).LastUpdateDateTime = (string) content.GetValueForProperty("LastUpdateDateTime",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).LastUpdateDateTime, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).OperatingSystemKernelDebugging = (string) content.GetValueForProperty("OperatingSystemKernelDebugging",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).OperatingSystemKernelDebugging, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).OperatingSystemRevListInfo = (string) content.GetValueForProperty("OperatingSystemRevListInfo",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).OperatingSystemRevListInfo, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).Pcr0 = (string) content.GetValueForProperty("Pcr0",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).Pcr0, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).PcrHashAlgorithm = (string) content.GetValueForProperty("PcrHashAlgorithm",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).PcrHashAlgorithm, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).ResetCount = (long?) content.GetValueForProperty("ResetCount",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).ResetCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).RestartCount = (long?) content.GetValueForProperty("RestartCount",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).RestartCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).SafeMode = (string) content.GetValueForProperty("SafeMode",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).SafeMode, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).SecureBoot = (string) content.GetValueForProperty("SecureBoot",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).SecureBoot, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).SecureBootConfigurationPolicyFingerPrint = (string) content.GetValueForProperty("SecureBootConfigurationPolicyFingerPrint",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).SecureBootConfigurationPolicyFingerPrint, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).TestSigning = (string) content.GetValueForProperty("TestSigning",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).TestSigning, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).TpmVersion = (string) content.GetValueForProperty("TpmVersion",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).TpmVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).VirtualSecureMode = (string) content.GetValueForProperty("VirtualSecureMode",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).VirtualSecureMode, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).WindowsPe = (string) content.GetValueForProperty("WindowsPe",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).WindowsPe, global::System.Convert.ToString);
            // this type is a dictionary; copy elements from source to here.
            CopyFrom(content);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.MicrosoftGraphDeviceHealthAttestationState"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal MicrosoftGraphDeviceHealthAttestationState(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).AttestationIdentityKey = (string) content.GetValueForProperty("AttestationIdentityKey",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).AttestationIdentityKey, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).BitLockerStatus = (string) content.GetValueForProperty("BitLockerStatus",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).BitLockerStatus, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).BootAppSecurityVersion = (string) content.GetValueForProperty("BootAppSecurityVersion",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).BootAppSecurityVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).BootDebugging = (string) content.GetValueForProperty("BootDebugging",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).BootDebugging, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).BootManagerSecurityVersion = (string) content.GetValueForProperty("BootManagerSecurityVersion",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).BootManagerSecurityVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).BootManagerVersion = (string) content.GetValueForProperty("BootManagerVersion",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).BootManagerVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).BootRevisionListInfo = (string) content.GetValueForProperty("BootRevisionListInfo",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).BootRevisionListInfo, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).CodeIntegrity = (string) content.GetValueForProperty("CodeIntegrity",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).CodeIntegrity, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).CodeIntegrityCheckVersion = (string) content.GetValueForProperty("CodeIntegrityCheckVersion",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).CodeIntegrityCheckVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).CodeIntegrityPolicy = (string) content.GetValueForProperty("CodeIntegrityPolicy",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).CodeIntegrityPolicy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).ContentNamespaceUrl = (string) content.GetValueForProperty("ContentNamespaceUrl",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).ContentNamespaceUrl, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).ContentVersion = (string) content.GetValueForProperty("ContentVersion",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).ContentVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).DataExcutionPolicy = (string) content.GetValueForProperty("DataExcutionPolicy",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).DataExcutionPolicy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).DeviceHealthAttestationStatus = (string) content.GetValueForProperty("DeviceHealthAttestationStatus",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).DeviceHealthAttestationStatus, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).EarlyLaunchAntiMalwareDriverProtection = (string) content.GetValueForProperty("EarlyLaunchAntiMalwareDriverProtection",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).EarlyLaunchAntiMalwareDriverProtection, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).HealthAttestationSupportedStatus = (string) content.GetValueForProperty("HealthAttestationSupportedStatus",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).HealthAttestationSupportedStatus, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).HealthStatusMismatchInfo = (string) content.GetValueForProperty("HealthStatusMismatchInfo",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).HealthStatusMismatchInfo, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).IssuedDateTime = (global::System.DateTime?) content.GetValueForProperty("IssuedDateTime",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).IssuedDateTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).LastUpdateDateTime = (string) content.GetValueForProperty("LastUpdateDateTime",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).LastUpdateDateTime, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).OperatingSystemKernelDebugging = (string) content.GetValueForProperty("OperatingSystemKernelDebugging",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).OperatingSystemKernelDebugging, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).OperatingSystemRevListInfo = (string) content.GetValueForProperty("OperatingSystemRevListInfo",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).OperatingSystemRevListInfo, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).Pcr0 = (string) content.GetValueForProperty("Pcr0",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).Pcr0, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).PcrHashAlgorithm = (string) content.GetValueForProperty("PcrHashAlgorithm",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).PcrHashAlgorithm, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).ResetCount = (long?) content.GetValueForProperty("ResetCount",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).ResetCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).RestartCount = (long?) content.GetValueForProperty("RestartCount",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).RestartCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).SafeMode = (string) content.GetValueForProperty("SafeMode",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).SafeMode, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).SecureBoot = (string) content.GetValueForProperty("SecureBoot",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).SecureBoot, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).SecureBootConfigurationPolicyFingerPrint = (string) content.GetValueForProperty("SecureBootConfigurationPolicyFingerPrint",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).SecureBootConfigurationPolicyFingerPrint, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).TestSigning = (string) content.GetValueForProperty("TestSigning",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).TestSigning, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).TpmVersion = (string) content.GetValueForProperty("TpmVersion",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).TpmVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).VirtualSecureMode = (string) content.GetValueForProperty("VirtualSecureMode",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).VirtualSecureMode, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).WindowsPe = (string) content.GetValueForProperty("WindowsPe",((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceHealthAttestationStateInternal)this).WindowsPe, global::System.Convert.ToString);
            // this type is a dictionary; copy elements from source to here.
            CopyFrom(content);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// deviceHealthAttestationState
    [System.ComponentModel.TypeConverter(typeof(MicrosoftGraphDeviceHealthAttestationStateTypeConverter))]
    public partial interface IMicrosoftGraphDeviceHealthAttestationState

    {

    }
}