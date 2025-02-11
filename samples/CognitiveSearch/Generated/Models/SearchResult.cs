// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace CognitiveSearch.Models
{
    /// <summary> Contains a document found by a search query, plus associated metadata. </summary>
    public partial class SearchResult
    {
        /// <summary> Initializes a new instance of <see cref="SearchResult"/>. </summary>
        /// <param name="score"> The relevance score of the document compared to other documents returned by the query. </param>
        internal SearchResult(double score)
        {
            Score = score;
            Highlights = new ChangeTrackingDictionary<string, IList<string>>();
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of <see cref="SearchResult"/>. </summary>
        /// <param name="score"> The relevance score of the document compared to other documents returned by the query. </param>
        /// <param name="highlights"> Text fragments from the document that indicate the matching search terms, organized by each applicable field; null if hit highlighting was not enabled for the query. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal SearchResult(double score, IReadOnlyDictionary<string, IList<string>> highlights, IReadOnlyDictionary<string, object> additionalProperties)
        {
            Score = score;
            Highlights = highlights;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> The relevance score of the document compared to other documents returned by the query. </summary>
        public double Score { get; }
        /// <summary> Text fragments from the document that indicate the matching search terms, organized by each applicable field; null if hit highlighting was not enabled for the query. </summary>
        public IReadOnlyDictionary<string, IList<string>> Highlights { get; }
        /// <summary> Additional Properties. </summary>
        public IReadOnlyDictionary<string, object> AdditionalProperties { get; }
    }
}
