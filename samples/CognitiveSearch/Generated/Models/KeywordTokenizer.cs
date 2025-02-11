// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace CognitiveSearch.Models
{
    /// <summary> Emits the entire input as a single token. This tokenizer is implemented using Apache Lucene. </summary>
    public partial class KeywordTokenizer : Tokenizer
    {
        /// <summary> Initializes a new instance of <see cref="KeywordTokenizer"/>. </summary>
        /// <param name="name"> The name of the tokenizer. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public KeywordTokenizer(string name) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));

            OdataType = "#Microsoft.Azure.Search.KeywordTokenizer";
        }

        /// <summary> Initializes a new instance of <see cref="KeywordTokenizer"/>. </summary>
        /// <param name="odataType"> Identifies the concrete type of the tokenizer. </param>
        /// <param name="name"> The name of the tokenizer. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        /// <param name="bufferSize"> The read buffer size in bytes. Default is 256. </param>
        internal KeywordTokenizer(string odataType, string name, int? bufferSize) : base(odataType, name)
        {
            BufferSize = bufferSize;
            OdataType = odataType ?? "#Microsoft.Azure.Search.KeywordTokenizer";
        }

        /// <summary> The read buffer size in bytes. Default is 256. </summary>
        public int? BufferSize { get; set; }
    }
}
