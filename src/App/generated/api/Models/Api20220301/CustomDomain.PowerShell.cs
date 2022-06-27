// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301
{
    using Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.PowerShell;

    /// <summary>Custom Domain of a Container App</summary>
    [System.ComponentModel.TypeConverter(typeof(CustomDomainTypeConverter))]
    public partial class CustomDomain
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.CustomDomain"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal CustomDomain(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomDomainInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomDomainInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("BindingType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomDomainInternal)this).BindingType = (Microsoft.Azure.PowerShell.Cmdlets.App.Support.BindingType?) content.GetValueForProperty("BindingType",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomDomainInternal)this).BindingType, Microsoft.Azure.PowerShell.Cmdlets.App.Support.BindingType.CreateFrom);
            }
            if (content.Contains("CertificateId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomDomainInternal)this).CertificateId = (string) content.GetValueForProperty("CertificateId",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomDomainInternal)this).CertificateId, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.CustomDomain"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal CustomDomain(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomDomainInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomDomainInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("BindingType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomDomainInternal)this).BindingType = (Microsoft.Azure.PowerShell.Cmdlets.App.Support.BindingType?) content.GetValueForProperty("BindingType",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomDomainInternal)this).BindingType, Microsoft.Azure.PowerShell.Cmdlets.App.Support.BindingType.CreateFrom);
            }
            if (content.Contains("CertificateId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomDomainInternal)this).CertificateId = (string) content.GetValueForProperty("CertificateId",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomDomainInternal)this).CertificateId, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.CustomDomain"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomDomain" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomDomain DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new CustomDomain(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.CustomDomain"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomDomain" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomDomain DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new CustomDomain(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="CustomDomain" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="CustomDomain" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomDomain FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Custom Domain of a Container App
    [System.ComponentModel.TypeConverter(typeof(CustomDomainTypeConverter))]
    public partial interface ICustomDomain

    {

    }
}