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

using System;

namespace Microsoft.Azure.Commands.Sql.ServerDnsAlias.Model
{
	public class AzureSqlServerDnsAliasModel
	{
		/// <summary>
		/// Gets or sets the name of resource group
		/// </summary>
		public string ResourceGroupName { get; set; }

		/// <summary>
		/// Gets or sets the name of the server
		/// </summary>
		public string ServerName { get; set; }

		/// <summary>
		/// Gets or sets the name of server dns alias
		/// </summary>
		public string DnsAliasName { get; set; }

		/// <summary>
		/// Gets or sets the id of the resource
		/// </summary>
		public string Id { get; set; }
	}
}
