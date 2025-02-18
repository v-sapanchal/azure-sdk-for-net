// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetworkAnalytics.Models
{
    public partial class RoleAssignmentDetail : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("roleId"u8);
            writer.WriteStringValue(RoleId);
            writer.WritePropertyName("principalId"u8);
            writer.WriteStringValue(PrincipalId);
            writer.WritePropertyName("userName"u8);
            writer.WriteStringValue(UserName);
            writer.WritePropertyName("dataTypeScope"u8);
            writer.WriteStartArray();
            foreach (var item in DataTypeScope)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("principalType"u8);
            writer.WriteStringValue(PrincipalType);
            writer.WritePropertyName("role"u8);
            writer.WriteStringValue(Role.ToString());
            writer.WritePropertyName("roleAssignmentId"u8);
            writer.WriteStringValue(RoleAssignmentId);
            writer.WriteEndObject();
        }

        internal static RoleAssignmentDetail DeserializeRoleAssignmentDetail(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string roleId = default;
            string principalId = default;
            string userName = default;
            IList<string> dataTypeScope = default;
            string principalType = default;
            DataProductUserRole role = default;
            string roleAssignmentId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("roleId"u8))
                {
                    roleId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("principalId"u8))
                {
                    principalId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("userName"u8))
                {
                    userName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataTypeScope"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    dataTypeScope = array;
                    continue;
                }
                if (property.NameEquals("principalType"u8))
                {
                    principalType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("role"u8))
                {
                    role = new DataProductUserRole(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("roleAssignmentId"u8))
                {
                    roleAssignmentId = property.Value.GetString();
                    continue;
                }
            }
            return new RoleAssignmentDetail(roleId, principalId, userName, dataTypeScope, principalType, role, roleAssignmentId);
        }
    }
}
