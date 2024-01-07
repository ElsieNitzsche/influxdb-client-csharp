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
    /// DBRPCreate
    /// </summary>
    [DataContract]
    public partial class DBRPCreate : IEquatable<DBRPCreate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DBRPCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DBRPCreate()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DBRPCreate" /> class.
        /// </summary>
        /// <param name="orgID">ID of the organization that owns this mapping..</param>
        /// <param name="org">Name of the organization that owns this mapping..</param>
        /// <param name="bucketID">ID of the bucket used as the target for the translation. (required).</param>
        /// <param name="database">InfluxDB v1 database (required).</param>
        /// <param name="retentionPolicy">InfluxDB v1 retention policy (required).</param>
        /// <param name="_default">Mapping represents the default retention policy for the database specified..</param>
        public DBRPCreate(string orgID = default, string org = default, string bucketID = default,
            string database = default, string retentionPolicy = default, bool? _default = default)
        {
            // to ensure "bucketID" is required (not null)
            if (bucketID == null)
            {
                throw new InvalidDataException("bucketID is a required property for DBRPCreate and cannot be null");
            }

            BucketID = bucketID;
            // to ensure "database" is required (not null)
            if (database == null)
            {
                throw new InvalidDataException("database is a required property for DBRPCreate and cannot be null");
            }

            Database = database;
            // to ensure "retentionPolicy" is required (not null)
            if (retentionPolicy == null)
            {
                throw new InvalidDataException(
                    "retentionPolicy is a required property for DBRPCreate and cannot be null");
            }

            RetentionPolicy = retentionPolicy;
            OrgID = orgID;
            Org = org;
            Default = _default;
        }

        /// <summary>
        /// ID of the organization that owns this mapping.
        /// </summary>
        /// <value>ID of the organization that owns this mapping.</value>
        [DataMember(Name = "orgID", EmitDefaultValue = false)]
        public string OrgID { get; set; }

        /// <summary>
        /// Name of the organization that owns this mapping.
        /// </summary>
        /// <value>Name of the organization that owns this mapping.</value>
        [DataMember(Name = "org", EmitDefaultValue = false)]
        public string Org { get; set; }

        /// <summary>
        /// ID of the bucket used as the target for the translation.
        /// </summary>
        /// <value>ID of the bucket used as the target for the translation.</value>
        [DataMember(Name = "bucketID", EmitDefaultValue = false)]
        public string BucketID { get; set; }

        /// <summary>
        /// InfluxDB v1 database
        /// </summary>
        /// <value>InfluxDB v1 database</value>
        [DataMember(Name = "database", EmitDefaultValue = false)]
        public string Database { get; set; }

        /// <summary>
        /// InfluxDB v1 retention policy
        /// </summary>
        /// <value>InfluxDB v1 retention policy</value>
        [DataMember(Name = "retention_policy", EmitDefaultValue = false)]
        public string RetentionPolicy { get; set; }

        /// <summary>
        /// Mapping represents the default retention policy for the database specified.
        /// </summary>
        /// <value>Mapping represents the default retention policy for the database specified.</value>
        [DataMember(Name = "default", EmitDefaultValue = false)]
        public bool? Default { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DBRPCreate {\n");
            sb.Append("  OrgID: ").Append(OrgID).Append("\n");
            sb.Append("  Org: ").Append(Org).Append("\n");
            sb.Append("  BucketID: ").Append(BucketID).Append("\n");
            sb.Append("  Database: ").Append(Database).Append("\n");
            sb.Append("  RetentionPolicy: ").Append(RetentionPolicy).Append("\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
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
            return Equals(input as DBRPCreate);
        }

        /// <summary>
        /// Returns true if DBRPCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of DBRPCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DBRPCreate input)
        {
            if (input == null)
            {
                return false;
            }

            return
                (
                    OrgID == input.OrgID ||
                    OrgID != null && OrgID.Equals(input.OrgID)
                ) &&
                (
                    Org == input.Org ||
                    Org != null && Org.Equals(input.Org)
                ) &&
                (
                    BucketID == input.BucketID ||
                    BucketID != null && BucketID.Equals(input.BucketID)
                ) &&
                (
                    Database == input.Database ||
                    Database != null && Database.Equals(input.Database)
                ) &&
                (
                    RetentionPolicy == input.RetentionPolicy ||
                    RetentionPolicy != null && RetentionPolicy.Equals(input.RetentionPolicy)
                ) &&
                (
                    Default == input.Default ||
                    Default != null && Default.Equals(input.Default)
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

                if (OrgID != null)
                {
                    hashCode = hashCode * 59 + OrgID.GetHashCode();
                }

                if (Org != null)
                {
                    hashCode = hashCode * 59 + Org.GetHashCode();
                }

                if (BucketID != null)
                {
                    hashCode = hashCode * 59 + BucketID.GetHashCode();
                }

                if (Database != null)
                {
                    hashCode = hashCode * 59 + Database.GetHashCode();
                }

                if (RetentionPolicy != null)
                {
                    hashCode = hashCode * 59 + RetentionPolicy.GetHashCode();
                }

                if (Default != null)
                {
                    hashCode = hashCode * 59 + Default.GetHashCode();
                }

                return hashCode;
            }
        }
    }
}