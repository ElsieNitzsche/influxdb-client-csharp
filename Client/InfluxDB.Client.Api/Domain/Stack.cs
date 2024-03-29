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
    /// Stack
    /// </summary>
    [DataContract]
    public partial class Stack : IEquatable<Stack>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Stack" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="orgID">orgID.</param>
        /// <param name="events">events.</param>
        public Stack(string id = default, string orgID = default, List<StackEvents> events = default)
        {
            Id = id;
            OrgID = orgID;
            Events = events;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets OrgID
        /// </summary>
        [DataMember(Name = "orgID", EmitDefaultValue = false)]
        public string OrgID { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        public DateTime? CreatedAt { get; private set; }

        /// <summary>
        /// Gets or Sets Events
        /// </summary>
        [DataMember(Name = "events", EmitDefaultValue = false)]
        public List<StackEvents> Events { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Stack {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OrgID: ").Append(OrgID).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
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
            return Equals(input as Stack);
        }

        /// <summary>
        /// Returns true if Stack instances are equal
        /// </summary>
        /// <param name="input">Instance of Stack to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Stack input)
        {
            if (input == null)
            {
                return false;
            }

            return
                (
                    Id == input.Id ||
                    Id != null && Id.Equals(input.Id)
                ) &&
                (
                    OrgID == input.OrgID ||
                    OrgID != null && OrgID.Equals(input.OrgID)
                ) &&
                (
                    CreatedAt == input.CreatedAt ||
                    CreatedAt != null && CreatedAt.Equals(input.CreatedAt)
                ) &&
                (
                    Events == input.Events ||
                    Events != null &&
                    Events.SequenceEqual(input.Events)
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

                if (Id != null)
                {
                    hashCode = hashCode * 59 + Id.GetHashCode();
                }

                if (OrgID != null)
                {
                    hashCode = hashCode * 59 + OrgID.GetHashCode();
                }

                if (CreatedAt != null)
                {
                    hashCode = hashCode * 59 + CreatedAt.GetHashCode();
                }

                if (Events != null)
                {
                    hashCode = hashCode * 59 + Events.GetHashCode();
                }

                return hashCode;
            }
        }
    }
}