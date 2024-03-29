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
    /// RangeThreshold
    /// </summary>
    [DataContract]
    public partial class RangeThreshold : Threshold, IEquatable<RangeThreshold>
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Range for value: range
            /// </summary>
            [EnumMember(Value = "range")] Range = 1
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="RangeThreshold" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RangeThreshold()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RangeThreshold" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to TypeEnum.Range).</param>
        /// <param name="min">min (required).</param>
        /// <param name="max">max (required).</param>
        /// <param name="within">within (required).</param>
        public RangeThreshold(TypeEnum type = TypeEnum.Range, float? min = default, float? max = default,
            bool? within = default, CheckStatusLevel? level = default, bool? allValues = default) : base(level,
            allValues)
        {
            // to ensure "type" is required (not null)
            Type = type;
            // to ensure "min" is required (not null)
            if (min == null)
            {
                throw new InvalidDataException("min is a required property for RangeThreshold and cannot be null");
            }

            Min = min;
            // to ensure "max" is required (not null)
            if (max == null)
            {
                throw new InvalidDataException("max is a required property for RangeThreshold and cannot be null");
            }

            Max = max;
            // to ensure "within" is required (not null)
            if (within == null)
            {
                throw new InvalidDataException("within is a required property for RangeThreshold and cannot be null");
            }

            Within = within;
        }


        /// <summary>
        /// Gets or Sets Min
        /// </summary>
        [DataMember(Name = "min", EmitDefaultValue = false)]
        public float? Min { get; set; }

        /// <summary>
        /// Gets or Sets Max
        /// </summary>
        [DataMember(Name = "max", EmitDefaultValue = false)]
        public float? Max { get; set; }

        /// <summary>
        /// Gets or Sets Within
        /// </summary>
        [DataMember(Name = "within", EmitDefaultValue = false)]
        public bool? Within { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RangeThreshold {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Min: ").Append(Min).Append("\n");
            sb.Append("  Max: ").Append(Max).Append("\n");
            sb.Append("  Within: ").Append(Within).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return Equals(input as RangeThreshold);
        }

        /// <summary>
        /// Returns true if RangeThreshold instances are equal
        /// </summary>
        /// <param name="input">Instance of RangeThreshold to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RangeThreshold input)
        {
            if (input == null)
            {
                return false;
            }

            return base.Equals(input) &&
                   (
                       Type == input.Type ||
                       Type.Equals(input.Type)
                   ) && base.Equals(input) &&
                   (
                       Min == input.Min ||
                       Min != null && Min.Equals(input.Min)
                   ) && base.Equals(input) &&
                   (
                       Max == input.Max ||
                       Max != null && Max.Equals(input.Max)
                   ) && base.Equals(input) &&
                   (
                       Within == input.Within ||
                       Within != null && Within.Equals(input.Within)
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
                var hashCode = base.GetHashCode();

                hashCode = hashCode * 59 + Type.GetHashCode();
                if (Min != null)
                {
                    hashCode = hashCode * 59 + Min.GetHashCode();
                }

                if (Max != null)
                {
                    hashCode = hashCode * 59 + Max.GetHashCode();
                }

                if (Within != null)
                {
                    hashCode = hashCode * 59 + Within.GetHashCode();
                }

                return hashCode;
            }
        }
    }
}