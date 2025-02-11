// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;

namespace _Type.Model.Inheritance.SingleDiscriminator.Models
{
    public partial class TRex
    {
        internal static TRex DeserializeTRex(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string kind = default;
            int size = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("size"u8))
                {
                    size = property.Value.GetInt32();
                    continue;
                }
            }
            return new TRex(kind, size);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new TRex FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeTRex(document.RootElement);
        }
    }
}
