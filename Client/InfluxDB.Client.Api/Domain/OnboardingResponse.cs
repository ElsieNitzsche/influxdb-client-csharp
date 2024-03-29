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
    /// OnboardingResponse
    /// </summary>
    [DataContract]
    public partial class OnboardingResponse : IEquatable<OnboardingResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OnboardingResponse" /> class.
        /// </summary>
        /// <param name="user">user.</param>
        /// <param name="org">org.</param>
        /// <param name="bucket">bucket.</param>
        /// <param name="auth">auth.</param>
        public OnboardingResponse(User user = default, Organization org = default, Bucket bucket = default,
            Authorization auth = default)
        {
            User = user;
            Org = org;
            Bucket = bucket;
            Auth = auth;
        }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name = "user", EmitDefaultValue = false)]
        public User User { get; set; }

        /// <summary>
        /// Gets or Sets Org
        /// </summary>
        [DataMember(Name = "org", EmitDefaultValue = false)]
        public Organization Org { get; set; }

        /// <summary>
        /// Gets or Sets Bucket
        /// </summary>
        [DataMember(Name = "bucket", EmitDefaultValue = false)]
        public Bucket Bucket { get; set; }

        /// <summary>
        /// Gets or Sets Auth
        /// </summary>
        [DataMember(Name = "auth", EmitDefaultValue = false)]
        public Authorization Auth { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OnboardingResponse {\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Org: ").Append(Org).Append("\n");
            sb.Append("  Bucket: ").Append(Bucket).Append("\n");
            sb.Append("  Auth: ").Append(Auth).Append("\n");
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
            return Equals(input as OnboardingResponse);
        }

        /// <summary>
        /// Returns true if OnboardingResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of OnboardingResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OnboardingResponse input)
        {
            if (input == null)
            {
                return false;
            }

            return
                User != null && User.Equals(input.User) && Org != null && Org.Equals(input.Org) && Bucket != null &&
                Bucket.Equals(input.Bucket) && Auth != null && Auth.Equals(input.Auth);
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

                if (User != null)
                {
                    hashCode = hashCode * 59 + User.GetHashCode();
                }

                if (Org != null)
                {
                    hashCode = hashCode * 59 + Org.GetHashCode();
                }

                if (Bucket != null)
                {
                    hashCode = hashCode * 59 + Bucket.GetHashCode();
                }

                if (Auth != null)
                {
                    hashCode = hashCode * 59 + Auth.GetHashCode();
                }

                return hashCode;
            }
        }
    }
}