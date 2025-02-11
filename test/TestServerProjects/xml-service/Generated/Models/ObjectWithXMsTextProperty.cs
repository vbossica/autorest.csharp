// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace xml_service.Models
{
    /// <summary> Contans property. </summary>
    public partial class ObjectWithXMsTextProperty
    {
        /// <summary> Initializes a new instance of <see cref="ObjectWithXMsTextProperty"/>. </summary>
        internal ObjectWithXMsTextProperty()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ObjectWithXMsTextProperty"/>. </summary>
        /// <param name="language"> Returned value should be 'english'. </param>
        /// <param name="content"> Returned value should be 'I am text'. </param>
        internal ObjectWithXMsTextProperty(string language, string content)
        {
            Language = language;
            Content = content;
        }

        /// <summary> Returned value should be 'english'. </summary>
        public string Language { get; }
        /// <summary> Returned value should be 'I am text'. </summary>
        public string Content { get; }
    }
}
