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
    /// AnalyzeQueryResponse
    /// </summary>
    [DataContract]
    public partial class AnalyzeQueryResponse : IEquatable<AnalyzeQueryResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeQueryResponse" /> class.
        /// </summary>
        /// <param name="errors">errors.</param>
        public AnalyzeQueryResponse(List<AnalyzeQueryResponseErrors> errors = default)
        {
            Errors = errors;
        }

        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name = "errors", EmitDefaultValue = false)]
        public List<AnalyzeQueryResponseErrors> Errors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalyzeQueryResponse {\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
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
            return Equals(input as AnalyzeQueryResponse);
        }

        /// <summary>
        /// Returns true if AnalyzeQueryResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AnalyzeQueryResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnalyzeQueryResponse input)
        {
            if (input == null)
            {
                return false;
            }

            return
                Errors == input.Errors ||
                Errors != null &&
                Errors.SequenceEqual(input.Errors);
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

                if (Errors != null)
                {
                    hashCode = hashCode * 59 + Errors.GetHashCode();
                }

                return hashCode;
            }
        }
    }
}