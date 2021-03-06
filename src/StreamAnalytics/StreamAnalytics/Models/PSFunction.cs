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

using Microsoft.Azure.Management.StreamAnalytics.Models;
using System;

namespace Microsoft.Azure.Commands.StreamAnalytics.Models
{
    public class PSFunction
    {
        private Function function;

        public PSFunction()
        {
            function = new Function();
        }

        public PSFunction(Function function)
        {
            if (function == null)
            {
                throw new ArgumentNullException("function");
            }

            this.function = function;
        }

        public string Name
        {
            get
            {
                return function.Name;
            }
            internal set
            {
                function.Name = value;
            }
        }

        public string JobName { get; set; }

        public string ResourceGroupName { get; set; }

        public FunctionProperties Properties
        {
            get
            {
                return function.Properties;
            }
            internal set
            {
                function.Properties = value;
            }
        }

        public string PropertiesInJson
        {
            get { return function.ToFormattedString(); }
        }
    }
}
