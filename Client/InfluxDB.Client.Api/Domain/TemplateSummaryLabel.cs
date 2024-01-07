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
    /// TemplateSummaryLabel
    /// </summary>
    [DataContract]
    public partial class TemplateSummaryLabel : IEquatable<TemplateSummaryLabel>
    {
        /// <summary>
        /// Gets or Sets Kind
        /// </summary>
        [DataMember(Name = "kind", EmitDefaultValue = false)]
        public TemplateKind? Kind { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateSummaryLabel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="orgID">orgID.</param>
        /// <param name="kind">kind.</param>
        /// <param name="templateMetaName">templateMetaName.</param>
        /// <param name="name">name.</param>
        /// <param name="properties">properties.</param>
        /// <param name="envReferences">envReferences.</param>
        public TemplateSummaryLabel(string id = default, string orgID = default, TemplateKind? kind = default,
            string templateMetaName = default, string name = default,
            TemplateSummaryLabelProperties properties = default, List<object> envReferences = default)
        {
            Id = id;
            OrgID = orgID;
            Kind = kind;
            TemplateMetaName = templateMetaName;
            Name = name;
            Properties = properties;
            EnvReferences = envReferences;
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
        /// Gets or Sets TemplateMetaName
        /// </summary>
        [DataMember(Name = "templateMetaName", EmitDefaultValue = false)]
        public string TemplateMetaName { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name = "properties", EmitDefaultValue = false)]
        public TemplateSummaryLabelProperties Properties { get; set; }

        /// <summary>
        /// Gets or Sets EnvReferences
        /// </summary>
        [DataMember(Name = "envReferences", EmitDefaultValue = false)]
        public List<object> EnvReferences { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateSummaryLabel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OrgID: ").Append(OrgID).Append("\n");
            sb.Append("  Kind: ").Append(Kind).Append("\n");
            sb.Append("  TemplateMetaName: ").Append(TemplateMetaName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  EnvReferences: ").Append(EnvReferences).Append("\n");
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
            return Equals(input as TemplateSummaryLabel);
        }

        /// <summary>
        /// Returns true if TemplateSummaryLabel instances are equal
        /// </summary>
        /// <param name="input">Instance of TemplateSummaryLabel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateSummaryLabel input)
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
                    Kind == input.Kind ||
                    Kind.Equals(input.Kind)
                ) &&
                (
                    TemplateMetaName == input.TemplateMetaName ||
                    TemplateMetaName != null && TemplateMetaName.Equals(input.TemplateMetaName)
                ) &&
                (
                    Name == input.Name ||
                    Name != null && Name.Equals(input.Name)
                ) && Properties != null && Properties.Equals(input.Properties) && (
                    EnvReferences == input.EnvReferences ||
                    EnvReferences != null &&
                    EnvReferences.SequenceEqual(input.EnvReferences)
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

                hashCode = hashCode * 59 + Kind.GetHashCode();
                if (TemplateMetaName != null)
                {
                    hashCode = hashCode * 59 + TemplateMetaName.GetHashCode();
                }

                if (Name != null)
                {
                    hashCode = hashCode * 59 + Name.GetHashCode();
                }

                if (Properties != null)
                {
                    hashCode = hashCode * 59 + Properties.GetHashCode();
                }

                if (EnvReferences != null)
                {
                    hashCode = hashCode * 59 + EnvReferences.GetHashCode();
                }

                return hashCode;
            }
        }
    }
}