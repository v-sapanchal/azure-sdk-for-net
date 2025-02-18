// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventHubs.Models
{
    public partial class CaptureDescription : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Enabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(Enabled.Value);
            }
            if (Optional.IsDefined(Encoding))
            {
                writer.WritePropertyName("encoding"u8);
                writer.WriteStringValue(Encoding.Value.ToSerialString());
            }
            if (Optional.IsDefined(IntervalInSeconds))
            {
                writer.WritePropertyName("intervalInSeconds"u8);
                writer.WriteNumberValue(IntervalInSeconds.Value);
            }
            if (Optional.IsDefined(SizeLimitInBytes))
            {
                writer.WritePropertyName("sizeLimitInBytes"u8);
                writer.WriteNumberValue(SizeLimitInBytes.Value);
            }
            if (Optional.IsDefined(Destination))
            {
                writer.WritePropertyName("destination"u8);
                writer.WriteObjectValue(Destination);
            }
            if (Optional.IsDefined(SkipEmptyArchives))
            {
                writer.WritePropertyName("skipEmptyArchives"u8);
                writer.WriteBooleanValue(SkipEmptyArchives.Value);
            }
            writer.WriteEndObject();
        }

        internal static CaptureDescription DeserializeCaptureDescription(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> enabled = default;
            Optional<EncodingCaptureDescription> encoding = default;
            Optional<int> intervalInSeconds = default;
            Optional<int> sizeLimitInBytes = default;
            Optional<EventHubDestination> destination = default;
            Optional<bool> skipEmptyArchives = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("encoding"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    encoding = property.Value.GetString().ToEncodingCaptureDescription();
                    continue;
                }
                if (property.NameEquals("intervalInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    intervalInSeconds = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("sizeLimitInBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sizeLimitInBytes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("destination"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    destination = EventHubDestination.DeserializeEventHubDestination(property.Value);
                    continue;
                }
                if (property.NameEquals("skipEmptyArchives"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    skipEmptyArchives = property.Value.GetBoolean();
                    continue;
                }
            }
            return new CaptureDescription(Optional.ToNullable(enabled), Optional.ToNullable(encoding), Optional.ToNullable(intervalInSeconds), Optional.ToNullable(sizeLimitInBytes), destination.Value, Optional.ToNullable(skipEmptyArchives));
        }
    }
}
