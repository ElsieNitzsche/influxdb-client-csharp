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
    /// Defines BuilderAggregateFunctionType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BuilderAggregateFunctionType
    {
        /// <summary>
        /// Enum Filter for value: filter
        /// </summary>
        [EnumMember(Value = "filter")] Filter = 1,

        /// <summary>
        /// Enum Group for value: group
        /// </summary>
        [EnumMember(Value = "group")] Group = 2
    }
}