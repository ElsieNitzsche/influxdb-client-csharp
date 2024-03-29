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
    /// BuilderFunctionsType
    /// </summary>
    [DataContract]
    public partial class BuilderFunctionsType : IEquatable<BuilderFunctionsType>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuilderFunctionsType" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        public BuilderFunctionsType(string name = default)
        {
            Name = name;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BuilderFunctionsType {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return Equals(input as BuilderFunctionsType);
        }

        /// <summary>
        /// Returns true if BuilderFunctionsType instances are equal
        /// </summary>
        /// <param name="input">Instance of BuilderFunctionsType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuilderFunctionsType input)
        {
            if (input == null)
            {
                return false;
            }

            return
                Name == input.Name ||
                Name != null && Name.Equals(input.Name);
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

                return hashCode;
            }
        }
    }
}