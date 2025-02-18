// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> Network access profile for Batch endpoint. </summary>
    public partial class BatchEndpointAccessProfile
    {
        /// <summary> Initializes a new instance of BatchEndpointAccessProfile. </summary>
        /// <param name="defaultAction"> Default action for endpoint access. It is only applicable when publicNetworkAccess is enabled. </param>
        public BatchEndpointAccessProfile(BatchEndpointAccessDefaultAction defaultAction)
        {
            DefaultAction = defaultAction;
            IPRules = new ChangeTrackingList<BatchIPRule>();
        }

        /// <summary> Initializes a new instance of BatchEndpointAccessProfile. </summary>
        /// <param name="defaultAction"> Default action for endpoint access. It is only applicable when publicNetworkAccess is enabled. </param>
        /// <param name="ipRules"> Array of IP ranges to filter client IP address. </param>
        internal BatchEndpointAccessProfile(BatchEndpointAccessDefaultAction defaultAction, IList<BatchIPRule> ipRules)
        {
            DefaultAction = defaultAction;
            IPRules = ipRules;
        }

        /// <summary> Default action for endpoint access. It is only applicable when publicNetworkAccess is enabled. </summary>
        public BatchEndpointAccessDefaultAction DefaultAction { get; set; }
        /// <summary> Array of IP ranges to filter client IP address. </summary>
        public IList<BatchIPRule> IPRules { get; }
    }
}
