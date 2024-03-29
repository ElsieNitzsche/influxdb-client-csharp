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
    /// TemplateSummarySummaryTagRules
    /// </summary>
    [DataContract]
    public partial class TemplateSummarySummaryTagRules : IEquatable<TemplateSummarySummaryTagRules>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateSummarySummaryTagRules" /> class.
        /// </summary>
        /// <param name="key">key.</param>
        /// <param name="value">value.</param>
        /// <param name="_operator">_operator.</param>
        public TemplateSummarySummaryTagRules(string key = default, string value = default, string _operator = default)
        {
            Key = key;
            Value = value;
            Operator = _operator;
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
        /// Gets or Sets Operator
        /// </summary>
        [DataMember(Name = "operator", EmitDefaultValue = false)]
        public string Operator { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateSummarySummaryTagRules {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
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
            return Equals(input as TemplateSummarySummaryTagRules);
        }

        /// <summary>
        /// Returns true if TemplateSummarySummaryTagRules instances are equal
        /// </summary>
        /// <param name="input">Instance of TemplateSummarySummaryTagRules to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateSummarySummaryTagRules input)
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
                ) &&
                (
                    Operator == input.Operator ||
                    Operator != null && Operator.Equals(input.Operator)
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

                if (Operator != null)
                {
                    hashCode = hashCode * 59 + Operator.GetHashCode();
                }

                return hashCode;
            }
        }
    }
}