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
    
    
    public partial class PSJobPreparationTask
    {
        
        internal Microsoft.Azure.Batch.JobPreparationTask omObject;
        
        private PSTaskConstraints constraints;
        
        private IList<PSEnvironmentSetting> environmentSettings;
        
        private IList<PSResourceFile> resourceFiles;
        
        public PSJobPreparationTask()
        {
            this.omObject = new Microsoft.Azure.Batch.JobPreparationTask();
        }
        
        public PSJobPreparationTask(string commandLine)
        {
            this.omObject = new Microsoft.Azure.Batch.JobPreparationTask(commandLine);
        }
        
        internal PSJobPreparationTask(Microsoft.Azure.Batch.JobPreparationTask omObject)
        {
            if ((omObject == null))
            {
                throw new System.ArgumentNullException("omObject");
            }
            this.omObject = omObject;
        }
        
        public string CommandLine
        {
            get
            {
                return this.omObject.CommandLine;
            }
            set
            {
                this.omObject.CommandLine = value;
            }
        }
        
        public PSTaskConstraints Constraints
        {
            get
            {
                if (((this.constraints == null) 
                            && (this.omObject.Constraints != null)))
                {
                    this.constraints = new PSTaskConstraints(this.omObject.Constraints);
                }
                return this.constraints;
            }
            set
            {
                if ((value == null))
                {
                    this.omObject.Constraints = null;
                }
                else
                {
                    this.omObject.Constraints = value.omObject;
                }
                this.constraints = value;
            }
        }
        
        public IList<PSEnvironmentSetting> EnvironmentSettings
        {
            get
            {
                if (((this.environmentSettings == null) 
                            && (this.omObject.EnvironmentSettings != null)))
                {
                    List<PSEnvironmentSetting> list;
                    list = new List<PSEnvironmentSetting>();
                    IEnumerator<Microsoft.Azure.Batch.EnvironmentSetting> enumerator;
                    enumerator = this.omObject.EnvironmentSettings.GetEnumerator();
                    for (
                    ; enumerator.MoveNext(); 
                    )
                    {
                        list.Add(new PSEnvironmentSetting(enumerator.Current));
                    }
                    this.environmentSettings = list;
                }
                return this.environmentSettings;
            }
            set
            {
                if ((value == null))
                {
                    this.omObject.EnvironmentSettings = null;
                }
                else
                {
                    this.omObject.EnvironmentSettings = new List<Microsoft.Azure.Batch.EnvironmentSetting>();
                }
                this.environmentSettings = value;
            }
        }
        
        public string Id
        {
            get
            {
                return this.omObject.Id;
            }
            set
            {
                this.omObject.Id = value;
            }
        }
        
        public System.Boolean? RerunOnComputeNodeRebootAfterSuccess
        {
            get
            {
                return this.omObject.RerunOnComputeNodeRebootAfterSuccess;
            }
            set
            {
                this.omObject.RerunOnComputeNodeRebootAfterSuccess = value;
            }
        }
        
        public IList<PSResourceFile> ResourceFiles
        {
            get
            {
                if (((this.resourceFiles == null) 
                            && (this.omObject.ResourceFiles != null)))
                {
                    List<PSResourceFile> list;
                    list = new List<PSResourceFile>();
                    IEnumerator<Microsoft.Azure.Batch.ResourceFile> enumerator;
                    enumerator = this.omObject.ResourceFiles.GetEnumerator();
                    for (
                    ; enumerator.MoveNext(); 
                    )
                    {
                        list.Add(new PSResourceFile(enumerator.Current));
                    }
                    this.resourceFiles = list;
                }
                return this.resourceFiles;
            }
            set
            {
                if ((value == null))
                {
                    this.omObject.ResourceFiles = null;
                }
                else
                {
                    this.omObject.ResourceFiles = new List<Microsoft.Azure.Batch.ResourceFile>();
                }
                this.resourceFiles = value;
            }
        }

        [Obsolete("RunElevated will be removed in a future version and replaced with UserIdentity")]
        public System.Boolean? RunElevated
        {
            get
            {
                return this.omObject.RunElevated;
            }
            set
            {
                this.omObject.RunElevated = value;
            }
        }
        
        public System.Boolean? WaitForSuccess
        {
            get
            {
                return this.omObject.WaitForSuccess;
            }
            set
            {
                this.omObject.WaitForSuccess = value;
            }
        }
    }
}
