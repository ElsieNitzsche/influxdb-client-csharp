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
    /// ThresholdCheckTags
    /// </summary>
    [DataContract]
    public partial class ThresholdCheckTags : IEquatable<ThresholdCheckTags>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThresholdCheckTags" /> class.
        /// </summary>
        /// <param name="key">key.</param>
        /// <param name="value">value.</param>
        public ThresholdCheckTags(string key = default, string value = default)
        {
            Key = key;
            Value = value;
        }

        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name = "key", EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ThresholdCheckTags {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return Equals(input as ThresholdCheckTags);
        }

        /// <summary>
        /// Returns true if ThresholdCheckTags instances are equal
        /// </summary>
        /// <param name="input">Instance of ThresholdCheckTags to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ThresholdCheckTags input)
        {
            if (input == null)
            {
                return false;
            }

            return
                (
                    Key == input.Key ||
                    Key != null && Key.Equals(input.Key)
                ) &&
                (
                    Value == input.Value ||
                    Value != null && Value.Equals(input.Value)
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

                if (Key != null)
                {
                    hashCode = hashCode * 59 + Key.GetHashCode();
                }

                if (Value != null)
                {
                    hashCode = hashCode * 59 + Value.GetHashCode();
                }

                return hashCode;
            }
        }
    }
}