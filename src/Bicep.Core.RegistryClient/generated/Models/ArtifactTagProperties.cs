// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Bicep.Core.RegistryClient.Models
{
    /// <summary> Tag attributes. </summary>
    public partial class ArtifactTagProperties
    {
        /// <summary> Initializes a new instance of ArtifactTagProperties. </summary>
        /// <param name="registryLoginServer"> Registry login server name.  This is likely to be similar to {registry-name}.azurecr.io. </param>
        /// <param name="repositoryName"> Image name. </param>
        /// <param name="name"> Tag name. </param>
        /// <param name="digest"> Tag digest. </param>
        /// <param name="createdOn"> Tag created time. </param>
        /// <param name="lastUpdatedOn"> Tag last update time. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="registryLoginServer"/>, <paramref name="repositoryName"/>, <paramref name="name"/>, or <paramref name="digest"/> is null. </exception>
        internal ArtifactTagProperties(string registryLoginServer, string repositoryName, string name, string digest, DateTimeOffset createdOn, DateTimeOffset lastUpdatedOn)
        {
            if (registryLoginServer == null)
            {
                throw new ArgumentNullException(nameof(registryLoginServer));
            }
            if (repositoryName == null)
            {
                throw new ArgumentNullException(nameof(repositoryName));
            }
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (digest == null)
            {
                throw new ArgumentNullException(nameof(digest));
            }

            RegistryLoginServer = registryLoginServer;
            RepositoryName = repositoryName;
            Name = name;
            Digest = digest;
            CreatedOn = createdOn;
            LastUpdatedOn = lastUpdatedOn;
        }

        /// <summary> Initializes a new instance of ArtifactTagProperties. </summary>
        /// <param name="registryLoginServer"> Registry login server name.  This is likely to be similar to {registry-name}.azurecr.io. </param>
        /// <param name="repositoryName"> Image name. </param>
        /// <param name="name"> Tag name. </param>
        /// <param name="digest"> Tag digest. </param>
        /// <param name="createdOn"> Tag created time. </param>
        /// <param name="lastUpdatedOn"> Tag last update time. </param>
        /// <param name="canDelete"> Delete enabled. </param>
        /// <param name="canWrite"> Write enabled. </param>
        /// <param name="canList"> List enabled. </param>
        /// <param name="canRead"> Read enabled. </param>
        internal ArtifactTagProperties(string registryLoginServer, string repositoryName, string name, string digest, DateTimeOffset createdOn, DateTimeOffset lastUpdatedOn, bool? canDelete, bool? canWrite, bool? canList, bool? canRead)
        {
            RegistryLoginServer = registryLoginServer;
            RepositoryName = repositoryName;
            Name = name;
            Digest = digest;
            CreatedOn = createdOn;
            LastUpdatedOn = lastUpdatedOn;
            CanDelete = canDelete;
            CanWrite = canWrite;
            CanList = canList;
            CanRead = canRead;
        }

        /// <summary> Registry login server name.  This is likely to be similar to {registry-name}.azurecr.io. </summary>
        public string RegistryLoginServer { get; }
        /// <summary> Image name. </summary>
        public string RepositoryName { get; }
        /// <summary> Tag name. </summary>
        public string Name { get; }
        /// <summary> Tag digest. </summary>
        public string Digest { get; }
        /// <summary> Tag created time. </summary>
        public DateTimeOffset CreatedOn { get; }
        /// <summary> Tag last update time. </summary>
        public DateTimeOffset LastUpdatedOn { get; }
        /// <summary> Delete enabled. </summary>
        public bool? CanDelete { get; }
        /// <summary> Write enabled. </summary>
        public bool? CanWrite { get; }
        /// <summary> List enabled. </summary>
        public bool? CanList { get; }
        /// <summary> Read enabled. </summary>
        public bool? CanRead { get; }
    }
}