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

namespace Microsoft.Azure.Commands.CosmosDB.Models
{
    using System.Collections.Generic;
    using Microsoft.Azure.Management.CosmosDB.Models;

    public class PSSqlDatabaseGetResults 
    {
        public PSSqlDatabaseGetResults()
        {
        }        
        
        public PSSqlDatabaseGetResults(SqlDatabaseGetResults sqlDatabaseGetResults)
        {
            if (sqlDatabaseGetResults == null)
            {
                return;
            }

            Name = sqlDatabaseGetResults.Name;
            Id = sqlDatabaseGetResults.Id;
            Location = sqlDatabaseGetResults.Location;
            Tags = sqlDatabaseGetResults.Tags;
            Resource = new PSSqlDatabaseGetPropertiesResource(sqlDatabaseGetResults.Resource);
        }

        /// <summary>
        /// Gets or sets Name of the Cosmos DB SQL database
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Id of the Cosmos DB SQL database
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets Location of the Cosmos DB SQL database
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets Tags of the Cosmos DB SQL database
        /// </summary>
        public IDictionary<string, string> Tags { get; set; }

        public PSSqlDatabaseGetPropertiesResource Resource { get; set; }

    }
}
