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
    /// RoutesExternal
    /// </summary>
    [DataContract]
    public partial class RoutesExternal : IEquatable<RoutesExternal>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoutesExternal" /> class.
        /// </summary>
        /// <param name="statusFeed">statusFeed.</param>
        public RoutesExternal(string statusFeed = default)
        {
            StatusFeed = statusFeed;
        }

        /// <summary>
        /// Gets or Sets StatusFeed
        /// </summary>
        [DataMember(Name = "statusFeed", EmitDefaultValue = false)]
        public string StatusFeed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoutesExternal {\n");
            sb.Append("  StatusFeed: ").Append(StatusFeed).Append("\n");
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
            return Equals(input as RoutesExternal);
        }

        /// <summary>
        /// Returns true if RoutesExternal instances are equal
        /// </summary>
        /// <param name="input">Instance of RoutesExternal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoutesExternal input)
        {
            if (input == null)
            {
                return false;
            }

            return
                StatusFeed == input.StatusFeed ||
                StatusFeed != null && StatusFeed.Equals(input.StatusFeed);
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

                if (StatusFeed != null)
                {
                    hashCode = hashCode * 59 + StatusFeed.GetHashCode();
                }

                return hashCode;
            }
        }
    }
}