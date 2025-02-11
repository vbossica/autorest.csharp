// <auto-generated/>

#nullable disable

using System;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Net.ClientModel.Core.Pipeline;
using System.Threading;

namespace OpenAI
{
    // Data plane generated sub-client.
    /// <summary> The Audio sub-client. </summary>
    public partial class Audio
    {
        private const string AuthorizationHeader = "Authorization";
        private readonly KeyCredential _keyCredential;
        private const string AuthorizationApiKeyPrefix = "Bearer";
        private readonly MessagePipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal TelemetrySource ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual MessagePipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of Audio for mocking. </summary>
        protected Audio()
        {
        }

        /// <summary> Initializes a new instance of Audio. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="keyCredential"> The key credential to copy. </param>
        /// <param name="endpoint"> OpenAI Endpoint. </param>
        internal Audio(TelemetrySource clientDiagnostics, MessagePipeline pipeline, KeyCredential keyCredential, Uri endpoint)
        {
            ClientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _keyCredential = keyCredential;
            _endpoint = endpoint;
        }

        private AudioTranscriptions _cachedAudioTranscriptions;
        private AudioTranslations _cachedAudioTranslations;

        /// <summary> Initializes a new instance of AudioTranscriptions. </summary>
        public virtual AudioTranscriptions GetAudioTranscriptionsClient()
        {
            return Volatile.Read(ref _cachedAudioTranscriptions) ?? Interlocked.CompareExchange(ref _cachedAudioTranscriptions, new AudioTranscriptions(ClientDiagnostics, _pipeline, _keyCredential, _endpoint), null) ?? _cachedAudioTranscriptions;
        }

        /// <summary> Initializes a new instance of AudioTranslations. </summary>
        public virtual AudioTranslations GetAudioTranslationsClient()
        {
            return Volatile.Read(ref _cachedAudioTranslations) ?? Interlocked.CompareExchange(ref _cachedAudioTranslations, new AudioTranslations(ClientDiagnostics, _pipeline, _keyCredential, _endpoint), null) ?? _cachedAudioTranslations;
        }
    }
}
