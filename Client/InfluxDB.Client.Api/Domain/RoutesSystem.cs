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
    /// RoutesSystem
    /// </summary>
    [DataContract]
    public partial class RoutesSystem : IEquatable<RoutesSystem>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoutesSystem" /> class.
        /// </summary>
        /// <param name="metrics">metrics.</param>
        /// <param name="debug">debug.</param>
        /// <param name="health">health.</param>
        public RoutesSystem(string metrics = default, string debug = default, string health = default)
        {
            Metrics = metrics;
            Debug = debug;
            Health = health;
        }

        /// <summary>
        /// Gets or Sets Metrics
        /// </summary>
        [DataMember(Name = "metrics", EmitDefaultValue = false)]
        public string Metrics { get; set; }

        /// <summary>
        /// Gets or Sets Debug
        /// </summary>
        [DataMember(Name = "debug", EmitDefaultValue = false)]
        public string Debug { get; set; }

        /// <summary>
        /// Gets or Sets Health
        /// </summary>
        [DataMember(Name = "health", EmitDefaultValue = false)]
        public string Health { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoutesSystem {\n");
            sb.Append("  Metrics: ").Append(Metrics).Append("\n");
            sb.Append("  Debug: ").Append(Debug).Append("\n");
            sb.Append("  Health: ").Append(Health).Append("\n");
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
            return Equals(input as RoutesSystem);
        }

        /// <summary>
        /// Returns true if RoutesSystem instances are equal
        /// </summary>
        /// <param name="input">Instance of RoutesSystem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoutesSystem input)
        {
            if (input == null)
            {
                return false;
            }

            return
                (
                    Metrics == input.Metrics ||
                    Metrics != null && Metrics.Equals(input.Metrics)
                ) &&
                (
                    Debug == input.Debug ||
                    Debug != null && Debug.Equals(input.Debug)
                ) &&
                (
                    Health == input.Health ||
                    Health != null && Health.Equals(input.Health)
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

                if (Metrics != null)
                {
                    hashCode = hashCode * 59 + Metrics.GetHashCode();
                }

                if (Debug != null)
                {
                    hashCode = hashCode * 59 + Debug.GetHashCode();
                }

                if (Health != null)
                {
                    hashCode = hashCode * 59 + Health.GetHashCode();
                }

                return hashCode;
            }
        }
    }
}