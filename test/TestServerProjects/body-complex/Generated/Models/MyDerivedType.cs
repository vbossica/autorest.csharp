// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace body_complex.Models
{
    /// <summary> The MyDerivedType. </summary>
    public partial class MyDerivedType : MyBaseType
    {
        /// <summary> Initializes a new instance of <see cref="MyDerivedType"/>. </summary>
        internal MyDerivedType()
        {
            Kind = MyKind.Kind1;
        }

        /// <summary> Initializes a new instance of <see cref="MyDerivedType"/>. </summary>
        /// <param name="kind"></param>
        /// <param name="propB1"></param>
        /// <param name="propBH1"></param>
        /// <param name="propD1"></param>
        internal MyDerivedType(MyKind kind, string propB1, string propBH1, string propD1) : base(kind, propB1, propBH1)
        {
            PropD1 = propD1;
            Kind = kind;
        }

        /// <summary> Gets the prop d 1. </summary>
        public string PropD1 { get; }
    }
}
