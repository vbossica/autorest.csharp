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
using Parameters_LowLevel;

namespace Parameters_LowLevel.Samples
{
    public partial class Samples_ParametersLowlevelClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_NoRequestBodyResponseBody_ShortVersion()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ParametersLowlevelClient client = new ParametersLowlevelClient(credential);

            Response response = client.NoRequestBodyResponseBody(1234, default, null, null, null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_NoRequestBodyResponseBody_ShortVersion_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ParametersLowlevelClient client = new ParametersLowlevelClient(credential);

            Response response = await client.NoRequestBodyResponseBodyAsync(1234, default, null, null, null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_NoRequestBodyResponseBody_AllParameters()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ParametersLowlevelClient client = new ParametersLowlevelClient(credential);

            Response response = client.NoRequestBodyResponseBody(1234, default, 1234, "start", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_NoRequestBodyResponseBody_AllParameters_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ParametersLowlevelClient client = new ParametersLowlevelClient(credential);

            Response response = await client.NoRequestBodyResponseBodyAsync(1234, default, 1234, "start", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_RequestBodyResponseBody_ShortVersion()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ParametersLowlevelClient client = new ParametersLowlevelClient(credential);

            using RequestContent content = null;
            Response response = client.RequestBodyResponseBody(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_RequestBodyResponseBody_ShortVersion_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ParametersLowlevelClient client = new ParametersLowlevelClient(credential);

            using RequestContent content = null;
            Response response = await client.RequestBodyResponseBodyAsync(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_RequestBodyResponseBody_AllParameters()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ParametersLowlevelClient client = new ParametersLowlevelClient(credential);

            using RequestContent content = RequestContent.Create(new
            {
                Code = "<Code>",
                Status = "<Status>",
            });
            Response response = client.RequestBodyResponseBody(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("Code").ToString());
            Console.WriteLine(result.GetProperty("Status").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_RequestBodyResponseBody_AllParameters_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ParametersLowlevelClient client = new ParametersLowlevelClient(credential);

            using RequestContent content = RequestContent.Create(new
            {
                Code = "<Code>",
                Status = "<Status>",
            });
            Response response = await client.RequestBodyResponseBodyAsync(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("Code").ToString());
            Console.WriteLine(result.GetProperty("Status").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_DeleteNoRequestBodyResponseBody_ShortVersion()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ParametersLowlevelClient client = new ParametersLowlevelClient(credential);

            Response response = client.DeleteNoRequestBodyResponseBody("<resourceName>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_DeleteNoRequestBodyResponseBody_ShortVersion_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ParametersLowlevelClient client = new ParametersLowlevelClient(credential);

            Response response = await client.DeleteNoRequestBodyResponseBodyAsync("<resourceName>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_DeleteNoRequestBodyResponseBody_AllParameters()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ParametersLowlevelClient client = new ParametersLowlevelClient(credential);

            Response response = client.DeleteNoRequestBodyResponseBody("<resourceName>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_DeleteNoRequestBodyResponseBody_AllParameters_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ParametersLowlevelClient client = new ParametersLowlevelClient(credential);

            Response response = await client.DeleteNoRequestBodyResponseBodyAsync("<resourceName>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_NoRequestBodyNoResponseBody_ShortVersion()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ParametersLowlevelClient client = new ParametersLowlevelClient(credential);

            Response response = client.NoRequestBodyNoResponseBody();

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_NoRequestBodyNoResponseBody_ShortVersion_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ParametersLowlevelClient client = new ParametersLowlevelClient(credential);

            Response response = await client.NoRequestBodyNoResponseBodyAsync();

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_NoRequestBodyNoResponseBody_AllParameters()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ParametersLowlevelClient client = new ParametersLowlevelClient(credential);

            Response response = client.NoRequestBodyNoResponseBody();

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_NoRequestBodyNoResponseBody_AllParameters_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ParametersLowlevelClient client = new ParametersLowlevelClient(credential);

            Response response = await client.NoRequestBodyNoResponseBodyAsync();

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_RequestBodyNoResponseBody_ShortVersion()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ParametersLowlevelClient client = new ParametersLowlevelClient(credential);

            using RequestContent content = null;
            Response response = client.RequestBodyNoResponseBody(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_RequestBodyNoResponseBody_ShortVersion_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ParametersLowlevelClient client = new ParametersLowlevelClient(credential);

            using RequestContent content = null;
            Response response = await client.RequestBodyNoResponseBodyAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_RequestBodyNoResponseBody_AllParameters()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ParametersLowlevelClient client = new ParametersLowlevelClient(credential);

            using RequestContent content = RequestContent.Create("<stringBody>");
            Response response = client.RequestBodyNoResponseBody(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_RequestBodyNoResponseBody_AllParameters_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ParametersLowlevelClient client = new ParametersLowlevelClient(credential);

            using RequestContent content = RequestContent.Create("<stringBody>");
            Response response = await client.RequestBodyNoResponseBodyAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_OptionalPathParameters_ShortVersion()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ParametersLowlevelClient client = new ParametersLowlevelClient(credential);

            Response response = client.OptionalPathParameters(1234, "start", 1234);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_OptionalPathParameters_ShortVersion_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ParametersLowlevelClient client = new ParametersLowlevelClient(credential);

            Response response = await client.OptionalPathParametersAsync(1234, "start", 1234);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_OptionalPathParameters_AllParameters()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ParametersLowlevelClient client = new ParametersLowlevelClient(credential);

            Response response = client.OptionalPathParameters(1234, "start", 1234);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_OptionalPathParameters_AllParameters_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ParametersLowlevelClient client = new ParametersLowlevelClient(credential);

            Response response = await client.OptionalPathParametersAsync(1234, "start", 1234);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_OptionalPathParametersWithMixedSequence_ShortVersion()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ParametersLowlevelClient client = new ParametersLowlevelClient(credential);

            Response response = client.OptionalPathParametersWithMixedSequence(1234, "start", default);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_OptionalPathParametersWithMixedSequence_ShortVersion_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ParametersLowlevelClient client = new ParametersLowlevelClient(credential);

            Response response = await client.OptionalPathParametersWithMixedSequenceAsync(1234, "start", default);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_OptionalPathParametersWithMixedSequence_AllParameters()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ParametersLowlevelClient client = new ParametersLowlevelClient(credential);

            Response response = client.OptionalPathParametersWithMixedSequence(1234, "start", default);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_OptionalPathParametersWithMixedSequence_AllParameters_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ParametersLowlevelClient client = new ParametersLowlevelClient(credential);

            Response response = await client.OptionalPathParametersWithMixedSequenceAsync(1234, "start", default);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_OptionalPathBodyParametersWithMixedSequence_ShortVersion()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ParametersLowlevelClient client = new ParametersLowlevelClient(credential);

            using RequestContent content = null;
            Response response = client.OptionalPathBodyParametersWithMixedSequence(default, "<name>", 1234, default, content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_OptionalPathBodyParametersWithMixedSequence_ShortVersion_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ParametersLowlevelClient client = new ParametersLowlevelClient(credential);

            using RequestContent content = null;
            Response response = await client.OptionalPathBodyParametersWithMixedSequenceAsync(default, "<name>", 1234, default, content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_OptionalPathBodyParametersWithMixedSequence_AllParameters()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ParametersLowlevelClient client = new ParametersLowlevelClient(credential);

            using RequestContent content = RequestContent.Create(new
            {
                Code = "<Code>",
                Status = "<Status>",
            });
            Response response = client.OptionalPathBodyParametersWithMixedSequence(default, "<name>", 1234, default, content, top: 1234);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_OptionalPathBodyParametersWithMixedSequence_AllParameters_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ParametersLowlevelClient client = new ParametersLowlevelClient(credential);

            using RequestContent content = RequestContent.Create(new
            {
                Code = "<Code>",
                Status = "<Status>",
            });
            Response response = await client.OptionalPathBodyParametersWithMixedSequenceAsync(default, "<name>", 1234, default, content, top: 1234);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_RepeatableAction_ShortVersion()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ParametersLowlevelClient client = new ParametersLowlevelClient(credential);

            using RequestContent content = null;
            Response response = client.RepeatableAction(default, "<name>", content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_RepeatableAction_ShortVersion_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ParametersLowlevelClient client = new ParametersLowlevelClient(credential);

            using RequestContent content = null;
            Response response = await client.RepeatableActionAsync(default, "<name>", content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_RepeatableAction_AllParameters()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ParametersLowlevelClient client = new ParametersLowlevelClient(credential);

            using RequestContent content = RequestContent.Create(new
            {
                Code = "<Code>",
                Status = "<Status>",
            });
            Response response = client.RepeatableAction(default, "<name>", content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_RepeatableAction_AllParameters_Async()
        {
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ParametersLowlevelClient client = new ParametersLowlevelClient(credential);

            using RequestContent content = RequestContent.Create(new
            {
                Code = "<Code>",
                Status = "<Status>",
            });
            Response response = await client.RepeatableActionAsync(default, "<name>", content);

            Console.WriteLine(response.Status);
        }
    }
}
