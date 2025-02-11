// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using MgmtPartialResource.Models;

namespace MgmtPartialResource
{
    public partial class PublicIPAddressData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku);
            }
            if (Optional.IsCollectionDefined(Zones))
            {
                writer.WritePropertyName("zones"u8);
                writer.WriteStartArray();
                foreach (var item in Zones)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(PublicIPAllocationMethod))
            {
                writer.WritePropertyName("publicIPAllocationMethod"u8);
                writer.WriteStringValue(PublicIPAllocationMethod.Value.ToString());
            }
            if (Optional.IsDefined(PublicIPAddressVersion))
            {
                writer.WritePropertyName("publicIPAddressVersion"u8);
                writer.WriteStringValue(PublicIPAddressVersion.Value.ToString());
            }
            if (Optional.IsDefined(IpAddress))
            {
                writer.WritePropertyName("ipAddress"u8);
                writer.WriteStringValue(IpAddress);
            }
            if (Optional.IsDefined(IdleTimeoutInMinutes))
            {
                writer.WritePropertyName("idleTimeoutInMinutes"u8);
                writer.WriteNumberValue(IdleTimeoutInMinutes.Value);
            }
            if (Optional.IsDefined(ServicePublicIPAddress))
            {
                writer.WritePropertyName("servicePublicIPAddress"u8);
                writer.WriteObjectValue(ServicePublicIPAddress);
            }
            if (Optional.IsDefined(MigrationPhase))
            {
                writer.WritePropertyName("migrationPhase"u8);
                writer.WriteStringValue(MigrationPhase.Value.ToString());
            }
            if (Optional.IsDefined(LinkedPublicIPAddress))
            {
                writer.WritePropertyName("linkedPublicIPAddress"u8);
                writer.WriteObjectValue(LinkedPublicIPAddress);
            }
            if (Optional.IsDefined(DeleteOption))
            {
                writer.WritePropertyName("deleteOption"u8);
                writer.WriteStringValue(DeleteOption.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static PublicIPAddressData DeserializePublicIPAddressData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<PublicIPAddressSku> sku = default;
            Optional<string> etag = default;
            Optional<IList<string>> zones = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<IPAllocationMethod> publicIPAllocationMethod = default;
            Optional<IPVersion> publicIPAddressVersion = default;
            Optional<string> ipAddress = default;
            Optional<int> idleTimeoutInMinutes = default;
            Optional<string> resourceGuid = default;
            Optional<PublicIPAddressData> servicePublicIPAddress = default;
            Optional<PublicIPAddressMigrationPhase> migrationPhase = default;
            Optional<PublicIPAddressData> linkedPublicIPAddress = default;
            Optional<DeleteOption> deleteOption = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = PublicIPAddressSku.DeserializePublicIPAddressSku(property.Value);
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("zones"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    zones = array;
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("publicIPAllocationMethod"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publicIPAllocationMethod = new IPAllocationMethod(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("publicIPAddressVersion"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publicIPAddressVersion = new IPVersion(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("ipAddress"u8))
                        {
                            ipAddress = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("idleTimeoutInMinutes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            idleTimeoutInMinutes = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("resourceGuid"u8))
                        {
                            resourceGuid = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("servicePublicIPAddress"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            servicePublicIPAddress = DeserializePublicIPAddressData(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("migrationPhase"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            migrationPhase = new PublicIPAddressMigrationPhase(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("linkedPublicIPAddress"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            linkedPublicIPAddress = DeserializePublicIPAddressData(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("deleteOption"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            deleteOption = new DeleteOption(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new PublicIPAddressData(id, name, type, systemData.Value, sku.Value, etag.Value, Optional.ToList(zones), Optional.ToNullable(publicIPAllocationMethod), Optional.ToNullable(publicIPAddressVersion), ipAddress.Value, Optional.ToNullable(idleTimeoutInMinutes), resourceGuid.Value, servicePublicIPAddress.Value, Optional.ToNullable(migrationPhase), linkedPublicIPAddress.Value, Optional.ToNullable(deleteOption));
        }
    }
}
