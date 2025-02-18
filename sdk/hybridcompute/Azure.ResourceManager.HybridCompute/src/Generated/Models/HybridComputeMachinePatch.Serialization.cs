// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridCompute.Models
{
    public partial class HybridComputeMachinePatch : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(LocationData))
            {
                writer.WritePropertyName("locationData"u8);
                writer.WriteObjectValue(LocationData);
            }
            if (Optional.IsDefined(OSProfile))
            {
                writer.WritePropertyName("osProfile"u8);
                writer.WriteObjectValue(OSProfile);
            }
            if (Optional.IsDefined(CloudMetadata))
            {
                writer.WritePropertyName("cloudMetadata"u8);
                writer.WriteObjectValue(CloudMetadata);
            }
            if (Optional.IsDefined(AgentUpgrade))
            {
                writer.WritePropertyName("agentUpgrade"u8);
                writer.WriteObjectValue(AgentUpgrade);
            }
            if (Optional.IsDefined(ParentClusterResourceId))
            {
                writer.WritePropertyName("parentClusterResourceId"u8);
                writer.WriteStringValue(ParentClusterResourceId);
            }
            if (Optional.IsDefined(PrivateLinkScopeResourceId))
            {
                writer.WritePropertyName("privateLinkScopeResourceId"u8);
                writer.WriteStringValue(PrivateLinkScopeResourceId);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
