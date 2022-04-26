﻿// -----------------------------------------------------------------------------
﻿//
﻿// Copyright Microsoft Corporation
﻿// Licensed under the Apache License, Version 2.0 (the "License");
﻿// you may not use this file except in compliance with the License.
﻿// You may obtain a copy of the License at
﻿// http://www.apache.org/licenses/LICENSE-2.0
﻿// Unless required by applicable law or agreed to in writing, software
﻿// distributed under the License is distributed on an "AS IS" BASIS,
﻿// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
﻿// See the License for the specific language governing permissions and
﻿// limitations under the License.
﻿// -----------------------------------------------------------------------------
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:5.0.15
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.Batch.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using Microsoft.Azure.Batch;
    
    
    public partial class PSNodeVMExtension
    {
        
        internal Microsoft.Azure.Batch.NodeVMExtension omObject;
        
        private PSVMExtensionInstanceView instanceView;
        
        private PSVMExtension vmExtension;
        
        public PSNodeVMExtension()
        {
            this.omObject = new Microsoft.Azure.Batch.NodeVMExtension();
        }
        
        internal PSNodeVMExtension(Microsoft.Azure.Batch.NodeVMExtension omObject)
        {
            if ((omObject == null))
            {
                throw new System.ArgumentNullException("omObject");
            }
            this.omObject = omObject;
        }
        
        public PSVMExtensionInstanceView InstanceView
        {
            get
            {
                if (((this.instanceView == null) 
                            && (this.omObject.InstanceView != null)))
                {
                    this.instanceView = new PSVMExtensionInstanceView(this.omObject.InstanceView);
                }
                return this.instanceView;
            }
            set
            {
                if ((value == null))
                {
                    this.omObject.InstanceView = null;
                }
                else
                {
                    this.omObject.InstanceView = value.omObject;
                }
                this.instanceView = value;
            }
        }
        
        public string ProvisioningState
        {
            get
            {
                return this.omObject.ProvisioningState;
            }
            set
            {
                this.omObject.ProvisioningState = value;
            }
        }
        
        public PSVMExtension VmExtension
        {
            get
            {
                if (((this.vmExtension == null) 
                            && (this.omObject.VmExtension != null)))
                {
                    this.vmExtension = new PSVMExtension(this.omObject.VmExtension);
                }
                return this.vmExtension;
            }
            set
            {
                if ((value == null))
                {
                    this.omObject.VmExtension = null;
                }
                else
                {
                    this.omObject.VmExtension = value.omObject;
                }
                this.vmExtension = value;
            }
        }
    }
}
