// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Network Virtual Appliance Additional NIC properties. </summary>
    public partial class VirtualApplianceAdditionalNicProperties
    {
        /// <summary> Initializes a new instance of VirtualApplianceAdditionalNicProperties. </summary>
        public VirtualApplianceAdditionalNicProperties()
        {
        }

        /// <summary> Initializes a new instance of VirtualApplianceAdditionalNicProperties. </summary>
        /// <param name="name"> Name of additional nic. </param>
        /// <param name="hasPublicIP"> Flag (true or false) for Intent for Public Ip on additional nic. </param>
        internal VirtualApplianceAdditionalNicProperties(string name, bool? hasPublicIP)
        {
            Name = name;
            HasPublicIP = hasPublicIP;
        }

        /// <summary> Name of additional nic. </summary>
        public string Name { get; set; }
        /// <summary> Flag (true or false) for Intent for Public Ip on additional nic. </summary>
        public bool? HasPublicIP { get; set; }
    }
}
