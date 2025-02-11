// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Storage.Tables.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class StorageTablesModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="Models.TableQueryResult"/>. </summary>
        /// <param name="odataMetadata"> The metadata response of the table. </param>
        /// <param name="value"> List of tables. </param>
        /// <returns> A new <see cref="Models.TableQueryResult"/> instance for mocking. </returns>
        public static TableQueryResult TableQueryResult(string odataMetadata = null, IEnumerable<TableResponseProperties> value = null)
        {
            value ??= new List<TableResponseProperties>();

            return new TableQueryResult(odataMetadata, value?.ToList());
        }

        /// <summary> Initializes a new instance of <see cref="Models.TableResponseProperties"/>. </summary>
        /// <param name="tableName"> The name of the table. </param>
        /// <param name="odataType"> The odata type of the table. </param>
        /// <param name="odataId"> The id of the table. </param>
        /// <param name="odataEditLink"> The edit link of the table. </param>
        /// <returns> A new <see cref="Models.TableResponseProperties"/> instance for mocking. </returns>
        public static TableResponseProperties TableResponseProperties(string tableName = null, string odataType = null, string odataId = null, string odataEditLink = null)
        {
            return new TableResponseProperties(tableName, odataType, odataId, odataEditLink);
        }

        /// <summary> Initializes a new instance of <see cref="Models.TableResult"/>. </summary>
        /// <param name="tableName"> The name of the table. </param>
        /// <param name="odataType"> The odata type of the table. </param>
        /// <param name="odataId"> The id of the table. </param>
        /// <param name="odataEditLink"> The edit link of the table. </param>
        /// <param name="odataMetadata"> The metadata response of the table. </param>
        /// <returns> A new <see cref="Models.TableResult"/> instance for mocking. </returns>
        public static TableResult TableResult(string tableName = null, string odataType = null, string odataId = null, string odataEditLink = null, string odataMetadata = null)
        {
            return new TableResult(tableName, odataType, odataId, odataEditLink, odataMetadata);
        }

        /// <summary> Initializes a new instance of <see cref="Models.TableEntityQueryResult"/>. </summary>
        /// <param name="odataMetadata"> The metadata response of the table. </param>
        /// <param name="value"> List of table entities. </param>
        /// <returns> A new <see cref="Models.TableEntityQueryResult"/> instance for mocking. </returns>
        public static TableEntityQueryResult TableEntityQueryResult(string odataMetadata = null, IEnumerable<IDictionary<string, object>> value = null)
        {
            value ??= new List<IDictionary<string, object>>();

            return new TableEntityQueryResult(odataMetadata, value?.ToList());
        }

        /// <summary> Initializes a new instance of <see cref="Models.StorageServiceStats"/>. </summary>
        /// <param name="geoReplication"> Geo-Replication information for the Secondary Storage Service. </param>
        /// <returns> A new <see cref="Models.StorageServiceStats"/> instance for mocking. </returns>
        public static StorageServiceStats StorageServiceStats(GeoReplication geoReplication = null)
        {
            return new StorageServiceStats(geoReplication);
        }

        /// <summary> Initializes a new instance of <see cref="Models.GeoReplication"/>. </summary>
        /// <param name="status"> The status of the secondary location. </param>
        /// <param name="lastSyncTime"> A GMT date/time value, to the second. All primary writes preceding this value are guaranteed to be available for read operations at the secondary. Primary writes after this point in time may or may not be available for reads. </param>
        /// <returns> A new <see cref="Models.GeoReplication"/> instance for mocking. </returns>
        public static GeoReplication GeoReplication(GeoReplicationStatusType status = default, DateTimeOffset lastSyncTime = default)
        {
            return new GeoReplication(status, lastSyncTime);
        }
    }
}
