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
    /// TemplateSummaryDiffNotificationRules
    /// </summary>
    [DataContract]
    public partial class TemplateSummaryDiffNotificationRules : IEquatable<TemplateSummaryDiffNotificationRules>
    {
        /// <summary>
        /// Gets or Sets Kind
        /// </summary>
        [DataMember(Name = "kind", EmitDefaultValue = false)]
        public TemplateKind? Kind { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateSummaryDiffNotificationRules" /> class.
        /// </summary>
        /// <param name="kind">kind.</param>
        /// <param name="stateStatus">stateStatus.</param>
        /// <param name="id">id.</param>
        /// <param name="templateMetaName">templateMetaName.</param>
        /// <param name="_new">_new.</param>
        /// <param name="old">old.</param>
        public TemplateSummaryDiffNotificationRules(TemplateKind? kind = default, string stateStatus = default,
            string id = default, string templateMetaName = default,
            TemplateSummaryDiffNotificationRulesNewOld _new = default,
            TemplateSummaryDiffNotificationRulesNewOld old = default)
        {
            Kind = kind;
            StateStatus = stateStatus;
            Id = id;
            TemplateMetaName = templateMetaName;
            New = _new;
            Old = old;
        }


        /// <summary>
        /// Gets or Sets StateStatus
        /// </summary>
        [DataMember(Name = "stateStatus", EmitDefaultValue = false)]
        public string StateStatus { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets TemplateMetaName
        /// </summary>
        [DataMember(Name = "templateMetaName", EmitDefaultValue = false)]
        public string TemplateMetaName { get; set; }

        /// <summary>
        /// Gets or Sets New
        /// </summary>
        [DataMember(Name = "new", EmitDefaultValue = false)]
        public TemplateSummaryDiffNotificationRulesNewOld New { get; set; }

        /// <summary>
        /// Gets or Sets Old
        /// </summary>
        [DataMember(Name = "old", EmitDefaultValue = false)]
        public TemplateSummaryDiffNotificationRulesNewOld Old { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateSummaryDiffNotificationRules {\n");
            sb.Append("  Kind: ").Append(Kind).Append("\n");
            sb.Append("  StateStatus: ").Append(StateStatus).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TemplateMetaName: ").Append(TemplateMetaName).Append("\n");
            sb.Append("  New: ").Append(New).Append("\n");
            sb.Append("  Old: ").Append(Old).Append("\n");
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
            return Equals(input as TemplateSummaryDiffNotificationRules);
        }

        /// <summary>
        /// Returns true if TemplateSummaryDiffNotificationRules instances are equal
        /// </summary>
        /// <param name="input">Instance of TemplateSummaryDiffNotificationRules to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateSummaryDiffNotificationRules input)
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
                    StateStatus == input.StateStatus ||
                    StateStatus != null && StateStatus.Equals(input.StateStatus)
                ) &&
                (
                    Id == input.Id ||
                    Id != null && Id.Equals(input.Id)
                ) &&
                (
                    TemplateMetaName == input.TemplateMetaName ||
                    TemplateMetaName != null && TemplateMetaName.Equals(input.TemplateMetaName)
                ) && New != null && New.Equals(input.New) && Old != null && Old.Equals(input.Old);
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
                if (StateStatus != null)
                {
                    hashCode = hashCode * 59 + StateStatus.GetHashCode();
                }

                if (Id != null)
                {
                    hashCode = hashCode * 59 + Id.GetHashCode();
                }

                if (TemplateMetaName != null)
                {
                    hashCode = hashCode * 59 + TemplateMetaName.GetHashCode();
                }

                if (New != null)
                {
                    hashCode = hashCode * 59 + New.GetHashCode();
                }

                if (Old != null)
                {
                    hashCode = hashCode * 59 + Old.GetHashCode();
                }

                return hashCode;
            }
        }
    }
}