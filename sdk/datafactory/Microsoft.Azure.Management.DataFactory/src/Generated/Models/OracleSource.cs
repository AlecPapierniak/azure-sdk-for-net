// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A copy activity Oracle source.
    /// </summary>
    public partial class OracleSource : CopySource
    {
        /// <summary>
        /// Initializes a new instance of the OracleSource class.
        /// </summary>
        public OracleSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OracleSource class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="sourceRetryCount">Source retry count. Type: integer
        /// (or Expression with resultType integer).</param>
        /// <param name="sourceRetryWait">Source retry wait. Type: string (or
        /// Expression with resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).</param>
        /// <param name="maxConcurrentConnections">The maximum concurrent
        /// connection count for the source data store. Type: integer (or
        /// Expression with resultType integer).</param>
        /// <param name="oracleReaderQuery">Oracle reader query. Type: string
        /// (or Expression with resultType string).</param>
        /// <param name="queryTimeout">Query timeout. Type: string (or
        /// Expression with resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).</param>
        /// <param name="partitionOption">The partition mechanism that will be
        /// used for oracle read in parallel.</param>
        /// <param name="partitionSettings">The settings that will be leveraged
        /// for oracle source partitioning.</param>
        public OracleSource(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), object sourceRetryCount = default(object), object sourceRetryWait = default(object), object maxConcurrentConnections = default(object), object oracleReaderQuery = default(object), object queryTimeout = default(object), object partitionOption = default(object), OraclePartitionSettings partitionSettings = default(OraclePartitionSettings))
            : base(additionalProperties, sourceRetryCount, sourceRetryWait, maxConcurrentConnections)
        {
            OracleReaderQuery = oracleReaderQuery;
            QueryTimeout = queryTimeout;
            PartitionOption = partitionOption;
            PartitionSettings = partitionSettings;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets oracle reader query. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "oracleReaderQuery")]
        public object OracleReaderQuery { get; set; }

        /// <summary>
        /// Gets or sets query timeout. Type: string (or Expression with
        /// resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).
        /// </summary>
        [JsonProperty(PropertyName = "queryTimeout")]
        public object QueryTimeout { get; set; }

        /// <summary>
        /// Gets or sets the partition mechanism that will be used for oracle
        /// read in parallel.
        /// </summary>
        [JsonProperty(PropertyName = "partitionOption")]
        public object PartitionOption { get; set; }

        /// <summary>
        /// Gets or sets the settings that will be leveraged for oracle source
        /// partitioning.
        /// </summary>
        [JsonProperty(PropertyName = "partitionSettings")]
        public OraclePartitionSettings PartitionSettings { get; set; }

    }
}