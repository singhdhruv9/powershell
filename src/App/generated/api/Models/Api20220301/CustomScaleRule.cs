// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Extensions;

    /// <summary>Container App container Custom scaling rule.</summary>
    public partial class CustomScaleRule :
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomScaleRule,
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomScaleRuleInternal
    {

        /// <summary>Backing field for <see cref="Auth" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IScaleRuleAuth[] _auth;

        /// <summary>Authentication secrets for the custom scale rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IScaleRuleAuth[] Auth { get => this._auth; set => this._auth = value; }

        /// <summary>Backing field for <see cref="Metadata" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomScaleRuleMetadata _metadata;

        /// <summary>Metadata properties to describe custom scale rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomScaleRuleMetadata Metadata { get => (this._metadata = this._metadata ?? new Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.CustomScaleRuleMetadata()); set => this._metadata = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>
        /// Type of the custom scale rule
        /// eg: azure-servicebus, redis etc.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="CustomScaleRule" /> instance.</summary>
        public CustomScaleRule()
        {

        }
    }
    /// Container App container Custom scaling rule.
    public partial interface ICustomScaleRule :
        Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.IJsonSerializable
    {
        /// <summary>Authentication secrets for the custom scale rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Authentication secrets for the custom scale rule.",
        SerializedName = @"auth",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IScaleRuleAuth) })]
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IScaleRuleAuth[] Auth { get; set; }
        /// <summary>Metadata properties to describe custom scale rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Metadata properties to describe custom scale rule.",
        SerializedName = @"metadata",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomScaleRuleMetadata) })]
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomScaleRuleMetadata Metadata { get; set; }
        /// <summary>
        /// Type of the custom scale rule
        /// eg: azure-servicebus, redis etc.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of the custom scale rule
        eg: azure-servicebus, redis etc.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get; set; }

    }
    /// Container App container Custom scaling rule.
    internal partial interface ICustomScaleRuleInternal

    {
        /// <summary>Authentication secrets for the custom scale rule.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IScaleRuleAuth[] Auth { get; set; }
        /// <summary>Metadata properties to describe custom scale rule.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomScaleRuleMetadata Metadata { get; set; }
        /// <summary>
        /// Type of the custom scale rule
        /// eg: azure-servicebus, redis etc.
        /// </summary>
        string Type { get; set; }

    }
}