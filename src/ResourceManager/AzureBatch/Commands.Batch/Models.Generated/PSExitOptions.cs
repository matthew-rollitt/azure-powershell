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
//     Runtime Version:4.0.30319.42000
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
    
    
    public partial class PSExitOptions
    {
        
        internal Microsoft.Azure.Batch.ExitOptions omObject;
        
        public PSExitOptions()
        {
            this.omObject = new Microsoft.Azure.Batch.ExitOptions();
        }
        
        internal PSExitOptions(Microsoft.Azure.Batch.ExitOptions omObject)
        {
            if ((omObject == null))
            {
                throw new System.ArgumentNullException("omObject");
            }
            this.omObject = omObject;
        }
        
        public Microsoft.Azure.Batch.Common.DependencyAction? DependencyAction
        {
            get
            {
                return this.omObject.DependencyAction;
            }
            set
            {
                this.omObject.DependencyAction = value;
            }
        }
        
        public Microsoft.Azure.Batch.Common.JobAction? JobAction
        {
            get
            {
                return this.omObject.JobAction;
            }
            set
            {
                this.omObject.JobAction = value;
            }
        }
    }
}
