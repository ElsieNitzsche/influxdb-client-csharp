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
    /// StackAssociations
    /// </summary>
    [DataContract]
    public partial class StackAssociations : IEquatable<StackAssociations>
    {
        /// <summary>
        /// Gets or Sets Kind
        /// </summary>
        [DataMember(Name = "kind", EmitDefaultValue = false)]
        public TemplateKind? Kind { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="StackAssociations" /> class.
        /// </summary>
        /// <param name="kind">kind.</param>
        /// <param name="metaName">metaName.</param>
        public StackAssociations(TemplateKind? kind = default, string metaName = default)
        {
            Kind = kind;
            MetaName = metaName;
        }


        /// <summary>
        /// Gets or Sets MetaName
        /// </summary>
        [DataMember(Name = "metaName", EmitDefaultValue = false)]
        public string MetaName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StackAssociations {\n");
            sb.Append("  Kind: ").Append(Kind).Append("\n");
            sb.Append("  MetaName: ").Append(MetaName).Append("\n");
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
            return Equals(input as StackAssociations);
        }

        /// <summary>
        /// Returns true if StackAssociations instances are equal
        /// </summary>
        /// <param name="input">Instance of StackAssociations to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StackAssociations input)
        {
            if (input == null)
            {
                return false;
            }

            return
                (
                    Kind == input.Kind ||
                    Kind.Equals(input.Kind)
                ) &&
                (
                    MetaName == input.MetaName ||
                    MetaName != null && MetaName.Equals(input.MetaName)
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

                hashCode = hashCode * 59 + Kind.GetHashCode();
                if (MetaName != null)
                {
                    hashCode = hashCode * 59 + MetaName.GetHashCode();
                }

                return hashCode;
            }
        }
    }
}