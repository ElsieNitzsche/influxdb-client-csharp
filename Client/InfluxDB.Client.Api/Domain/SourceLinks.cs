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
    /// SourceLinks
    /// </summary>
    [DataContract]
    public partial class SourceLinks : IEquatable<SourceLinks>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SourceLinks" /> class.
        /// </summary>
        /// <param name="self">self.</param>
        /// <param name="query">query.</param>
        /// <param name="health">health.</param>
        /// <param name="buckets">buckets.</param>
        public SourceLinks(string self = default, string query = default, string health = default,
            string buckets = default)
        {
            Self = self;
            Query = query;
            Health = health;
            Buckets = buckets;
        }

        /// <summary>
        /// Gets or Sets Self
        /// </summary>
        [DataMember(Name = "self", EmitDefaultValue = false)]
        public string Self { get; set; }

        /// <summary>
        /// Gets or Sets Query
        /// </summary>
        [DataMember(Name = "query", EmitDefaultValue = false)]
        public string Query { get; set; }

        /// <summary>
        /// Gets or Sets Health
        /// </summary>
        [DataMember(Name = "health", EmitDefaultValue = false)]
        public string Health { get; set; }

        /// <summary>
        /// Gets or Sets Buckets
        /// </summary>
        [DataMember(Name = "buckets", EmitDefaultValue = false)]
        public string Buckets { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SourceLinks {\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("  Health: ").Append(Health).Append("\n");
            sb.Append("  Buckets: ").Append(Buckets).Append("\n");
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
            return Equals(input as SourceLinks);
        }

        /// <summary>
        /// Returns true if SourceLinks instances are equal
        /// </summary>
        /// <param name="input">Instance of SourceLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SourceLinks input)
        {
            if (input == null)
            {
                return false;
            }

            return
                (
                    Self == input.Self ||
                    Self != null && Self.Equals(input.Self)
                ) &&
                (
                    Query == input.Query ||
                    Query != null && Query.Equals(input.Query)
                ) &&
                (
                    Health == input.Health ||
                    Health != null && Health.Equals(input.Health)
                ) &&
                (
                    Buckets == input.Buckets ||
                    Buckets != null && Buckets.Equals(input.Buckets)
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

                if (Self != null)
                {
                    hashCode = hashCode * 59 + Self.GetHashCode();
                }

                if (Query != null)
                {
                    hashCode = hashCode * 59 + Query.GetHashCode();
                }

                if (Health != null)
                {
                    hashCode = hashCode * 59 + Health.GetHashCode();
                }

                if (Buckets != null)
                {
                    hashCode = hashCode * 59 + Buckets.GetHashCode();
                }

                return hashCode;
            }
        }
    }
}