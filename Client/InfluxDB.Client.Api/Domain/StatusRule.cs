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
    /// StatusRule
    /// </summary>
    [DataContract]
    public partial class StatusRule : IEquatable<StatusRule>
    {
        /// <summary>
        /// Gets or Sets CurrentLevel
        /// </summary>
        [DataMember(Name = "currentLevel", EmitDefaultValue = false)]
        public RuleStatusLevel? CurrentLevel { get; set; }

        /// <summary>
        /// Gets or Sets PreviousLevel
        /// </summary>
        [DataMember(Name = "previousLevel", EmitDefaultValue = false)]
        public RuleStatusLevel? PreviousLevel { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="StatusRule" /> class.
        /// </summary>
        /// <param name="currentLevel">currentLevel.</param>
        /// <param name="previousLevel">previousLevel.</param>
        /// <param name="count">count.</param>
        /// <param name="period">period.</param>
        public StatusRule(RuleStatusLevel? currentLevel = default, RuleStatusLevel? previousLevel = default,
            int? count = default, string period = default)
        {
            CurrentLevel = currentLevel;
            PreviousLevel = previousLevel;
            Count = count;
            Period = period;
        }


        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name = "count", EmitDefaultValue = false)]
        public int? Count { get; set; }

        /// <summary>
        /// Gets or Sets Period
        /// </summary>
        [DataMember(Name = "period", EmitDefaultValue = false)]
        public string Period { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatusRule {\n");
            sb.Append("  CurrentLevel: ").Append(CurrentLevel).Append("\n");
            sb.Append("  PreviousLevel: ").Append(PreviousLevel).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
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
            return Equals(input as StatusRule);
        }

        /// <summary>
        /// Returns true if StatusRule instances are equal
        /// </summary>
        /// <param name="input">Instance of StatusRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StatusRule input)
        {
            if (input == null)
            {
                return false;
            }

            return
                (
                    CurrentLevel == input.CurrentLevel ||
                    CurrentLevel.Equals(input.CurrentLevel)
                ) &&
                (
                    PreviousLevel == input.PreviousLevel ||
                    PreviousLevel.Equals(input.PreviousLevel)
                ) &&
                (
                    Count == input.Count ||
                    Count != null && Count.Equals(input.Count)
                ) &&
                (
                    Period == input.Period ||
                    Period != null && Period.Equals(input.Period)
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

                hashCode = hashCode * 59 + CurrentLevel.GetHashCode();
                hashCode = hashCode * 59 + PreviousLevel.GetHashCode();
                if (Count != null)
                {
                    hashCode = hashCode * 59 + Count.GetHashCode();
                }

                if (Period != null)
                {
                    hashCode = hashCode * 59 + Period.GetHashCode();
                }

                return hashCode;
            }
        }
    }
}