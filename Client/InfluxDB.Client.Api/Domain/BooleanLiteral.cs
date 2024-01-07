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
    /// Represents boolean values
    /// </summary>
    [DataContract]
    public partial class BooleanLiteral : Expression, IEquatable<BooleanLiteral>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BooleanLiteral" /> class.
        /// </summary>
        /// <param name="type">Type of AST node.</param>
        /// <param name="value">value.</param>
        public BooleanLiteral(string type = default, bool? value = default) : base()
        {
            Type = type;
            Value = value;
        }

        /// <summary>
        /// Type of AST node
        /// </summary>
        /// <value>Type of AST node</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public bool? Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BooleanLiteral {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return Equals(input as BooleanLiteral);
        }

        /// <summary>
        /// Returns true if BooleanLiteral instances are equal
        /// </summary>
        /// <param name="input">Instance of BooleanLiteral to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BooleanLiteral input)
        {
            if (input == null)
            {
                return false;
            }

            return base.Equals(input) &&
                   (
                       Type == input.Type ||
                       Type != null && Type.Equals(input.Type)
                   ) && base.Equals(input) &&
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
                var hashCode = base.GetHashCode();

                if (Type != null)
                {
                    hashCode = hashCode * 59 + Type.GetHashCode();
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