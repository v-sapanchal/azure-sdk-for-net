// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The Microsoft Defender for Server VM scanning configuration. </summary>
    public partial class DefenderCspmAwsOfferingVmScanners
    {
        /// <summary> Initializes a new instance of DefenderCspmAwsOfferingVmScanners. </summary>
        public DefenderCspmAwsOfferingVmScanners()
        {
        }

        /// <summary> Initializes a new instance of DefenderCspmAwsOfferingVmScanners. </summary>
        /// <param name="enabled"> Is Microsoft Defender for Server VM scanning enabled. </param>
        /// <param name="configuration"> configuration for Microsoft Defender for Server VM scanning. </param>
        internal DefenderCspmAwsOfferingVmScanners(bool? enabled, DefenderCspmAwsOfferingVmScannersConfiguration configuration)
        {
            Enabled = enabled;
            Configuration = configuration;
        }

        /// <summary> Is Microsoft Defender for Server VM scanning enabled. </summary>
        public bool? Enabled { get; set; }
        /// <summary> configuration for Microsoft Defender for Server VM scanning. </summary>
        public DefenderCspmAwsOfferingVmScannersConfiguration Configuration { get; set; }
    }
}
