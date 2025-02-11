// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace model_flattening.Models
{
    public partial class BaseProduct : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("base_product_id"u8);
            writer.WriteStringValue(ProductId);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("base_product_description"u8);
                writer.WriteStringValue(Description);
            }
            writer.WriteEndObject();
        }

        internal static BaseProduct DeserializeBaseProduct(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string baseProductId = default;
            Optional<string> baseProductDescription = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("base_product_id"u8))
                {
                    baseProductId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("base_product_description"u8))
                {
                    baseProductDescription = property.Value.GetString();
                    continue;
                }
            }
            return new BaseProduct(baseProductId, baseProductDescription.Value);
        }
    }
}
