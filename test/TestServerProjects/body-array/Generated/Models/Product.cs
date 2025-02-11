// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace body_array.Models
{
    /// <summary> The Product. </summary>
    public partial class Product
    {
        /// <summary> Initializes a new instance of <see cref="Product"/>. </summary>
        public Product()
        {
        }

        /// <summary> Initializes a new instance of <see cref="Product"/>. </summary>
        /// <param name="integer"></param>
        /// <param name="string"></param>
        internal Product(int? integer, string @string)
        {
            Integer = integer;
            String = @string;
        }

        /// <summary> Gets or sets the integer. </summary>
        public int? Integer { get; set; }
        /// <summary> Gets or sets the string. </summary>
        public string String { get; set; }
    }
}
