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
using JsonSubTypes;
using OpenAPIDateConverter = InfluxDB.Client.Api.Client.OpenAPIDateConverter;

namespace InfluxDB.Client.Api.Domain
{
    /// <summary>
    /// NotificationEndpoint
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(SlackNotificationEndpoint), "slack")]
    [JsonSubtypes.KnownSubType(typeof(PagerDutyNotificationEndpoint), "pagerduty")]
    [JsonSubtypes.KnownSubType(typeof(HTTPNotificationEndpoint), "http")]
    [JsonSubtypes.KnownSubType(typeof(TelegramNotificationEndpoint), "telegram")]
    public partial class NotificationEndpoint : NotificationEndpointDiscriminator, IEquatable<NotificationEndpoint>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationEndpoint" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NotificationEndpoint()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationEndpoint" /> class.
        /// </summary>
        public NotificationEndpoint(string id = default, string orgID = default, string userID = default,
            string description = default, string name = default, StatusEnum? status = StatusEnum.Active,
            List<Label> labels = default, NotificationEndpointBaseLinks links = default,
            NotificationEndpointType type = default) : base(id, orgID, userID, description, name, status, labels, links,
            type)
        {
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotificationEndpoint {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return Equals(input as NotificationEndpoint);
        }

        /// <summary>
        /// Returns true if NotificationEndpoint instances are equal
        /// </summary>
        /// <param name="input">Instance of NotificationEndpoint to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotificationEndpoint input)
        {
            if (input == null)
            {
                return false;
            }

            return base.Equals(input);
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = base.GetHashCode();

                return hashCode;
            }
        }
    }
}