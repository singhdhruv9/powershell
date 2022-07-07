// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.PowerShell;

    /// <summary>Role management policy</summary>
    [System.ComponentModel.TypeConverter(typeof(RoleManagementPolicyAssignmentTypeConverter))]
    public partial class RoleManagementPolicyAssignment
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.RoleManagementPolicyAssignment"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignment"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignment DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new RoleManagementPolicyAssignment(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.RoleManagementPolicyAssignment"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignment"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignment DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new RoleManagementPolicyAssignment(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="RoleManagementPolicyAssignment" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="RoleManagementPolicyAssignment" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignment FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.RoleManagementPolicyAssignment"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal RoleManagementPolicyAssignment(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.RoleManagementPolicyAssignmentPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("PolicyAssignmentProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).PolicyAssignmentProperty = (Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IPolicyAssignmentProperties) content.GetValueForProperty("PolicyAssignmentProperty",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).PolicyAssignmentProperty, Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.PolicyAssignmentPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Scope"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).Scope = (string) content.GetValueForProperty("Scope",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).Scope, global::System.Convert.ToString);
            }
            if (content.Contains("RoleDefinitionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).RoleDefinitionId = (string) content.GetValueForProperty("RoleDefinitionId",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).RoleDefinitionId, global::System.Convert.ToString);
            }
            if (content.Contains("PolicyId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).PolicyId = (string) content.GetValueForProperty("PolicyId",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).PolicyId, global::System.Convert.ToString);
            }
            if (content.Contains("PolicyAssignmentPropertyScope"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).PolicyAssignmentPropertyScope = (Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IPolicyAssignmentPropertiesScope) content.GetValueForProperty("PolicyAssignmentPropertyScope",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).PolicyAssignmentPropertyScope, Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.PolicyAssignmentPropertiesScopeTypeConverter.ConvertFrom);
            }
            if (content.Contains("PolicyAssignmentPropertyRoleDefinition"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).PolicyAssignmentPropertyRoleDefinition = (Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IPolicyAssignmentPropertiesRoleDefinition) content.GetValueForProperty("PolicyAssignmentPropertyRoleDefinition",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).PolicyAssignmentPropertyRoleDefinition, Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.PolicyAssignmentPropertiesRoleDefinitionTypeConverter.ConvertFrom);
            }
            if (content.Contains("PolicyAssignmentPropertyPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).PolicyAssignmentPropertyPolicy = (Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IPolicyAssignmentPropertiesPolicy) content.GetValueForProperty("PolicyAssignmentPropertyPolicy",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).PolicyAssignmentPropertyPolicy, Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.PolicyAssignmentPropertiesPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("ScopeId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).ScopeId = (string) content.GetValueForProperty("ScopeId",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).ScopeId, global::System.Convert.ToString);
            }
            if (content.Contains("ScopeDisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).ScopeDisplayName = (string) content.GetValueForProperty("ScopeDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).ScopeDisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("ScopeType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).ScopeType = (string) content.GetValueForProperty("ScopeType",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).ScopeType, global::System.Convert.ToString);
            }
            if (content.Contains("PolicyAssignmentPropertiesRoleDefinitionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).PolicyAssignmentPropertiesRoleDefinitionId = (string) content.GetValueForProperty("PolicyAssignmentPropertiesRoleDefinitionId",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).PolicyAssignmentPropertiesRoleDefinitionId, global::System.Convert.ToString);
            }
            if (content.Contains("RoleDefinitionDisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).RoleDefinitionDisplayName = (string) content.GetValueForProperty("RoleDefinitionDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).RoleDefinitionDisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("RoleDefinitionType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).RoleDefinitionType = (string) content.GetValueForProperty("RoleDefinitionType",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).RoleDefinitionType, global::System.Convert.ToString);
            }
            if (content.Contains("PolicyAssignmentPropertiesPolicyId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).PolicyAssignmentPropertiesPolicyId = (string) content.GetValueForProperty("PolicyAssignmentPropertiesPolicyId",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).PolicyAssignmentPropertiesPolicyId, global::System.Convert.ToString);
            }
            if (content.Contains("PolicyLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).PolicyLastModifiedBy = (Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IPrincipal) content.GetValueForProperty("PolicyLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).PolicyLastModifiedBy, Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.PrincipalTypeConverter.ConvertFrom);
            }
            if (content.Contains("PolicyLastModifiedDateTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).PolicyLastModifiedDateTime = (global::System.DateTime?) content.GetValueForProperty("PolicyLastModifiedDateTime",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).PolicyLastModifiedDateTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastModifiedById"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).LastModifiedById = (string) content.GetValueForProperty("LastModifiedById",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).LastModifiedById, global::System.Convert.ToString);
            }
            if (content.Contains("LastModifiedByDisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).LastModifiedByDisplayName = (string) content.GetValueForProperty("LastModifiedByDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).LastModifiedByDisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("LastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).LastModifiedByType = (string) content.GetValueForProperty("LastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).LastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("LastModifiedByEmail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).LastModifiedByEmail = (string) content.GetValueForProperty("LastModifiedByEmail",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).LastModifiedByEmail, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.RoleManagementPolicyAssignment"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal RoleManagementPolicyAssignment(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.RoleManagementPolicyAssignmentPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("PolicyAssignmentProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).PolicyAssignmentProperty = (Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IPolicyAssignmentProperties) content.GetValueForProperty("PolicyAssignmentProperty",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).PolicyAssignmentProperty, Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.PolicyAssignmentPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Scope"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).Scope = (string) content.GetValueForProperty("Scope",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).Scope, global::System.Convert.ToString);
            }
            if (content.Contains("RoleDefinitionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).RoleDefinitionId = (string) content.GetValueForProperty("RoleDefinitionId",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).RoleDefinitionId, global::System.Convert.ToString);
            }
            if (content.Contains("PolicyId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).PolicyId = (string) content.GetValueForProperty("PolicyId",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).PolicyId, global::System.Convert.ToString);
            }
            if (content.Contains("PolicyAssignmentPropertyScope"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).PolicyAssignmentPropertyScope = (Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IPolicyAssignmentPropertiesScope) content.GetValueForProperty("PolicyAssignmentPropertyScope",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).PolicyAssignmentPropertyScope, Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.PolicyAssignmentPropertiesScopeTypeConverter.ConvertFrom);
            }
            if (content.Contains("PolicyAssignmentPropertyRoleDefinition"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).PolicyAssignmentPropertyRoleDefinition = (Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IPolicyAssignmentPropertiesRoleDefinition) content.GetValueForProperty("PolicyAssignmentPropertyRoleDefinition",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).PolicyAssignmentPropertyRoleDefinition, Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.PolicyAssignmentPropertiesRoleDefinitionTypeConverter.ConvertFrom);
            }
            if (content.Contains("PolicyAssignmentPropertyPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).PolicyAssignmentPropertyPolicy = (Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IPolicyAssignmentPropertiesPolicy) content.GetValueForProperty("PolicyAssignmentPropertyPolicy",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).PolicyAssignmentPropertyPolicy, Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.PolicyAssignmentPropertiesPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("ScopeId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).ScopeId = (string) content.GetValueForProperty("ScopeId",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).ScopeId, global::System.Convert.ToString);
            }
            if (content.Contains("ScopeDisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).ScopeDisplayName = (string) content.GetValueForProperty("ScopeDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).ScopeDisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("ScopeType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).ScopeType = (string) content.GetValueForProperty("ScopeType",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).ScopeType, global::System.Convert.ToString);
            }
            if (content.Contains("PolicyAssignmentPropertiesRoleDefinitionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).PolicyAssignmentPropertiesRoleDefinitionId = (string) content.GetValueForProperty("PolicyAssignmentPropertiesRoleDefinitionId",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).PolicyAssignmentPropertiesRoleDefinitionId, global::System.Convert.ToString);
            }
            if (content.Contains("RoleDefinitionDisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).RoleDefinitionDisplayName = (string) content.GetValueForProperty("RoleDefinitionDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).RoleDefinitionDisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("RoleDefinitionType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).RoleDefinitionType = (string) content.GetValueForProperty("RoleDefinitionType",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).RoleDefinitionType, global::System.Convert.ToString);
            }
            if (content.Contains("PolicyAssignmentPropertiesPolicyId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).PolicyAssignmentPropertiesPolicyId = (string) content.GetValueForProperty("PolicyAssignmentPropertiesPolicyId",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).PolicyAssignmentPropertiesPolicyId, global::System.Convert.ToString);
            }
            if (content.Contains("PolicyLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).PolicyLastModifiedBy = (Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IPrincipal) content.GetValueForProperty("PolicyLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).PolicyLastModifiedBy, Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.PrincipalTypeConverter.ConvertFrom);
            }
            if (content.Contains("PolicyLastModifiedDateTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).PolicyLastModifiedDateTime = (global::System.DateTime?) content.GetValueForProperty("PolicyLastModifiedDateTime",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).PolicyLastModifiedDateTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastModifiedById"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).LastModifiedById = (string) content.GetValueForProperty("LastModifiedById",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).LastModifiedById, global::System.Convert.ToString);
            }
            if (content.Contains("LastModifiedByDisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).LastModifiedByDisplayName = (string) content.GetValueForProperty("LastModifiedByDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).LastModifiedByDisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("LastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).LastModifiedByType = (string) content.GetValueForProperty("LastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).LastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("LastModifiedByEmail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).LastModifiedByEmail = (string) content.GetValueForProperty("LastModifiedByEmail",((Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicyAssignmentInternal)this).LastModifiedByEmail, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Role management policy
    [System.ComponentModel.TypeConverter(typeof(RoleManagementPolicyAssignmentTypeConverter))]
    public partial interface IRoleManagementPolicyAssignment

    {

    }
}