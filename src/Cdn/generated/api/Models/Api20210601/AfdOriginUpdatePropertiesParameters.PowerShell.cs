// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601
{
    using Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.PowerShell;

    /// <summary>The JSON object that contains the properties of the origin.</summary>
    [System.ComponentModel.TypeConverter(typeof(AfdOriginUpdatePropertiesParametersTypeConverter))]
    public partial class AfdOriginUpdatePropertiesParameters
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
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.AfdOriginUpdatePropertiesParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal AfdOriginUpdatePropertiesParameters(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("AzureOrigin"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).AzureOrigin = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceReference) content.GetValueForProperty("AzureOrigin",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).AzureOrigin, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ResourceReferenceTypeConverter.ConvertFrom);
            }
            if (content.Contains("SharedPrivateLinkResource"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).SharedPrivateLinkResource = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ISharedPrivateLinkResourceProperties) content.GetValueForProperty("SharedPrivateLinkResource",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).SharedPrivateLinkResource, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.SharedPrivateLinkResourcePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("OriginGroupName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).OriginGroupName = (string) content.GetValueForProperty("OriginGroupName",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).OriginGroupName, global::System.Convert.ToString);
            }
            if (content.Contains("HostName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).HostName = (string) content.GetValueForProperty("HostName",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).HostName, global::System.Convert.ToString);
            }
            if (content.Contains("HttpPort"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).HttpPort = (int?) content.GetValueForProperty("HttpPort",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).HttpPort, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("HttpsPort"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).HttpsPort = (int?) content.GetValueForProperty("HttpsPort",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).HttpsPort, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("OriginHostHeader"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).OriginHostHeader = (string) content.GetValueForProperty("OriginHostHeader",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).OriginHostHeader, global::System.Convert.ToString);
            }
            if (content.Contains("Priority"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).Priority = (int?) content.GetValueForProperty("Priority",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).Priority, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("Weight"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).Weight = (int?) content.GetValueForProperty("Weight",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).Weight, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("EnabledState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).EnabledState = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.EnabledState?) content.GetValueForProperty("EnabledState",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).EnabledState, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.EnabledState.CreateFrom);
            }
            if (content.Contains("EnforceCertificateNameCheck"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).EnforceCertificateNameCheck = (bool?) content.GetValueForProperty("EnforceCertificateNameCheck",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).EnforceCertificateNameCheck, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("SharedPrivateLinkResourceStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).SharedPrivateLinkResourceStatus = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.SharedPrivateLinkResourceStatus?) content.GetValueForProperty("SharedPrivateLinkResourceStatus",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).SharedPrivateLinkResourceStatus, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.SharedPrivateLinkResourceStatus.CreateFrom);
            }
            if (content.Contains("AzureOriginId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).AzureOriginId = (string) content.GetValueForProperty("AzureOriginId",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).AzureOriginId, global::System.Convert.ToString);
            }
            if (content.Contains("SharedPrivateLinkResourcePrivateLink"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).SharedPrivateLinkResourcePrivateLink = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceReference) content.GetValueForProperty("SharedPrivateLinkResourcePrivateLink",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).SharedPrivateLinkResourcePrivateLink, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ResourceReferenceTypeConverter.ConvertFrom);
            }
            if (content.Contains("SharedPrivateLinkResourcePrivateLinkLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).SharedPrivateLinkResourcePrivateLinkLocation = (string) content.GetValueForProperty("SharedPrivateLinkResourcePrivateLinkLocation",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).SharedPrivateLinkResourcePrivateLinkLocation, global::System.Convert.ToString);
            }
            if (content.Contains("SharedPrivateLinkResourceGroupId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).SharedPrivateLinkResourceGroupId = (string) content.GetValueForProperty("SharedPrivateLinkResourceGroupId",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).SharedPrivateLinkResourceGroupId, global::System.Convert.ToString);
            }
            if (content.Contains("SharedPrivateLinkResourceRequestMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).SharedPrivateLinkResourceRequestMessage = (string) content.GetValueForProperty("SharedPrivateLinkResourceRequestMessage",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).SharedPrivateLinkResourceRequestMessage, global::System.Convert.ToString);
            }
            if (content.Contains("PrivateLinkId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).PrivateLinkId = (string) content.GetValueForProperty("PrivateLinkId",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).PrivateLinkId, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.AfdOriginUpdatePropertiesParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal AfdOriginUpdatePropertiesParameters(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("AzureOrigin"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).AzureOrigin = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceReference) content.GetValueForProperty("AzureOrigin",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).AzureOrigin, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ResourceReferenceTypeConverter.ConvertFrom);
            }
            if (content.Contains("SharedPrivateLinkResource"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).SharedPrivateLinkResource = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ISharedPrivateLinkResourceProperties) content.GetValueForProperty("SharedPrivateLinkResource",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).SharedPrivateLinkResource, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.SharedPrivateLinkResourcePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("OriginGroupName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).OriginGroupName = (string) content.GetValueForProperty("OriginGroupName",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).OriginGroupName, global::System.Convert.ToString);
            }
            if (content.Contains("HostName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).HostName = (string) content.GetValueForProperty("HostName",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).HostName, global::System.Convert.ToString);
            }
            if (content.Contains("HttpPort"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).HttpPort = (int?) content.GetValueForProperty("HttpPort",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).HttpPort, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("HttpsPort"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).HttpsPort = (int?) content.GetValueForProperty("HttpsPort",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).HttpsPort, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("OriginHostHeader"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).OriginHostHeader = (string) content.GetValueForProperty("OriginHostHeader",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).OriginHostHeader, global::System.Convert.ToString);
            }
            if (content.Contains("Priority"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).Priority = (int?) content.GetValueForProperty("Priority",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).Priority, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("Weight"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).Weight = (int?) content.GetValueForProperty("Weight",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).Weight, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("EnabledState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).EnabledState = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.EnabledState?) content.GetValueForProperty("EnabledState",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).EnabledState, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.EnabledState.CreateFrom);
            }
            if (content.Contains("EnforceCertificateNameCheck"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).EnforceCertificateNameCheck = (bool?) content.GetValueForProperty("EnforceCertificateNameCheck",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).EnforceCertificateNameCheck, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("SharedPrivateLinkResourceStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).SharedPrivateLinkResourceStatus = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.SharedPrivateLinkResourceStatus?) content.GetValueForProperty("SharedPrivateLinkResourceStatus",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).SharedPrivateLinkResourceStatus, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.SharedPrivateLinkResourceStatus.CreateFrom);
            }
            if (content.Contains("AzureOriginId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).AzureOriginId = (string) content.GetValueForProperty("AzureOriginId",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).AzureOriginId, global::System.Convert.ToString);
            }
            if (content.Contains("SharedPrivateLinkResourcePrivateLink"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).SharedPrivateLinkResourcePrivateLink = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceReference) content.GetValueForProperty("SharedPrivateLinkResourcePrivateLink",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).SharedPrivateLinkResourcePrivateLink, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ResourceReferenceTypeConverter.ConvertFrom);
            }
            if (content.Contains("SharedPrivateLinkResourcePrivateLinkLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).SharedPrivateLinkResourcePrivateLinkLocation = (string) content.GetValueForProperty("SharedPrivateLinkResourcePrivateLinkLocation",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).SharedPrivateLinkResourcePrivateLinkLocation, global::System.Convert.ToString);
            }
            if (content.Contains("SharedPrivateLinkResourceGroupId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).SharedPrivateLinkResourceGroupId = (string) content.GetValueForProperty("SharedPrivateLinkResourceGroupId",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).SharedPrivateLinkResourceGroupId, global::System.Convert.ToString);
            }
            if (content.Contains("SharedPrivateLinkResourceRequestMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).SharedPrivateLinkResourceRequestMessage = (string) content.GetValueForProperty("SharedPrivateLinkResourceRequestMessage",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).SharedPrivateLinkResourceRequestMessage, global::System.Convert.ToString);
            }
            if (content.Contains("PrivateLinkId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).PrivateLinkId = (string) content.GetValueForProperty("PrivateLinkId",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParametersInternal)this).PrivateLinkId, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.AfdOriginUpdatePropertiesParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParameters"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParameters DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new AfdOriginUpdatePropertiesParameters(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.AfdOriginUpdatePropertiesParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParameters"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParameters DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new AfdOriginUpdatePropertiesParameters(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AfdOriginUpdatePropertiesParameters" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="AfdOriginUpdatePropertiesParameters" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAfdOriginUpdatePropertiesParameters FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// The JSON object that contains the properties of the origin.
    [System.ComponentModel.TypeConverter(typeof(AfdOriginUpdatePropertiesParametersTypeConverter))]
    public partial interface IAfdOriginUpdatePropertiesParameters

    {

    }
}