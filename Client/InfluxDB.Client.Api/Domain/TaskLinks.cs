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
    /// TaskLinks
    /// </summary>
    [DataContract]
    public partial class TaskLinks : IEquatable<TaskLinks>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskLinks" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public TaskLinks()
        {
        }

        /// <summary>
        /// URI of resource.
        /// </summary>
        /// <value>URI of resource.</value>
        [DataMember(Name = "self", EmitDefaultValue = false)]
        public string Self { get; private set; }

        /// <summary>
        /// URI of resource.
        /// </summary>
        /// <value>URI of resource.</value>
        [DataMember(Name = "owners", EmitDefaultValue = false)]
        public string Owners { get; private set; }

        /// <summary>
        /// URI of resource.
        /// </summary>
        /// <value>URI of resource.</value>
        [DataMember(Name = "members", EmitDefaultValue = false)]
        public string Members { get; private set; }

        /// <summary>
        /// URI of resource.
        /// </summary>
        /// <value>URI of resource.</value>
        [DataMember(Name = "runs", EmitDefaultValue = false)]
        public string Runs { get; private set; }

        /// <summary>
        /// URI of resource.
        /// </summary>
        /// <value>URI of resource.</value>
        [DataMember(Name = "logs", EmitDefaultValue = false)]
        public string Logs { get; private set; }

        /// <summary>
        /// URI of resource.
        /// </summary>
        /// <value>URI of resource.</value>
        [DataMember(Name = "labels", EmitDefaultValue = false)]
        public string Labels { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskLinks {\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
            sb.Append("  Owners: ").Append(Owners).Append("\n");
            sb.Append("  Members: ").Append(Members).Append("\n");
            sb.Append("  Runs: ").Append(Runs).Append("\n");
            sb.Append("  Logs: ").Append(Logs).Append("\n");
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
            return Equals(input as TaskLinks);
        }

        /// <summary>
        /// Returns true if TaskLinks instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskLinks input)
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
                    Owners == input.Owners ||
                    Owners != null && Owners.Equals(input.Owners)
                ) &&
                (
                    Members == input.Members ||
                    Members != null && Members.Equals(input.Members)
                ) &&
                (
                    Runs == input.Runs ||
                    Runs != null && Runs.Equals(input.Runs)
                ) &&
                (
                    Logs == input.Logs ||
                    Logs != null && Logs.Equals(input.Logs)
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

                if (Owners != null)
                {
                    hashCode = hashCode * 59 + Owners.GetHashCode();
                }

                if (Members != null)
                {
                    hashCode = hashCode * 59 + Members.GetHashCode();
                }

                if (Runs != null)
                {
                    hashCode = hashCode * 59 + Runs.GetHashCode();
                }

                if (Logs != null)
                {
                    hashCode = hashCode * 59 + Logs.GetHashCode();
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