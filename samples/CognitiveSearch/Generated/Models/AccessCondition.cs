// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace CognitiveSearch.Models
{
    /// <summary> Parameter group. </summary>
    public partial class AccessCondition
    {
        /// <summary> Initializes a new instance of <see cref="AccessCondition"/>. </summary>
        public AccessCondition()
        {
        }

        /// <summary> Defines the If-Match condition. The operation will be performed only if the ETag on the server matches this value. </summary>
        public string IfMatch { get; set; }
        /// <summary> Defines the If-None-Match condition. The operation will be performed only if the ETag on the server does not match this value. </summary>
        public string IfNoneMatch { get; set; }
    }
}
