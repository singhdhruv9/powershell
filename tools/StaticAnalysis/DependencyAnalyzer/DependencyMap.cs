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
using System.Text.RegularExpressions;
using Tools.Common.Helpers;
using Tools.Common.Issues;

namespace StaticAnalysis.DependencyAnalyzer
{
    /// <summary>
    /// Record for reporting assemblies that are not used by a Cmdlet assembly or its dependencies
    /// </summary>
    public class DependencyMap : IReportRecord
    {
        public string Directory { get; set; }

        public string AssemblyName { get; set; }

        public string AssemblyVersion { get; set; }

        public string ReferencingAssembly { get; set; }

        public string ReferencingAssemblyVersion { get; set; }

        public int Severity { get; set; }

        public int ProblemId { get; set; }

        public string Description { get; set; }

        public string Remediation { get; set; }


        public string PrintHeaders()
        {
            return "\"AssemblyName\",\"AssemblyVersion\",\"ReferencingAssembly\",\"ReferencingAssemblyVersion\",\"Directory\"";
        }

        public string FormatRecord()
        {
            return string.Format("\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\"",
                AssemblyName, AssemblyVersion, ReferencingAssembly, ReferencingAssemblyVersion, Directory);
        }

        public override string ToString()
        {
            return FormatRecord();
        }


        public bool Match(IReportRecord other)
        {
            var result = false;
            var record = other as ExtraAssembly;
            if (record != null)
            {
                result = string.Equals(EnvironmentHelpers.GetDirectoryName(record.Directory),
                    EnvironmentHelpers.GetDirectoryName(Directory), StringComparison.OrdinalIgnoreCase)
                    && string.Equals(record.AssemblyName, AssemblyName, StringComparison.OrdinalIgnoreCase)
                    && record.ProblemId == ProblemId;
            }

            return result;
        }

        public IReportRecord Parse(string line)
        {
            var matcher = "\"([^\"]+)\",\"([^\"]+)\",\"([^\"]+)\",\"([^\"]+)\",\"([^\"]+)\"";
            var match = Regex.Match(line, matcher);
            if (!match.Success || match.Groups.Count < 6)
            {
                throw new InvalidOperationException(string.Format("Could not parse '{0}' as DependencyMap record", line));
            }

            AssemblyName = match.Groups[1].Value;
            AssemblyVersion = match.Groups[2].Value;
            ReferencingAssembly = match.Groups[3].Value;
            ReferencingAssemblyVersion = match.Groups[4].Value;
            Directory = match.Groups[5].Value;
            return this;
        }
    }
}
