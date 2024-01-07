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
    /// Query influx using the Flux language
    /// </summary>
    [DataContract]
    public partial class Query : IEquatable<Query>
    {
        /// <summary>
        /// The type of query. Must be \&quot;flux\&quot;.
        /// </summary>
        /// <value>The type of query. Must be \&quot;flux\&quot;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Flux for value: flux
            /// </summary>
            [EnumMember(Value = "flux")] Flux = 1
        }

        /// <summary>
        /// The type of query. Must be \&quot;flux\&quot;.
        /// </summary>
        /// <value>The type of query. Must be \&quot;flux\&quot;.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Query" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Query()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Query" /> class.
        /// </summary>
        /// <param name="_extern">_extern.</param>
        /// <param name="query">Query script to execute. (required).</param>
        /// <param name="type">The type of query. Must be \&quot;flux\&quot;..</param>
        /// <param name="_params">Enumeration of key/value pairs that respresent parameters to be injected into query (can only specify either this field or extern and not both).</param>
        /// <param name="dialect">dialect.</param>
        /// <param name="now">Specifies the time that should be reported as \&quot;now\&quot; in the query. Default is the server&#39;s now time..</param>
        public Query(File _extern = default, string query = default, TypeEnum? type = default,
            Dictionary<string, object> _params = default, Dialect dialect = default, DateTime? now = default)
        {
            // to ensure "query" is required (not null)
            if (query == null)
            {
                throw new InvalidDataException("query is a required property for Query and cannot be null");
            }

            _Query = query;
            Extern = _extern;
            Type = type;
            Params = _params;
            Dialect = dialect;
            Now = now;
        }

        /// <summary>
        /// Gets or Sets Extern
        /// </summary>
        [DataMember(Name = "extern", EmitDefaultValue = false)]
        public File Extern { get; set; }

        /// <summary>
        /// Query script to execute.
        /// </summary>
        /// <value>Query script to execute.</value>
        [DataMember(Name = "query", EmitDefaultValue = false)]
        public string _Query { get; set; }


        /// <summary>
        /// Enumeration of key/value pairs that respresent parameters to be injected into query (can only specify either this field or extern and not both)
        /// </summary>
        /// <value>Enumeration of key/value pairs that respresent parameters to be injected into query (can only specify either this field or extern and not both)</value>
        [DataMember(Name = "params", EmitDefaultValue = false)]
        public Dictionary<string, object> Params { get; set; }

        /// <summary>
        /// Gets or Sets Dialect
        /// </summary>
        [DataMember(Name = "dialect", EmitDefaultValue = false)]
        public Dialect Dialect { get; set; }

        /// <summary>
        /// Specifies the time that should be reported as \&quot;now\&quot; in the query. Default is the server&#39;s now time.
        /// </summary>
        /// <value>Specifies the time that should be reported as \&quot;now\&quot; in the query. Default is the server&#39;s now time.</value>
        [DataMember(Name = "now", EmitDefaultValue = false)]
        public DateTime? Now { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Query {\n");
            sb.Append("  Extern: ").Append(Extern).Append("\n");
            sb.Append("  _Query: ").Append(_Query).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Params: ").Append(Params).Append("\n");
            sb.Append("  Dialect: ").Append(Dialect).Append("\n");
            sb.Append("  Now: ").Append(Now).Append("\n");
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
            return Equals(input as Query);
        }

        /// <summary>
        /// Returns true if Query instances are equal
        /// </summary>
        /// <param name="input">Instance of Query to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Query input)
        {
            if (input == null)
            {
                return false;
            }

            return
                Extern != null && Extern.Equals(input.Extern) &&
                (
                    _Query == input._Query ||
                    _Query != null && _Query.Equals(input._Query)
                ) &&
                (
                    Type == input.Type ||
                    Type.Equals(input.Type)
                ) &&
                (
                    Params == input.Params ||
                    Params != null &&
                    Params.SequenceEqual(input.Params)
                ) && Dialect != null && Dialect.Equals(input.Dialect) && (
                    Now == input.Now ||
                    Now != null && Now.Equals(input.Now)
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

                if (Extern != null)
                {
                    hashCode = hashCode * 59 + Extern.GetHashCode();
                }

                if (_Query != null)
                {
                    hashCode = hashCode * 59 + _Query.GetHashCode();
                }

                hashCode = hashCode * 59 + Type.GetHashCode();
                if (Params != null)
                {
                    hashCode = hashCode * 59 + Params.GetHashCode();
                }

                if (Dialect != null)
                {
                    hashCode = hashCode * 59 + Dialect.GetHashCode();
                }

                if (Now != null)
                {
                    hashCode = hashCode * 59 + Now.GetHashCode();
                }

                return hashCode;
            }
        }
    }
}