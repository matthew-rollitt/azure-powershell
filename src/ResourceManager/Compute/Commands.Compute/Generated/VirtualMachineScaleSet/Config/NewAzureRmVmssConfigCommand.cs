// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using Microsoft.Azure.Management.Compute.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.Compute.Automation
{
    [Cmdlet("New", "AzureRmVmssConfig")]
    [OutputType(typeof(VirtualMachineScaleSet))]
    public class NewAzureRmVmssConfigCommand : Microsoft.Azure.Commands.ResourceManager.Common.AzureRMCmdlet
    {
        [Parameter(
            Mandatory = false,
            Position = 0,
            ValueFromPipelineByPropertyName = true)]
        public bool? OverProvision { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 1,
            ValueFromPipelineByPropertyName = true)]
        public string Location { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 2,
            ValueFromPipelineByPropertyName = true)]
        public Hashtable Tag { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 3,
            ValueFromPipelineByPropertyName = true)]
        public string SkuName { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 4,
            ValueFromPipelineByPropertyName = true)]
        public string SkuTier { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 5,
            ValueFromPipelineByPropertyName = true)]
        public Int64? SkuCapacity { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 6,
            ValueFromPipelineByPropertyName = true)]
        public UpgradeMode? UpgradePolicyMode { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 7,
            ValueFromPipelineByPropertyName = true)]
        public VirtualMachineScaleSetOSProfile OsProfile { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 8,
            ValueFromPipelineByPropertyName = true)]
        public VirtualMachineScaleSetStorageProfile StorageProfile { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 9,
            ValueFromPipelineByPropertyName = true)]
        public VirtualMachineScaleSetNetworkConfiguration[] NetworkInterfaceConfiguration { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 10,
            ValueFromPipelineByPropertyName = true)]
        public VirtualMachineScaleSetExtension[] Extension { get; set; }

        protected override void ProcessRecord()
        {
            // Sku
            Microsoft.Azure.Management.Compute.Models.Sku vSku = null;

            // UpgradePolicy
            Microsoft.Azure.Management.Compute.Models.UpgradePolicy vUpgradePolicy = null;

            // VirtualMachineProfile
            Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetVMProfile vVirtualMachineProfile = null;

            if (this.SkuName != null)
            {
                if (vSku == null)
                {
                    vSku = new Microsoft.Azure.Management.Compute.Models.Sku();
                }
                vSku.Name = this.SkuName;
            }

            if (this.SkuTier != null)
            {
                if (vSku == null)
                {
                    vSku = new Microsoft.Azure.Management.Compute.Models.Sku();
                }
                vSku.Tier = this.SkuTier;
            }

            if (this.SkuCapacity != null)
            {
                if (vSku == null)
                {
                    vSku = new Microsoft.Azure.Management.Compute.Models.Sku();
                }
                vSku.Capacity = this.SkuCapacity;
            }

            if (this.UpgradePolicyMode != null)
            {
                if (vUpgradePolicy == null)
                {
                    vUpgradePolicy = new Microsoft.Azure.Management.Compute.Models.UpgradePolicy();
                }
                vUpgradePolicy.Mode = this.UpgradePolicyMode;
            }

            if (this.OsProfile != null)
            {
                if (vVirtualMachineProfile == null)
                {
                    vVirtualMachineProfile = new Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetVMProfile();
                }
                vVirtualMachineProfile.OsProfile = this.OsProfile;
            }

            if (this.StorageProfile != null)
            {
                if (vVirtualMachineProfile == null)
                {
                    vVirtualMachineProfile = new Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetVMProfile();
                }
                vVirtualMachineProfile.StorageProfile = this.StorageProfile;
            }

            if (this.NetworkInterfaceConfiguration != null)
            {
                if (vVirtualMachineProfile == null)
                {
                    vVirtualMachineProfile = new Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetVMProfile();
                }
                if (vVirtualMachineProfile.NetworkProfile == null)
                {
                    vVirtualMachineProfile.NetworkProfile = new Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetNetworkProfile();
                }
                vVirtualMachineProfile.NetworkProfile.NetworkInterfaceConfigurations = this.NetworkInterfaceConfiguration;
            }

            if (this.Extension != null)
            {
                if (vVirtualMachineProfile == null)
                {
                    vVirtualMachineProfile = new Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetVMProfile();
                }
                if (vVirtualMachineProfile.ExtensionProfile == null)
                {
                    vVirtualMachineProfile.ExtensionProfile = new Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetExtensionProfile();
                }
                vVirtualMachineProfile.ExtensionProfile.Extensions = this.Extension;
            }


            var vVirtualMachineScaleSet = new VirtualMachineScaleSet
            {
                OverProvision = this.OverProvision,
                Location = this.Location,
                Tags = (this.Tag == null) ? null : this.Tag.Cast<DictionaryEntry>().ToDictionary(ht => (string)ht.Key, ht => (string)ht.Value),
                Sku = vSku,
                UpgradePolicy = vUpgradePolicy,
                VirtualMachineProfile = vVirtualMachineProfile,
            };

            WriteObject(vVirtualMachineScaleSet);
        }
    }
}

