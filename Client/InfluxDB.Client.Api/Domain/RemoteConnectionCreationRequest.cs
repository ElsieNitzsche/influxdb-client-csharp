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
    /// RemoteConnectionCreationRequest
    /// </summary>
    [DataContract]
    public partial class RemoteConnectionCreationRequest : IEquatable<RemoteConnectionCreationRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoteConnectionCreationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RemoteConnectionCreationRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoteConnectionCreationRequest" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="description">description.</param>
        /// <param name="orgID">orgID (required).</param>
        /// <param name="remoteURL">remoteURL (required).</param>
        /// <param name="remoteAPIToken">remoteAPIToken (required).</param>
        /// <param name="remoteOrgID">remoteOrgID (required).</param>
        /// <param name="allowInsecureTLS">allowInsecureTLS (required) (default to false).</param>
        public RemoteConnectionCreationRequest(string name = default, string description = default,
            string orgID = default, string remoteURL = default, string remoteAPIToken = default,
            string remoteOrgID = default, bool? allowInsecureTLS = false)
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException(
                    "name is a required property for RemoteConnectionCreationRequest and cannot be null");
            }

            Name = name;
            // to ensure "orgID" is required (not null)
            if (orgID == null)
            {
                throw new InvalidDataException(
                    "orgID is a required property for RemoteConnectionCreationRequest and cannot be null");
            }

            OrgID = orgID;
            // to ensure "remoteURL" is required (not null)
            if (remoteURL == null)
            {
                throw new InvalidDataException(
                    "remoteURL is a required property for RemoteConnectionCreationRequest and cannot be null");
            }

            RemoteURL = remoteURL;
            // to ensure "remoteAPIToken" is required (not null)
            if (remoteAPIToken == null)
            {
                throw new InvalidDataException(
                    "remoteAPIToken is a required property for RemoteConnectionCreationRequest and cannot be null");
            }

            RemoteAPIToken = remoteAPIToken;
            // to ensure "remoteOrgID" is required (not null)
            if (remoteOrgID == null)
            {
                throw new InvalidDataException(
                    "remoteOrgID is a required property for RemoteConnectionCreationRequest and cannot be null");
            }

            RemoteOrgID = remoteOrgID;
            // to ensure "allowInsecureTLS" is required (not null)
            if (allowInsecureTLS == null)
            {
                throw new InvalidDataException(
                    "allowInsecureTLS is a required property for RemoteConnectionCreationRequest and cannot be null");
            }

            AllowInsecureTLS = allowInsecureTLS;
            Description = description;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets OrgID
        /// </summary>
        [DataMember(Name = "orgID", EmitDefaultValue = false)]
        public string OrgID { get; set; }

        /// <summary>
        /// Gets or Sets RemoteURL
        /// </summary>
        [DataMember(Name = "remoteURL", EmitDefaultValue = false)]
        public string RemoteURL { get; set; }

        /// <summary>
        /// Gets or Sets RemoteAPIToken
        /// </summary>
        [DataMember(Name = "remoteAPIToken", EmitDefaultValue = false)]
        public string RemoteAPIToken { get; set; }

        /// <summary>
        /// Gets or Sets RemoteOrgID
        /// </summary>
        [DataMember(Name = "remoteOrgID", EmitDefaultValue = false)]
        public string RemoteOrgID { get; set; }

        /// <summary>
        /// Gets or Sets AllowInsecureTLS
        /// </summary>
        [DataMember(Name = "allowInsecureTLS", EmitDefaultValue = false)]
        public bool? AllowInsecureTLS { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RemoteConnectionCreationRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  OrgID: ").Append(OrgID).Append("\n");
            sb.Append("  RemoteURL: ").Append(RemoteURL).Append("\n");
            sb.Append("  RemoteAPIToken: ").Append(RemoteAPIToken).Append("\n");
            sb.Append("  RemoteOrgID: ").Append(RemoteOrgID).Append("\n");
            sb.Append("  AllowInsecureTLS: ").Append(AllowInsecureTLS).Append("\n");
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
            return Equals(input as RemoteConnectionCreationRequest);
        }

        /// <summary>
        /// Returns true if RemoteConnectionCreationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of RemoteConnectionCreationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RemoteConnectionCreationRequest input)
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
                    OrgID == input.OrgID ||
                    OrgID != null && OrgID.Equals(input.OrgID)
                ) &&
                (
                    RemoteURL == input.RemoteURL ||
                    RemoteURL != null && RemoteURL.Equals(input.RemoteURL)
                ) &&
                (
                    RemoteAPIToken == input.RemoteAPIToken ||
                    RemoteAPIToken != null && RemoteAPIToken.Equals(input.RemoteAPIToken)
                ) &&
                (
                    RemoteOrgID == input.RemoteOrgID ||
                    RemoteOrgID != null && RemoteOrgID.Equals(input.RemoteOrgID)
                ) &&
                (
                    AllowInsecureTLS == input.AllowInsecureTLS ||
                    AllowInsecureTLS != null && AllowInsecureTLS.Equals(input.AllowInsecureTLS)
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

                if (OrgID != null)
                {
                    hashCode = hashCode * 59 + OrgID.GetHashCode();
                }

                if (RemoteURL != null)
                {
                    hashCode = hashCode * 59 + RemoteURL.GetHashCode();
                }

                if (RemoteAPIToken != null)
                {
                    hashCode = hashCode * 59 + RemoteAPIToken.GetHashCode();
                }

                if (RemoteOrgID != null)
                {
                    hashCode = hashCode * 59 + RemoteOrgID.GetHashCode();
                }

                if (AllowInsecureTLS != null)
                {
                    hashCode = hashCode * 59 + AllowInsecureTLS.GetHashCode();
                }

                return hashCode;
            }
        }
    }
}