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
    /// ScriptCreateRequest
    /// </summary>
    [DataContract]
    public partial class ScriptCreateRequest : IEquatable<ScriptCreateRequest>
    {
        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name = "language", EmitDefaultValue = false)]
        public ScriptLanguage Language { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScriptCreateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ScriptCreateRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScriptCreateRequest" /> class.
        /// </summary>
        /// <param name="name">The name of the script. The name must be unique within the organization. (required).</param>
        /// <param name="description">description (required).</param>
        /// <param name="script">The script to execute. (required).</param>
        /// <param name="language">language (required).</param>
        public ScriptCreateRequest(string name = default, string description = default, string script = default,
            ScriptLanguage language = default)
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException(
                    "name is a required property for ScriptCreateRequest and cannot be null");
            }

            Name = name;
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new InvalidDataException(
                    "description is a required property for ScriptCreateRequest and cannot be null");
            }

            Description = description;
            // to ensure "script" is required (not null)
            if (script == null)
            {
                throw new InvalidDataException(
                    "script is a required property for ScriptCreateRequest and cannot be null");
            }

            Script = script;
            // to ensure "language" is required (not null)
            Language = language;
        }

        /// <summary>
        /// The name of the script. The name must be unique within the organization.
        /// </summary>
        /// <value>The name of the script. The name must be unique within the organization.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The script to execute.
        /// </summary>
        /// <value>The script to execute.</value>
        [DataMember(Name = "script", EmitDefaultValue = false)]
        public string Script { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScriptCreateRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Script: ").Append(Script).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
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
            return Equals(input as ScriptCreateRequest);
        }

        /// <summary>
        /// Returns true if ScriptCreateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ScriptCreateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScriptCreateRequest input)
        {
            if (input == null)
            {
                return false;
            }

            return
                (
                    Name == input.Name ||
                    Name != null && Name.Equals(input.Name)
                ) &&
                (
                    Description == input.Description ||
                    Description != null && Description.Equals(input.Description)
                ) &&
                (
                    Script == input.Script ||
                    Script != null && Script.Equals(input.Script)
                ) &&
                (
                    Language == input.Language ||
                    Language.Equals(input.Language)
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

                if (Name != null)
                {
                    hashCode = hashCode * 59 + Name.GetHashCode();
                }

                if (Description != null)
                {
                    hashCode = hashCode * 59 + Description.GetHashCode();
                }

                if (Script != null)
                {
                    hashCode = hashCode * 59 + Script.GetHashCode();
                }

                hashCode = hashCode * 59 + Language.GetHashCode();
                return hashCode;
            }
        }
    }
}