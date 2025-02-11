// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;
using _Type.Property.ValueTypes;
using _Type.Property.ValueTypes.Models;

namespace _Type.Property.ValueTypes.Samples
{
    public partial class Samples_StringLiteral
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_StringLiteral_GetStringLiteral_ShortVersion()
        {
            StringLiteral client = new ValueTypesClient().GetStringLiteralClient(apiVersion: "1.0.0");

            Response response = client.GetStringLiteral(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("property").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_StringLiteral_GetStringLiteral_ShortVersion_Async()
        {
            StringLiteral client = new ValueTypesClient().GetStringLiteralClient(apiVersion: "1.0.0");

            Response response = await client.GetStringLiteralAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("property").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_StringLiteral_GetStringLiteral_ShortVersion_Convenience()
        {
            StringLiteral client = new ValueTypesClient().GetStringLiteralClient(apiVersion: "1.0.0");

            Response<StringLiteralProperty> response = client.GetStringLiteral();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_StringLiteral_GetStringLiteral_ShortVersion_Convenience_Async()
        {
            StringLiteral client = new ValueTypesClient().GetStringLiteralClient(apiVersion: "1.0.0");

            Response<StringLiteralProperty> response = await client.GetStringLiteralAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_StringLiteral_GetStringLiteral_AllParameters()
        {
            StringLiteral client = new ValueTypesClient().GetStringLiteralClient(apiVersion: "1.0.0");

            Response response = client.GetStringLiteral(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("property").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_StringLiteral_GetStringLiteral_AllParameters_Async()
        {
            StringLiteral client = new ValueTypesClient().GetStringLiteralClient(apiVersion: "1.0.0");

            Response response = await client.GetStringLiteralAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("property").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_StringLiteral_GetStringLiteral_AllParameters_Convenience()
        {
            StringLiteral client = new ValueTypesClient().GetStringLiteralClient(apiVersion: "1.0.0");

            Response<StringLiteralProperty> response = client.GetStringLiteral();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_StringLiteral_GetStringLiteral_AllParameters_Convenience_Async()
        {
            StringLiteral client = new ValueTypesClient().GetStringLiteralClient(apiVersion: "1.0.0");

            Response<StringLiteralProperty> response = await client.GetStringLiteralAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_StringLiteral_Put_ShortVersion()
        {
            StringLiteral client = new ValueTypesClient().GetStringLiteralClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new
            {
                property = "hello",
            });
            Response response = client.Put(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_StringLiteral_Put_ShortVersion_Async()
        {
            StringLiteral client = new ValueTypesClient().GetStringLiteralClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new
            {
                property = "hello",
            });
            Response response = await client.PutAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_StringLiteral_Put_ShortVersion_Convenience()
        {
            StringLiteral client = new ValueTypesClient().GetStringLiteralClient(apiVersion: "1.0.0");

            StringLiteralProperty body = new StringLiteralProperty();
            Response response = client.Put(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_StringLiteral_Put_ShortVersion_Convenience_Async()
        {
            StringLiteral client = new ValueTypesClient().GetStringLiteralClient(apiVersion: "1.0.0");

            StringLiteralProperty body = new StringLiteralProperty();
            Response response = await client.PutAsync(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_StringLiteral_Put_AllParameters()
        {
            StringLiteral client = new ValueTypesClient().GetStringLiteralClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new
            {
                property = "hello",
            });
            Response response = client.Put(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_StringLiteral_Put_AllParameters_Async()
        {
            StringLiteral client = new ValueTypesClient().GetStringLiteralClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new
            {
                property = "hello",
            });
            Response response = await client.PutAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_StringLiteral_Put_AllParameters_Convenience()
        {
            StringLiteral client = new ValueTypesClient().GetStringLiteralClient(apiVersion: "1.0.0");

            StringLiteralProperty body = new StringLiteralProperty();
            Response response = client.Put(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_StringLiteral_Put_AllParameters_Convenience_Async()
        {
            StringLiteral client = new ValueTypesClient().GetStringLiteralClient(apiVersion: "1.0.0");

            StringLiteralProperty body = new StringLiteralProperty();
            Response response = await client.PutAsync(body);
        }
    }
}
