//  
// Copyright (c) Microsoft.  All rights reserved.
// 
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//    http://www.apache.org/licenses/LICENSE-2.0
// 
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.

namespace Microsoft.Azure.Commands.ApiManagement.ServiceManagement.Commands
{
    using System;
    using System.Management.Automation;
    using Microsoft.Azure.Commands.ApiManagement.ServiceManagement.Models;

    [Cmdlet("Get", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "ApiManagementProduct", DefaultParameterSetName = GetAllProducts)]
    [OutputType(typeof(PsApiManagementProduct), ParameterSetName = new[] { GetAllProducts, GetByTitle, GetById, GetByApiId })]
    public class GetAzureApiManagementProduct : AzureApiManagementCmdletBase
    {
        private const string GetAllProducts = "GetAllProducts";
        private const string GetById = "GetByProductId";
        private const string GetByTitle = "GetByTitle";
        private const string GetByApiId = "GetByApiId";

        [Parameter(
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true,
            Mandatory = true,
            HelpMessage = "Instance of PsApiManagementContext. This parameter is required.")]
        [ValidateNotNullOrEmpty]
        public PsApiManagementContext Context { get; set; }

        [Parameter(
            ParameterSetName = GetById,
            ValueFromPipelineByPropertyName = true,
            Mandatory = true,
            HelpMessage = "Identifier of Product to search for. This parameter is optional.")]
        [ValidateNotNullOrEmpty]
        public String ProductId { get; set; }

        [Parameter(
            ParameterSetName = GetByTitle,
            ValueFromPipelineByPropertyName = true,
            Mandatory = false,
            HelpMessage = "Title of the Product to look for. If specified will try to get the Product by title. This parameter is optional.")]
        public String Title { get; set; }

        [Parameter(
            ParameterSetName = GetByApiId,
            ValueFromPipelineByPropertyName = true,
            Mandatory = true,
            HelpMessage = "ApiId of the Api to find the correlated products. This parameter is optional.")]
        public String ApiId { get; set; }

        public override void ExecuteApiManagementCmdlet()
        {
            if (ParameterSetName.Equals(GetAllProducts))
            {
                var products = Client.ProductList(Context, null);
                WriteObject(products, true);
            }
            else if (ParameterSetName.Equals(GetById))
            {
                var product = Client.ProductById(Context, ProductId);
                WriteObject(product);
            }
            else if (ParameterSetName.Equals(GetByTitle))
            {
                var products = Client.ProductList(Context, Title);
                WriteObject(products, true);
            }
            else if (ParameterSetName.Equals(GetByApiId))
            {
                var products = Client.ProductListByApi(Context, ApiId);
                WriteObject(products, true);
            }
            else
            {
                throw new InvalidOperationException(string.Format("Parameter set name '{0}' is not supported.", ParameterSetName));
            }
        }
    }
}
