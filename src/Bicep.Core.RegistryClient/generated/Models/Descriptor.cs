// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Bicep.Core.RegistryClient.Models
{
    /// <summary> Docker V2 image layer descriptor including config and layers. </summary>
    internal partial class Descriptor
    {
        /// <summary> Initializes a new instance of Descriptor. </summary>
        internal Descriptor()
        {
            Urls = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of Descriptor. </summary>
        /// <param name="mediaType"> Layer media type. </param>
        /// <param name="size"> Layer size. </param>
        /// <param name="digest"> Layer digest. </param>
        /// <param name="urls"> Specifies a list of URIs from which this object may be downloaded. </param>
        /// <param name="annotations"> Additional information provided through arbitrary metadata. </param>
        internal Descriptor(string mediaType, long? size, string digest, IReadOnlyList<string> urls, Annotations annotations)
        {
            MediaType = mediaType;
            Size = size;
            Digest = digest;
            Urls = urls;
            Annotations = annotations;
        }

        /// <summary> Layer media type. </summary>
        public string MediaType { get; }
        /// <summary> Layer size. </summary>
        public long? Size { get; }
        /// <summary> Layer digest. </summary>
        public string Digest { get; }
        /// <summary> Specifies a list of URIs from which this object may be downloaded. </summary>
        public IReadOnlyList<string> Urls { get; }
        /// <summary> Additional information provided through arbitrary metadata. </summary>
        public Annotations Annotations { get; }
    }
}