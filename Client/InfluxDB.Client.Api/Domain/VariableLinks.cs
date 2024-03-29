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
    /// VariableLinks
    /// </summary>
    [DataContract]
    public partial class VariableLinks : IEquatable<VariableLinks>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VariableLinks" /> class.
        /// </summary>
        /// <param name="self">self.</param>
        /// <param name="org">org.</param>
        /// <param name="labels">labels.</param>
        public VariableLinks(string self = default, string org = default, string labels = default)
        {
            Self = self;
            Org = org;
            Labels = labels;
        }

        /// <summary>
        /// Gets or Sets Self
        /// </summary>
        [DataMember(Name = "self", EmitDefaultValue = false)]
        public string Self { get; set; }

        /// <summary>
        /// Gets or Sets Org
        /// </summary>
        [DataMember(Name = "org", EmitDefaultValue = false)]
        public string Org { get; set; }

        /// <summary>
        /// Gets or Sets Labels
        /// </summary>
        [DataMember(Name = "labels", EmitDefaultValue = false)]
        public string Labels { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VariableLinks {\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
            sb.Append("  Org: ").Append(Org).Append("\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
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
            return Equals(input as VariableLinks);
        }

        /// <summary>
        /// Returns true if VariableLinks instances are equal
        /// </summary>
        /// <param name="input">Instance of VariableLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VariableLinks input)
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
                    Org == input.Org ||
                    Org != null && Org.Equals(input.Org)
                ) &&
                (
                    Labels == input.Labels ||
                    Labels != null && Labels.Equals(input.Labels)
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

                if (Org != null)
                {
                    hashCode = hashCode * 59 + Org.GetHashCode();
                }

                if (Labels != null)
                {
                    hashCode = hashCode * 59 + Labels.GetHashCode();
                }

                return hashCode;
            }
        }
    }
}