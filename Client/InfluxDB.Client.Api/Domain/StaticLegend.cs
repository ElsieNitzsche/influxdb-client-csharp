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
    /// StaticLegend represents the options specific to the static legend
    /// </summary>
    [DataContract]
    public partial class StaticLegend : IEquatable<StaticLegend>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StaticLegend" /> class.
        /// </summary>
        /// <param name="colorizeRows">colorizeRows.</param>
        /// <param name="heightRatio">heightRatio.</param>
        /// <param name="show">show.</param>
        /// <param name="opacity">opacity.</param>
        /// <param name="orientationThreshold">orientationThreshold.</param>
        /// <param name="valueAxis">valueAxis.</param>
        /// <param name="widthRatio">widthRatio.</param>
        public StaticLegend(bool? colorizeRows = default, float? heightRatio = default, bool? show = default,
            float? opacity = default, int? orientationThreshold = default, string valueAxis = default,
            float? widthRatio = default)
        {
            ColorizeRows = colorizeRows;
            HeightRatio = heightRatio;
            Show = show;
            Opacity = opacity;
            OrientationThreshold = orientationThreshold;
            ValueAxis = valueAxis;
            WidthRatio = widthRatio;
        }

        /// <summary>
        /// Gets or Sets ColorizeRows
        /// </summary>
        [DataMember(Name = "colorizeRows", EmitDefaultValue = false)]
        public bool? ColorizeRows { get; set; }

        /// <summary>
        /// Gets or Sets HeightRatio
        /// </summary>
        [DataMember(Name = "heightRatio", EmitDefaultValue = false)]
        public float? HeightRatio { get; set; }

        /// <summary>
        /// Gets or Sets Show
        /// </summary>
        [DataMember(Name = "show", EmitDefaultValue = false)]
        public bool? Show { get; set; }

        /// <summary>
        /// Gets or Sets Opacity
        /// </summary>
        [DataMember(Name = "opacity", EmitDefaultValue = false)]
        public float? Opacity { get; set; }

        /// <summary>
        /// Gets or Sets OrientationThreshold
        /// </summary>
        [DataMember(Name = "orientationThreshold", EmitDefaultValue = false)]
        public int? OrientationThreshold { get; set; }

        /// <summary>
        /// Gets or Sets ValueAxis
        /// </summary>
        [DataMember(Name = "valueAxis", EmitDefaultValue = false)]
        public string ValueAxis { get; set; }

        /// <summary>
        /// Gets or Sets WidthRatio
        /// </summary>
        [DataMember(Name = "widthRatio", EmitDefaultValue = false)]
        public float? WidthRatio { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StaticLegend {\n");
            sb.Append("  ColorizeRows: ").Append(ColorizeRows).Append("\n");
            sb.Append("  HeightRatio: ").Append(HeightRatio).Append("\n");
            sb.Append("  Show: ").Append(Show).Append("\n");
            sb.Append("  Opacity: ").Append(Opacity).Append("\n");
            sb.Append("  OrientationThreshold: ").Append(OrientationThreshold).Append("\n");
            sb.Append("  ValueAxis: ").Append(ValueAxis).Append("\n");
            sb.Append("  WidthRatio: ").Append(WidthRatio).Append("\n");
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
            return Equals(input as StaticLegend);
        }

        /// <summary>
        /// Returns true if StaticLegend instances are equal
        /// </summary>
        /// <param name="input">Instance of StaticLegend to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StaticLegend input)
        {
            if (input == null)
            {
                return false;
            }

            return
                (
                    ColorizeRows == input.ColorizeRows ||
                    ColorizeRows != null && ColorizeRows.Equals(input.ColorizeRows)
                ) &&
                (
                    HeightRatio == input.HeightRatio ||
                    HeightRatio != null && HeightRatio.Equals(input.HeightRatio)
                ) &&
                (
                    Show == input.Show ||
                    Show != null && Show.Equals(input.Show)
                ) &&
                (
                    Opacity == input.Opacity ||
                    Opacity != null && Opacity.Equals(input.Opacity)
                ) &&
                (
                    OrientationThreshold == input.OrientationThreshold ||
                    OrientationThreshold != null && OrientationThreshold.Equals(input.OrientationThreshold)
                ) &&
                (
                    ValueAxis == input.ValueAxis ||
                    ValueAxis != null && ValueAxis.Equals(input.ValueAxis)
                ) &&
                (
                    WidthRatio == input.WidthRatio ||
                    WidthRatio != null && WidthRatio.Equals(input.WidthRatio)
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

                if (ColorizeRows != null)
                {
                    hashCode = hashCode * 59 + ColorizeRows.GetHashCode();
                }

                if (HeightRatio != null)
                {
                    hashCode = hashCode * 59 + HeightRatio.GetHashCode();
                }

                if (Show != null)
                {
                    hashCode = hashCode * 59 + Show.GetHashCode();
                }

                if (Opacity != null)
                {
                    hashCode = hashCode * 59 + Opacity.GetHashCode();
                }

                if (OrientationThreshold != null)
                {
                    hashCode = hashCode * 59 + OrientationThreshold.GetHashCode();
                }

                if (ValueAxis != null)
                {
                    hashCode = hashCode * 59 + ValueAxis.GetHashCode();
                }

                if (WidthRatio != null)
                {
                    hashCode = hashCode * 59 + WidthRatio.GetHashCode();
                }

                return hashCode;
            }
        }
    }
}