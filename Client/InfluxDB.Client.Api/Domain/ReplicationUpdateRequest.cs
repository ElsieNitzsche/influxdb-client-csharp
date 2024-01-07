/* 
 * InfluxDB OSS API Service
 *
 * The InfluxDB v2 API provides a programmatic interface for all interactions with InfluxDB. Access the InfluxDB API using the `/api/v2/` endpoint. 
 *
 * OpenAPI spec version: 2.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OpenAPIDateConverter = InfluxDB.Client.Api.Client.OpenAPIDateConverter;

namespace InfluxDB.Client.Api.Domain
{
    /// <summary>
    /// ReplicationUpdateRequest
    /// </summary>
    [DataContract]
    public partial class ReplicationUpdateRequest : IEquatable<ReplicationUpdateRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicationUpdateRequest" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="remoteID">remoteID.</param>
        /// <param name="remoteBucketID">remoteBucketID.</param>
        /// <param name="maxQueueSizeBytes">maxQueueSizeBytes.</param>
        /// <param name="dropNonRetryableData">dropNonRetryableData.</param>
        public ReplicationUpdateRequest(string name = default, string description = default, string remoteID = default,
            string remoteBucketID = default, long? maxQueueSizeBytes = default, bool? dropNonRetryableData = default)
        {
            Name = name;
            Description = description;
            RemoteID = remoteID;
            RemoteBucketID = remoteBucketID;
            MaxQueueSizeBytes = maxQueueSizeBytes;
            DropNonRetryableData = dropNonRetryableData;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets RemoteID
        /// </summary>
        [DataMember(Name = "remoteID", EmitDefaultValue = false)]
        public string RemoteID { get; set; }

        /// <summary>
        /// Gets or Sets RemoteBucketID
        /// </summary>
        [DataMember(Name = "remoteBucketID", EmitDefaultValue = false)]
        public string RemoteBucketID { get; set; }

        /// <summary>
        /// Gets or Sets MaxQueueSizeBytes
        /// </summary>
        [DataMember(Name = "maxQueueSizeBytes", EmitDefaultValue = false)]
        public long? MaxQueueSizeBytes { get; set; }

        /// <summary>
        /// Gets or Sets DropNonRetryableData
        /// </summary>
        [DataMember(Name = "dropNonRetryableData", EmitDefaultValue = false)]
        public bool? DropNonRetryableData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReplicationUpdateRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  RemoteID: ").Append(RemoteID).Append("\n");
            sb.Append("  RemoteBucketID: ").Append(RemoteBucketID).Append("\n");
            sb.Append("  MaxQueueSizeBytes: ").Append(MaxQueueSizeBytes).Append("\n");
            sb.Append("  DropNonRetryableData: ").Append(DropNonRetryableData).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return Equals(input as ReplicationUpdateRequest);
        }

        /// <summary>
        /// Returns true if ReplicationUpdateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ReplicationUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReplicationUpdateRequest input)
        {
            if (input == null)
            {
                return false;
            }

            return
                (
                    Name == input.Name ||
                    Name != null && Name.Equals(input.Name)
                ) &&
                (
                    Description == input.Description ||
                    Description != null && Description.Equals(input.Description)
                ) &&
                (
                    RemoteID == input.RemoteID ||
                    RemoteID != null && RemoteID.Equals(input.RemoteID)
                ) &&
                (
                    RemoteBucketID == input.RemoteBucketID ||
                    RemoteBucketID != null && RemoteBucketID.Equals(input.RemoteBucketID)
                ) &&
                (
                    MaxQueueSizeBytes == input.MaxQueueSizeBytes ||
                    MaxQueueSizeBytes != null && MaxQueueSizeBytes.Equals(input.MaxQueueSizeBytes)
                ) &&
                (
                    DropNonRetryableData == input.DropNonRetryableData ||
                    DropNonRetryableData != null && DropNonRetryableData.Equals(input.DropNonRetryableData)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;

                if (Name != null)
                {
                    hashCode = hashCode * 59 + Name.GetHashCode();
                }

                if (Description != null)
                {
                    hashCode = hashCode * 59 + Description.GetHashCode();
                }

                if (RemoteID != null)
                {
                    hashCode = hashCode * 59 + RemoteID.GetHashCode();
                }

                if (RemoteBucketID != null)
                {
                    hashCode = hashCode * 59 + RemoteBucketID.GetHashCode();
                }

                if (MaxQueueSizeBytes != null)
                {
                    hashCode = hashCode * 59 + MaxQueueSizeBytes.GetHashCode();
                }

                if (DropNonRetryableData != null)
                {
                    hashCode = hashCode * 59 + DropNonRetryableData.GetHashCode();
                }

                return hashCode;
            }
        }
    }
}