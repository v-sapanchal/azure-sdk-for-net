// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> The managed application provider authorization. </summary>
    public partial class ArmApplicationAuthorization
    {
        /// <summary> Initializes a new instance of ArmApplicationAuthorization. </summary>
        /// <param name="principalId"> The provider's principal identifier. This is the identity that the provider will use to call ARM to manage the managed application resources. </param>
        /// <param name="roleDefinitionId"> The provider's role definition identifier. This role will define all the permissions that the provider must have on the managed application's container resource group. This role definition cannot have permission to delete the resource group. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleDefinitionId"/> is null. </exception>
        public ArmApplicationAuthorization(Guid principalId, string roleDefinitionId)
        {
            Argument.AssertNotNull(roleDefinitionId, nameof(roleDefinitionId));

            PrincipalId = principalId;
            RoleDefinitionId = roleDefinitionId;
        }

        /// <summary> The provider's principal identifier. This is the identity that the provider will use to call ARM to manage the managed application resources. </summary>
        public Guid PrincipalId { get; set; }
        /// <summary> The provider's role definition identifier. This role will define all the permissions that the provider must have on the managed application's container resource group. This role definition cannot have permission to delete the resource group. </summary>
        public string RoleDefinitionId { get; set; }
    }
}
