// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;

namespace CustomNamespace
{
    /// <summary> The ThirdModel. </summary>
    internal partial class RenamedThirdModel
    {
        /// <summary> Initializes a new instance of <see cref="RenamedThirdModel"/>. </summary>
        public RenamedThirdModel()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RenamedThirdModel"/>. </summary>
        /// <param name="customizedETagProperty"> ETag property. </param>
        /// <param name="customizedCreatedAtProperty"> Creation date. </param>
        internal RenamedThirdModel(ETag customizedETagProperty, DateTime customizedCreatedAtProperty)
        {
            CustomizedETagProperty = customizedETagProperty;
            CustomizedCreatedAtProperty = customizedCreatedAtProperty;
        }
    }
}
