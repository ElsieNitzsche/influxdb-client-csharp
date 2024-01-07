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
    /// PostUser
    /// </summary>
    [DataContract]
    public partial class PostUser : IEquatable<PostUser>
    {
        /// <summary>
        /// If inactive the user is inactive.
        /// </summary>
        /// <value>If inactive the user is inactive.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Active for value: active
            /// </summary>
            [EnumMember(Value = "active")] Active = 1,

            /// <summary>
            /// Enum Inactive for value: inactive
            /// </summary>
            [EnumMember(Value = "inactive")] Inactive = 2
        }

        /// <summary>
        /// If inactive the user is inactive.
        /// </summary>
        /// <value>If inactive the user is inactive.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostUser" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PostUser()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostUser" /> class.
        /// </summary>
        /// <param name="oauthID">oauthID.</param>
        /// <param name="name">name (required).</param>
        /// <param name="status">If inactive the user is inactive. (default to StatusEnum.Active).</param>
        public PostUser(string oauthID = default, string name = default, StatusEnum? status = StatusEnum.Active)
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for PostUser and cannot be null");
            }

            Name = name;
            OauthID = oauthID;
            // use default value if no "status" provided
            if (status == null)
            {
                Status = StatusEnum.Active;
            }
            else
            {
                Status = status;
            }
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; private set; }

        /// <summary>
        /// Gets or Sets OauthID
        /// </summary>
        [DataMember(Name = "oauthID", EmitDefaultValue = false)]
        public string OauthID { get; set; }

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
            sb.Append("class PostUser {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OauthID: ").Append(OauthID).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return Equals(input as PostUser);
        }

        /// <summary>
        /// Returns true if PostUser instances are equal
        /// </summary>
        /// <param name="input">Instance of PostUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostUser input)
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
                    OauthID == input.OauthID ||
                    OauthID != null && OauthID.Equals(input.OauthID)
                ) &&
                (
                    Name == input.Name ||
                    Name != null && Name.Equals(input.Name)
                ) &&
                (
                    Status == input.Status ||
                    Status.Equals(input.Status)
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

                if (OauthID != null)
                {
                    hashCode = hashCode * 59 + OauthID.GetHashCode();
                }

                if (Name != null)
                {
                    hashCode = hashCode * 59 + Name.GetHashCode();
                }

                hashCode = hashCode * 59 + Status.GetHashCode();
                return hashCode;
            }
        }
    }
}