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
    /// LabelCreateRequest
    /// </summary>
    [DataContract]
    public partial class LabelCreateRequest : IEquatable<LabelCreateRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LabelCreateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LabelCreateRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelCreateRequest" /> class.
        /// </summary>
        /// <param name="orgID">orgID (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="properties">Key/Value pairs associated with this label. Keys can be removed by sending an update with an empty value..</param>
        public LabelCreateRequest(string orgID = default, string name = default,
            Dictionary<string, string> properties = default)
        {
            // to ensure "orgID" is required (not null)
            if (orgID == null)
            {
                throw new InvalidDataException(
                    "orgID is a required property for LabelCreateRequest and cannot be null");
            }

            OrgID = orgID;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for LabelCreateRequest and cannot be null");
            }

            Name = name;
            Properties = properties;
        }

        /// <summary>
        /// Gets or Sets OrgID
        /// </summary>
        [DataMember(Name = "orgID", EmitDefaultValue = false)]
        public string OrgID { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Key/Value pairs associated with this label. Keys can be removed by sending an update with an empty value.
        /// </summary>
        /// <value>Key/Value pairs associated with this label. Keys can be removed by sending an update with an empty value.</value>
        [DataMember(Name = "properties", EmitDefaultValue = false)]
        public Dictionary<string, string> Properties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LabelCreateRequest {\n");
            sb.Append("  OrgID: ").Append(OrgID).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
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
            return Equals(input as LabelCreateRequest);
        }

        /// <summary>
        /// Returns true if LabelCreateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of LabelCreateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LabelCreateRequest input)
        {
            if (input == null)
            {
                return false;
            }

            return
                (
                    OrgID == input.OrgID ||
                    OrgID != null && OrgID.Equals(input.OrgID)
                ) &&
                (
                    Name == input.Name ||
                    Name != null && Name.Equals(input.Name)
                ) &&
                (
                    Properties == input.Properties ||
                    Properties != null &&
                    Properties.SequenceEqual(input.Properties)
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

                if (OrgID != null)
                {
                    hashCode = hashCode * 59 + OrgID.GetHashCode();
                }

                if (Name != null)
                {
                    hashCode = hashCode * 59 + Name.GetHashCode();
                }

                if (Properties != null)
                {
                    hashCode = hashCode * 59 + Properties.GetHashCode();
                }

                return hashCode;
            }
        }
    }
}