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
    /// ViewLinks
    /// </summary>
    [DataContract]
    public partial class ViewLinks : IEquatable<ViewLinks>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewLinks" /> class.
        /// </summary>
        /// <param name="self">self.</param>
        public ViewLinks(string self = default)
        {
            Self = self;
        }

        /// <summary>
        /// Gets or Sets Self
        /// </summary>
        [DataMember(Name = "self", EmitDefaultValue = false)]
        public string Self { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ViewLinks {\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
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
            return Equals(input as ViewLinks);
        }

        /// <summary>
        /// Returns true if ViewLinks instances are equal
        /// </summary>
        /// <param name="input">Instance of ViewLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ViewLinks input)
        {
            if (input == null)
            {
                return false;
            }

            return
                Self == input.Self ||
                Self != null && Self.Equals(input.Self);
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

                return hashCode;
            }
        }
    }
}