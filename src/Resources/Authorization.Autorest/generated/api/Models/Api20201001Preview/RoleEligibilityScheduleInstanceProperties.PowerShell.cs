// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.PowerShell;

    /// <summary>Role eligibility schedule properties with scope.</summary>
    [System.ComponentModel.TypeConverter(typeof(RoleEligibilityScheduleInstancePropertiesTypeConverter))]
    public partial class RoleEligibilityScheduleInstanceProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.RoleEligibilityScheduleInstanceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstanceProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstanceProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new RoleEligibilityScheduleInstanceProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.RoleEligibilityScheduleInstanceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstanceProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstanceProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new RoleEligibilityScheduleInstanceProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="RoleEligibilityScheduleInstanceProperties" />, deserializing the content from a json
        /// string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="RoleEligibilityScheduleInstanceProperties" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstanceProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.RoleEligibilityScheduleInstanceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal RoleEligibilityScheduleInstanceProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ExpandedProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).ExpandedProperty = (Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IExpandedProperties) content.GetValueForProperty("ExpandedProperty",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).ExpandedProperty, Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.ExpandedPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Scope"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).Scope = (string) content.GetValueForProperty("Scope",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).Scope, global::System.Convert.ToString);
            }
            if (content.Contains("RoleDefinitionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).RoleDefinitionId = (string) content.GetValueForProperty("RoleDefinitionId",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).RoleDefinitionId, global::System.Convert.ToString);
            }
            if (content.Contains("PrincipalId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).PrincipalId = (string) content.GetValueForProperty("PrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).PrincipalId, global::System.Convert.ToString);
            }
            if (content.Contains("PrincipalType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).PrincipalType = (Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.PrincipalType?) content.GetValueForProperty("PrincipalType",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).PrincipalType, Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.PrincipalType.CreateFrom);
            }
            if (content.Contains("RoleEligibilityScheduleId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).RoleEligibilityScheduleId = (string) content.GetValueForProperty("RoleEligibilityScheduleId",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).RoleEligibilityScheduleId, global::System.Convert.ToString);
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.Status?) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.Status.CreateFrom);
            }
            if (content.Contains("StartDateTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).StartDateTime = (global::System.DateTime?) content.GetValueForProperty("StartDateTime",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).StartDateTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("EndDateTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).EndDateTime = (global::System.DateTime?) content.GetValueForProperty("EndDateTime",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).EndDateTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("MemberType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).MemberType = (Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.MemberType?) content.GetValueForProperty("MemberType",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).MemberType, Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.MemberType.CreateFrom);
            }
            if (content.Contains("Condition"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).Condition = (string) content.GetValueForProperty("Condition",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).Condition, global::System.Convert.ToString);
            }
            if (content.Contains("ConditionVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).ConditionVersion = (string) content.GetValueForProperty("ConditionVersion",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).ConditionVersion, global::System.Convert.ToString);
            }
            if (content.Contains("CreatedOn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).CreatedOn = (global::System.DateTime?) content.GetValueForProperty("CreatedOn",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).CreatedOn, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ExpandedPropertyScope"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).ExpandedPropertyScope = (Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IExpandedPropertiesScope) content.GetValueForProperty("ExpandedPropertyScope",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).ExpandedPropertyScope, Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.ExpandedPropertiesScopeTypeConverter.ConvertFrom);
            }
            if (content.Contains("ExpandedPropertyRoleDefinition"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).ExpandedPropertyRoleDefinition = (Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IExpandedPropertiesRoleDefinition) content.GetValueForProperty("ExpandedPropertyRoleDefinition",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).ExpandedPropertyRoleDefinition, Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.ExpandedPropertiesRoleDefinitionTypeConverter.ConvertFrom);
            }
            if (content.Contains("ExpandedPropertyPrincipal"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).ExpandedPropertyPrincipal = (Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IExpandedPropertiesPrincipal) content.GetValueForProperty("ExpandedPropertyPrincipal",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).ExpandedPropertyPrincipal, Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.ExpandedPropertiesPrincipalTypeConverter.ConvertFrom);
            }
            if (content.Contains("ScopeId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).ScopeId = (string) content.GetValueForProperty("ScopeId",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).ScopeId, global::System.Convert.ToString);
            }
            if (content.Contains("ScopeDisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).ScopeDisplayName = (string) content.GetValueForProperty("ScopeDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).ScopeDisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("ScopeType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).ScopeType = (string) content.GetValueForProperty("ScopeType",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).ScopeType, global::System.Convert.ToString);
            }
            if (content.Contains("ExpandedPropertiesRoleDefinitionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).ExpandedPropertiesRoleDefinitionId = (string) content.GetValueForProperty("ExpandedPropertiesRoleDefinitionId",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).ExpandedPropertiesRoleDefinitionId, global::System.Convert.ToString);
            }
            if (content.Contains("RoleDefinitionDisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).RoleDefinitionDisplayName = (string) content.GetValueForProperty("RoleDefinitionDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).RoleDefinitionDisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("RoleDefinitionType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).RoleDefinitionType = (string) content.GetValueForProperty("RoleDefinitionType",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).RoleDefinitionType, global::System.Convert.ToString);
            }
            if (content.Contains("ExpandedPropertiesPrincipalId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).ExpandedPropertiesPrincipalId = (string) content.GetValueForProperty("ExpandedPropertiesPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).ExpandedPropertiesPrincipalId, global::System.Convert.ToString);
            }
            if (content.Contains("PrincipalDisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).PrincipalDisplayName = (string) content.GetValueForProperty("PrincipalDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).PrincipalDisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("PrincipalEmail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).PrincipalEmail = (string) content.GetValueForProperty("PrincipalEmail",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).PrincipalEmail, global::System.Convert.ToString);
            }
            if (content.Contains("ExpandedPropertiesPrincipalType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).ExpandedPropertiesPrincipalType = (string) content.GetValueForProperty("ExpandedPropertiesPrincipalType",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).ExpandedPropertiesPrincipalType, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.RoleEligibilityScheduleInstanceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal RoleEligibilityScheduleInstanceProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ExpandedProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).ExpandedProperty = (Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IExpandedProperties) content.GetValueForProperty("ExpandedProperty",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).ExpandedProperty, Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.ExpandedPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Scope"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).Scope = (string) content.GetValueForProperty("Scope",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).Scope, global::System.Convert.ToString);
            }
            if (content.Contains("RoleDefinitionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).RoleDefinitionId = (string) content.GetValueForProperty("RoleDefinitionId",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).RoleDefinitionId, global::System.Convert.ToString);
            }
            if (content.Contains("PrincipalId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).PrincipalId = (string) content.GetValueForProperty("PrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).PrincipalId, global::System.Convert.ToString);
            }
            if (content.Contains("PrincipalType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).PrincipalType = (Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.PrincipalType?) content.GetValueForProperty("PrincipalType",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).PrincipalType, Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.PrincipalType.CreateFrom);
            }
            if (content.Contains("RoleEligibilityScheduleId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).RoleEligibilityScheduleId = (string) content.GetValueForProperty("RoleEligibilityScheduleId",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).RoleEligibilityScheduleId, global::System.Convert.ToString);
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.Status?) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.Status.CreateFrom);
            }
            if (content.Contains("StartDateTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).StartDateTime = (global::System.DateTime?) content.GetValueForProperty("StartDateTime",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).StartDateTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("EndDateTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).EndDateTime = (global::System.DateTime?) content.GetValueForProperty("EndDateTime",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).EndDateTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("MemberType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).MemberType = (Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.MemberType?) content.GetValueForProperty("MemberType",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).MemberType, Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Support.MemberType.CreateFrom);
            }
            if (content.Contains("Condition"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).Condition = (string) content.GetValueForProperty("Condition",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).Condition, global::System.Convert.ToString);
            }
            if (content.Contains("ConditionVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).ConditionVersion = (string) content.GetValueForProperty("ConditionVersion",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).ConditionVersion, global::System.Convert.ToString);
            }
            if (content.Contains("CreatedOn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).CreatedOn = (global::System.DateTime?) content.GetValueForProperty("CreatedOn",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).CreatedOn, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ExpandedPropertyScope"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).ExpandedPropertyScope = (Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IExpandedPropertiesScope) content.GetValueForProperty("ExpandedPropertyScope",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).ExpandedPropertyScope, Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.ExpandedPropertiesScopeTypeConverter.ConvertFrom);
            }
            if (content.Contains("ExpandedPropertyRoleDefinition"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).ExpandedPropertyRoleDefinition = (Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IExpandedPropertiesRoleDefinition) content.GetValueForProperty("ExpandedPropertyRoleDefinition",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).ExpandedPropertyRoleDefinition, Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.ExpandedPropertiesRoleDefinitionTypeConverter.ConvertFrom);
            }
            if (content.Contains("ExpandedPropertyPrincipal"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).ExpandedPropertyPrincipal = (Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IExpandedPropertiesPrincipal) content.GetValueForProperty("ExpandedPropertyPrincipal",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).ExpandedPropertyPrincipal, Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.ExpandedPropertiesPrincipalTypeConverter.ConvertFrom);
            }
            if (content.Contains("ScopeId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).ScopeId = (string) content.GetValueForProperty("ScopeId",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).ScopeId, global::System.Convert.ToString);
            }
            if (content.Contains("ScopeDisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).ScopeDisplayName = (string) content.GetValueForProperty("ScopeDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).ScopeDisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("ScopeType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).ScopeType = (string) content.GetValueForProperty("ScopeType",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).ScopeType, global::System.Convert.ToString);
            }
            if (content.Contains("ExpandedPropertiesRoleDefinitionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).ExpandedPropertiesRoleDefinitionId = (string) content.GetValueForProperty("ExpandedPropertiesRoleDefinitionId",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).ExpandedPropertiesRoleDefinitionId, global::System.Convert.ToString);
            }
            if (content.Contains("RoleDefinitionDisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).RoleDefinitionDisplayName = (string) content.GetValueForProperty("RoleDefinitionDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).RoleDefinitionDisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("RoleDefinitionType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).RoleDefinitionType = (string) content.GetValueForProperty("RoleDefinitionType",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).RoleDefinitionType, global::System.Convert.ToString);
            }
            if (content.Contains("ExpandedPropertiesPrincipalId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).ExpandedPropertiesPrincipalId = (string) content.GetValueForProperty("ExpandedPropertiesPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).ExpandedPropertiesPrincipalId, global::System.Convert.ToString);
            }
            if (content.Contains("PrincipalDisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).PrincipalDisplayName = (string) content.GetValueForProperty("PrincipalDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).PrincipalDisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("PrincipalEmail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).PrincipalEmail = (string) content.GetValueForProperty("PrincipalEmail",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).PrincipalEmail, global::System.Convert.ToString);
            }
            if (content.Contains("ExpandedPropertiesPrincipalType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).ExpandedPropertiesPrincipalType = (string) content.GetValueForProperty("ExpandedPropertiesPrincipalType",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleEligibilityScheduleInstancePropertiesInternal)this).ExpandedPropertiesPrincipalType, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Role eligibility schedule properties with scope.
    [System.ComponentModel.TypeConverter(typeof(RoleEligibilityScheduleInstancePropertiesTypeConverter))]
    public partial interface IRoleEligibilityScheduleInstanceProperties

    {

    }
}