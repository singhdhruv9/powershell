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

using System.Runtime.Serialization;

namespace Microsoft.Azure.Commands.DataLakeStore.Models
{
    public class DataLakeStoreEnums
    {
        /// <summary>
        /// Scope of ACL entry
        /// </summary>
        public enum ScopeType
        {
            Access,
            Default
        }
        /// <summary>
        /// Type of ACL entry
        /// </summary>
        public enum AceType
        {
            User,
            Group,
            Mask,
            Other
        }

        public enum Encoding
        {
            Ascii,
            BigEndianUnicode,
            Byte,
            Default,
            Unicode,
            UTF32,
            UTF7,
            UTF8
        }

        public enum Owner
        {
            User,
            Group
        }

        public enum PathType
        {
            Any,
            File,
            Folder
        };

        public enum Permission
        {
            None = 0, // "---"
            Execute = 1, // "--x"
            Write = 2, // "-w-"
            WriteExecute = 3, // "-wx"
            Read = 4, // "r--"
            ReadExecute = 5, // "r-x"
            ReadWrite = 6, // "rw-"
            All = 7 // "rwx"
        };

        public enum PermissionScope
        {
            User,
            Group,
            Other
        }
        public enum FileType
        {
            [EnumMember(Value = "FILE")] FILE,
            [EnumMember(Value = "DIRECTORY")] DIRECTORY,
        }
        
        public enum PathRelativeExpiryOptions
        {
            RelativeToNow,
            RelativeToCreationDate
        }
    }
}