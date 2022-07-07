// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Extensions;

    /// <summary>
    /// The configuration settings of the login flow, including the scopes that should be requested.
    /// </summary>
    public partial class LoginScopes :
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ILoginScopes,
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ILoginScopesInternal
    {

        /// <summary>Backing field for <see cref="Scope" /> property.</summary>
        private string[] _scope;

        /// <summary>A list of the scopes that should be requested while authenticating.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Owned)]
        public string[] Scope { get => this._scope; set => this._scope = value; }

        /// <summary>Creates an new <see cref="LoginScopes" /> instance.</summary>
        public LoginScopes()
        {

        }
    }
    /// The configuration settings of the login flow, including the scopes that should be requested.
    public partial interface ILoginScopes :
        Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.IJsonSerializable
    {
        /// <summary>A list of the scopes that should be requested while authenticating.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A list of the scopes that should be requested while authenticating.",
        SerializedName = @"scopes",
        PossibleTypes = new [] { typeof(string) })]
        string[] Scope { get; set; }

    }
    /// The configuration settings of the login flow, including the scopes that should be requested.
    internal partial interface ILoginScopesInternal

    {
        /// <summary>A list of the scopes that should be requested while authenticating.</summary>
        string[] Scope { get; set; }

    }
}