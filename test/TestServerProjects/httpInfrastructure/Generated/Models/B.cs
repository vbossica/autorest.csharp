// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace httpInfrastructure.Models
{
    /// <summary> The B. </summary>
    public partial class B : MyException
    {
        /// <summary> Initializes a new instance of <see cref="B"/>. </summary>
        internal B()
        {
        }

        /// <summary> Initializes a new instance of <see cref="B"/>. </summary>
        /// <param name="statusCode"></param>
        /// <param name="textStatusCode"></param>
        internal B(string statusCode, string textStatusCode) : base(statusCode)
        {
            TextStatusCode = textStatusCode;
        }

        /// <summary> Gets the text status code. </summary>
        public string TextStatusCode { get; }
    }
}
