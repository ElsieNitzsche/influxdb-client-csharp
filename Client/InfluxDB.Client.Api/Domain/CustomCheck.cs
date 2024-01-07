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
    /// CustomCheck
    /// </summary>
    [DataContract]
    public partial class CustomCheck : Check, IEquatable<CustomCheck>
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Custom for value: custom
            /// </summary>
            [EnumMember(Value = "custom")] Custom = 1
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomCheck" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CustomCheck()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomCheck" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to TypeEnum.Custom).</param>
        public CustomCheck(TypeEnum type = TypeEnum.Custom, string name = default, string orgID = default,
            string taskID = default, DashboardQuery query = default, TaskStatusType? status = default,
            string description = default, List<Label> labels = default, CheckBaseLinks links = default) : base(name,
            orgID, taskID, query, status, description, labels, links)
        {
            // to ensure "type" is required (not null)
            Type = type;
        }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomCheck {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return Equals(input as CustomCheck);
        }

        /// <summary>
        /// Returns true if CustomCheck instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomCheck to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomCheck input)
        {
            if (input == null)
            {
                return false;
            }

            return base.Equals(input) &&
                   (
                       Type == input.Type ||
                       Type.Equals(input.Type)
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
                return hashCode;
            }
        }
    }
}