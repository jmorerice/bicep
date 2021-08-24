// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Bicep.Core.RegistryClient.Models
{
    public partial class ContainerRepositoryProperties
    {
        internal static ContainerRepositoryProperties DeserializeContainerRepositoryProperties(JsonElement element)
        {
            string registry = default;
            string imageName = default;
            DateTimeOffset createdTime = default;
            DateTimeOffset lastUpdateTime = default;
            int manifestCount = default;
            int tagCount = default;
            Optional<bool> deleteEnabled = default;
            Optional<bool> writeEnabled = default;
            Optional<bool> listEnabled = default;
            Optional<bool> readEnabled = default;
            Optional<bool> teleportEnabled = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("registry"))
                {
                    registry = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("imageName"))
                {
                    imageName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdTime"))
                {
                    createdTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastUpdateTime"))
                {
                    lastUpdateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("manifestCount"))
                {
                    manifestCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("tagCount"))
                {
                    tagCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("changeableAttributes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("deleteEnabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            deleteEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("writeEnabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            writeEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("listEnabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            listEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("readEnabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            readEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("teleportEnabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            teleportEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ContainerRepositoryProperties(registry, imageName, createdTime, lastUpdateTime, manifestCount, tagCount, Optional.ToNullable(deleteEnabled), Optional.ToNullable(writeEnabled), Optional.ToNullable(listEnabled), Optional.ToNullable(readEnabled), Optional.ToNullable(teleportEnabled));
        }
    }
}