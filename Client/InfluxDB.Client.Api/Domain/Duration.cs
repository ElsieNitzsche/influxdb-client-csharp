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
    /// A pair consisting of length of time and the unit of time measured. It is the atomic unit from which all duration literals are composed.
    /// </summary>
    [DataContract]
    public partial class Duration : IEquatable<Duration>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Duration" /> class.
        /// </summary>
        /// <param name="type">Type of AST node.</param>
        /// <param name="magnitude">magnitude.</param>
        /// <param name="unit">unit.</param>
        public Duration(string type = default, long? magnitude = default, string unit = default)
        {
            Type = type;
            Magnitude = magnitude;
            Unit = unit;
        }

        /// <summary>
        /// Type of AST node
        /// </summary>
        /// <value>Type of AST node</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Magnitude
        /// </summary>
        [DataMember(Name = "magnitude", EmitDefaultValue = false)]
        public long? Magnitude { get; set; }

        /// <summary>
        /// Gets or Sets Unit
        /// </summary>
        [DataMember(Name = "unit", EmitDefaultValue = false)]
        public string Unit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Duration {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Magnitude: ").Append(Magnitude).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
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
            return Equals(input as Duration);
        }

        /// <summary>
        /// Returns true if Duration instances are equal
        /// </summary>
        /// <param name="input">Instance of Duration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Duration input)
        {
            if (input == null)
            {
                return false;
            }

            return
                (
                    Type == input.Type ||
                    Type != null && Type.Equals(input.Type)
                ) &&
                (
                    Magnitude == input.Magnitude ||
                    Magnitude != null && Magnitude.Equals(input.Magnitude)
                ) &&
                (
                    Unit == input.Unit ||
                    Unit != null && Unit.Equals(input.Unit)
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

                if (Type != null)
                {
                    hashCode = hashCode * 59 + Type.GetHashCode();
                }

                if (Magnitude != null)
                {
                    hashCode = hashCode * 59 + Magnitude.GetHashCode();
                }

                if (Unit != null)
                {
                    hashCode = hashCode * 59 + Unit.GetHashCode();
                }

                return hashCode;
            }
        }
    }
}