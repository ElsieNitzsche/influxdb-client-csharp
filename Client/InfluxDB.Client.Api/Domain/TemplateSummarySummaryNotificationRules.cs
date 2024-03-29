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
    /// TemplateSummarySummaryNotificationRules
    /// </summary>
    [DataContract]
    public partial class TemplateSummarySummaryNotificationRules : IEquatable<TemplateSummarySummaryNotificationRules>
    {
        /// <summary>
        /// Gets or Sets Kind
        /// </summary>
        [DataMember(Name = "kind", EmitDefaultValue = false)]
        public TemplateKind? Kind { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateSummarySummaryNotificationRules" /> class.
        /// </summary>
        /// <param name="kind">kind.</param>
        /// <param name="templateMetaName">templateMetaName.</param>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="endpointTemplateMetaName">endpointTemplateMetaName.</param>
        /// <param name="endpointID">endpointID.</param>
        /// <param name="endpointType">endpointType.</param>
        /// <param name="every">every.</param>
        /// <param name="offset">offset.</param>
        /// <param name="messageTemplate">messageTemplate.</param>
        /// <param name="status">status.</param>
        /// <param name="statusRules">statusRules.</param>
        /// <param name="tagRules">tagRules.</param>
        /// <param name="labelAssociations">labelAssociations.</param>
        /// <param name="envReferences">envReferences.</param>
        public TemplateSummarySummaryNotificationRules(TemplateKind? kind = default, string templateMetaName = default,
            string name = default, string description = default, string endpointTemplateMetaName = default,
            string endpointID = default, string endpointType = default, string every = default, string offset = default,
            string messageTemplate = default, string status = default,
            List<TemplateSummarySummaryStatusRules> statusRules = default,
            List<TemplateSummarySummaryTagRules> tagRules = default,
            List<TemplateSummaryLabel> labelAssociations = default, List<object> envReferences = default)
        {
            Kind = kind;
            TemplateMetaName = templateMetaName;
            Name = name;
            Description = description;
            EndpointTemplateMetaName = endpointTemplateMetaName;
            EndpointID = endpointID;
            EndpointType = endpointType;
            Every = every;
            Offset = offset;
            MessageTemplate = messageTemplate;
            Status = status;
            StatusRules = statusRules;
            TagRules = tagRules;
            LabelAssociations = labelAssociations;
            EnvReferences = envReferences;
        }


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
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets EndpointTemplateMetaName
        /// </summary>
        [DataMember(Name = "endpointTemplateMetaName", EmitDefaultValue = false)]
        public string EndpointTemplateMetaName { get; set; }

        /// <summary>
        /// Gets or Sets EndpointID
        /// </summary>
        [DataMember(Name = "endpointID", EmitDefaultValue = false)]
        public string EndpointID { get; set; }

        /// <summary>
        /// Gets or Sets EndpointType
        /// </summary>
        [DataMember(Name = "endpointType", EmitDefaultValue = false)]
        public string EndpointType { get; set; }

        /// <summary>
        /// Gets or Sets Every
        /// </summary>
        [DataMember(Name = "every", EmitDefaultValue = false)]
        public string Every { get; set; }

        /// <summary>
        /// Gets or Sets Offset
        /// </summary>
        [DataMember(Name = "offset", EmitDefaultValue = false)]
        public string Offset { get; set; }

        /// <summary>
        /// Gets or Sets MessageTemplate
        /// </summary>
        [DataMember(Name = "messageTemplate", EmitDefaultValue = false)]
        public string MessageTemplate { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets StatusRules
        /// </summary>
        [DataMember(Name = "statusRules", EmitDefaultValue = false)]
        public List<TemplateSummarySummaryStatusRules> StatusRules { get; set; }

        /// <summary>
        /// Gets or Sets TagRules
        /// </summary>
        [DataMember(Name = "tagRules", EmitDefaultValue = false)]
        public List<TemplateSummarySummaryTagRules> TagRules { get; set; }

        /// <summary>
        /// Gets or Sets LabelAssociations
        /// </summary>
        [DataMember(Name = "labelAssociations", EmitDefaultValue = false)]
        public List<TemplateSummaryLabel> LabelAssociations { get; set; }

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
            sb.Append("class TemplateSummarySummaryNotificationRules {\n");
            sb.Append("  Kind: ").Append(Kind).Append("\n");
            sb.Append("  TemplateMetaName: ").Append(TemplateMetaName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  EndpointTemplateMetaName: ").Append(EndpointTemplateMetaName).Append("\n");
            sb.Append("  EndpointID: ").Append(EndpointID).Append("\n");
            sb.Append("  EndpointType: ").Append(EndpointType).Append("\n");
            sb.Append("  Every: ").Append(Every).Append("\n");
            sb.Append("  Offset: ").Append(Offset).Append("\n");
            sb.Append("  MessageTemplate: ").Append(MessageTemplate).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusRules: ").Append(StatusRules).Append("\n");
            sb.Append("  TagRules: ").Append(TagRules).Append("\n");
            sb.Append("  LabelAssociations: ").Append(LabelAssociations).Append("\n");
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
            return Equals(input as TemplateSummarySummaryNotificationRules);
        }

        /// <summary>
        /// Returns true if TemplateSummarySummaryNotificationRules instances are equal
        /// </summary>
        /// <param name="input">Instance of TemplateSummarySummaryNotificationRules to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateSummarySummaryNotificationRules input)
        {
            if (input == null)
            {
                return false;
            }

            return
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
                ) &&
                (
                    Description == input.Description ||
                    Description != null && Description.Equals(input.Description)
                ) &&
                (
                    EndpointTemplateMetaName == input.EndpointTemplateMetaName ||
                    EndpointTemplateMetaName != null && EndpointTemplateMetaName.Equals(input.EndpointTemplateMetaName)
                ) &&
                (
                    EndpointID == input.EndpointID ||
                    EndpointID != null && EndpointID.Equals(input.EndpointID)
                ) &&
                (
                    EndpointType == input.EndpointType ||
                    EndpointType != null && EndpointType.Equals(input.EndpointType)
                ) &&
                (
                    Every == input.Every ||
                    Every != null && Every.Equals(input.Every)
                ) &&
                (
                    Offset == input.Offset ||
                    Offset != null && Offset.Equals(input.Offset)
                ) &&
                (
                    MessageTemplate == input.MessageTemplate ||
                    MessageTemplate != null && MessageTemplate.Equals(input.MessageTemplate)
                ) &&
                (
                    Status == input.Status ||
                    Status != null && Status.Equals(input.Status)
                ) &&
                (
                    StatusRules == input.StatusRules ||
                    StatusRules != null &&
                    StatusRules.SequenceEqual(input.StatusRules)
                ) &&
                (
                    TagRules == input.TagRules ||
                    TagRules != null &&
                    TagRules.SequenceEqual(input.TagRules)
                ) &&
                (
                    LabelAssociations == input.LabelAssociations ||
                    LabelAssociations != null &&
                    LabelAssociations.SequenceEqual(input.LabelAssociations)
                ) &&
                (
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

                hashCode = hashCode * 59 + Kind.GetHashCode();
                if (TemplateMetaName != null)
                {
                    hashCode = hashCode * 59 + TemplateMetaName.GetHashCode();
                }

                if (Name != null)
                {
                    hashCode = hashCode * 59 + Name.GetHashCode();
                }

                if (Description != null)
                {
                    hashCode = hashCode * 59 + Description.GetHashCode();
                }

                if (EndpointTemplateMetaName != null)
                {
                    hashCode = hashCode * 59 + EndpointTemplateMetaName.GetHashCode();
                }

                if (EndpointID != null)
                {
                    hashCode = hashCode * 59 + EndpointID.GetHashCode();
                }

                if (EndpointType != null)
                {
                    hashCode = hashCode * 59 + EndpointType.GetHashCode();
                }

                if (Every != null)
                {
                    hashCode = hashCode * 59 + Every.GetHashCode();
                }

                if (Offset != null)
                {
                    hashCode = hashCode * 59 + Offset.GetHashCode();
                }

                if (MessageTemplate != null)
                {
                    hashCode = hashCode * 59 + MessageTemplate.GetHashCode();
                }

                if (Status != null)
                {
                    hashCode = hashCode * 59 + Status.GetHashCode();
                }

                if (StatusRules != null)
                {
                    hashCode = hashCode * 59 + StatusRules.GetHashCode();
                }

                if (TagRules != null)
                {
                    hashCode = hashCode * 59 + TagRules.GetHashCode();
                }

                if (LabelAssociations != null)
                {
                    hashCode = hashCode * 59 + LabelAssociations.GetHashCode();
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