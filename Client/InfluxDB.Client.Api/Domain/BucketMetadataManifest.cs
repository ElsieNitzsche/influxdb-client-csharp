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
    /// BucketMetadataManifest
    /// </summary>
    [DataContract]
    public partial class BucketMetadataManifest : IEquatable<BucketMetadataManifest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BucketMetadataManifest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BucketMetadataManifest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BucketMetadataManifest" /> class.
        /// </summary>
        /// <param name="organizationID">organizationID (required).</param>
        /// <param name="organizationName">organizationName (required).</param>
        /// <param name="bucketID">bucketID (required).</param>
        /// <param name="bucketName">bucketName (required).</param>
        /// <param name="description">description.</param>
        /// <param name="defaultRetentionPolicy">defaultRetentionPolicy (required).</param>
        /// <param name="retentionPolicies">retentionPolicies (required).</param>
        public BucketMetadataManifest(string organizationID = default, string organizationName = default,
            string bucketID = default, string bucketName = default, string description = default,
            string defaultRetentionPolicy = default, List<RetentionPolicyManifest> retentionPolicies = default)
        {
            // to ensure "organizationID" is required (not null)
            if (organizationID == null)
            {
                throw new InvalidDataException(
                    "organizationID is a required property for BucketMetadataManifest and cannot be null");
            }

            OrganizationID = organizationID;
            // to ensure "organizationName" is required (not null)
            if (organizationName == null)
            {
                throw new InvalidDataException(
                    "organizationName is a required property for BucketMetadataManifest and cannot be null");
            }

            OrganizationName = organizationName;
            // to ensure "bucketID" is required (not null)
            if (bucketID == null)
            {
                throw new InvalidDataException(
                    "bucketID is a required property for BucketMetadataManifest and cannot be null");
            }

            BucketID = bucketID;
            // to ensure "bucketName" is required (not null)
            if (bucketName == null)
            {
                throw new InvalidDataException(
                    "bucketName is a required property for BucketMetadataManifest and cannot be null");
            }

            BucketName = bucketName;
            // to ensure "defaultRetentionPolicy" is required (not null)
            if (defaultRetentionPolicy == null)
            {
                throw new InvalidDataException(
                    "defaultRetentionPolicy is a required property for BucketMetadataManifest and cannot be null");
            }

            DefaultRetentionPolicy = defaultRetentionPolicy;
            // to ensure "retentionPolicies" is required (not null)
            if (retentionPolicies == null)
            {
                throw new InvalidDataException(
                    "retentionPolicies is a required property for BucketMetadataManifest and cannot be null");
            }

            RetentionPolicies = retentionPolicies;
            Description = description;
        }

        /// <summary>
        /// Gets or Sets OrganizationID
        /// </summary>
        [DataMember(Name = "organizationID", EmitDefaultValue = false)]
        public string OrganizationID { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationName
        /// </summary>
        [DataMember(Name = "organizationName", EmitDefaultValue = false)]
        public string OrganizationName { get; set; }

        /// <summary>
        /// Gets or Sets BucketID
        /// </summary>
        [DataMember(Name = "bucketID", EmitDefaultValue = false)]
        public string BucketID { get; set; }

        /// <summary>
        /// Gets or Sets BucketName
        /// </summary>
        [DataMember(Name = "bucketName", EmitDefaultValue = false)]
        public string BucketName { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets DefaultRetentionPolicy
        /// </summary>
        [DataMember(Name = "defaultRetentionPolicy", EmitDefaultValue = false)]
        public string DefaultRetentionPolicy { get; set; }

        /// <summary>
        /// Gets or Sets RetentionPolicies
        /// </summary>
        [DataMember(Name = "retentionPolicies", EmitDefaultValue = false)]
        public List<RetentionPolicyManifest> RetentionPolicies { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BucketMetadataManifest {\n");
            sb.Append("  OrganizationID: ").Append(OrganizationID).Append("\n");
            sb.Append("  OrganizationName: ").Append(OrganizationName).Append("\n");
            sb.Append("  BucketID: ").Append(BucketID).Append("\n");
            sb.Append("  BucketName: ").Append(BucketName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DefaultRetentionPolicy: ").Append(DefaultRetentionPolicy).Append("\n");
            sb.Append("  RetentionPolicies: ").Append(RetentionPolicies).Append("\n");
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
            return Equals(input as BucketMetadataManifest);
        }

        /// <summary>
        /// Returns true if BucketMetadataManifest instances are equal
        /// </summary>
        /// <param name="input">Instance of BucketMetadataManifest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BucketMetadataManifest input)
        {
            if (input == null)
            {
                return false;
            }

            return
                (
                    OrganizationID == input.OrganizationID ||
                    OrganizationID != null && OrganizationID.Equals(input.OrganizationID)
                ) &&
                (
                    OrganizationName == input.OrganizationName ||
                    OrganizationName != null && OrganizationName.Equals(input.OrganizationName)
                ) &&
                (
                    BucketID == input.BucketID ||
                    BucketID != null && BucketID.Equals(input.BucketID)
                ) &&
                (
                    BucketName == input.BucketName ||
                    BucketName != null && BucketName.Equals(input.BucketName)
                ) &&
                (
                    Description == input.Description ||
                    Description != null && Description.Equals(input.Description)
                ) &&
                (
                    DefaultRetentionPolicy == input.DefaultRetentionPolicy ||
                    DefaultRetentionPolicy != null && DefaultRetentionPolicy.Equals(input.DefaultRetentionPolicy)
                ) &&
                (
                    RetentionPolicies == input.RetentionPolicies ||
                    RetentionPolicies != null &&
                    RetentionPolicies.SequenceEqual(input.RetentionPolicies)
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

                if (OrganizationID != null)
                {
                    hashCode = hashCode * 59 + OrganizationID.GetHashCode();
                }

                if (OrganizationName != null)
                {
                    hashCode = hashCode * 59 + OrganizationName.GetHashCode();
                }

                if (BucketID != null)
                {
                    hashCode = hashCode * 59 + BucketID.GetHashCode();
                }

                if (BucketName != null)
                {
                    hashCode = hashCode * 59 + BucketName.GetHashCode();
                }

                if (Description != null)
                {
                    hashCode = hashCode * 59 + Description.GetHashCode();
                }

                if (DefaultRetentionPolicy != null)
                {
                    hashCode = hashCode * 59 + DefaultRetentionPolicy.GetHashCode();
                }

                if (RetentionPolicies != null)
                {
                    hashCode = hashCode * 59 + RetentionPolicies.GetHashCode();
                }

                return hashCode;
            }
        }
    }
}