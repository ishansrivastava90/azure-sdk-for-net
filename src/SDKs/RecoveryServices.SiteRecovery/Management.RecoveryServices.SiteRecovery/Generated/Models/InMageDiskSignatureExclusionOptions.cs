// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.RecoveryServices;
    using Microsoft.Azure.Management.RecoveryServices.SiteRecovery;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Guest disk signature based disk exclusion option when doing enable
    /// protection of
    /// virtual machine in InMage provider.
    /// </summary>
    public partial class InMageDiskSignatureExclusionOptions
    {
        /// <summary>
        /// Initializes a new instance of the
        /// InMageDiskSignatureExclusionOptions class.
        /// </summary>
        public InMageDiskSignatureExclusionOptions()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// InMageDiskSignatureExclusionOptions class.
        /// </summary>
        /// <param name="diskSignature">The guest signature of disk to be
        /// excluded from replication.</param>
        public InMageDiskSignatureExclusionOptions(string diskSignature = default(string))
        {
            DiskSignature = diskSignature;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the guest signature of disk to be excluded from
        /// replication.
        /// </summary>
        [JsonProperty(PropertyName = "diskSignature")]
        public string DiskSignature { get; set; }

    }
}