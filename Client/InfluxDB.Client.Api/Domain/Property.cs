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
    /// The value associated with a key
    /// </summary>
    [DataContract]
    public partial class Property : IEquatable<Property>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Property" /> class.
        /// </summary>
        /// <param name="type">Type of AST node.</param>
        /// <param name="key">key.</param>
        /// <param name="value">value.</param>
        public Property(string type = default, PropertyKey key = default, Expression value = default)
        {
            Type = type;
            Key = key;
            Value = value;
        }

        /// <summary>
        /// Type of AST node
        /// </summary>
        /// <value>Type of AST node</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name = "key", EmitDefaultValue = false)]
        [JsonConverter(typeof(PropertyKeyAdapter))]
        public PropertyKey Key { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        [JsonConverter(typeof(PropertyValueAdapter))]
        public Expression Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Property {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return Equals(input as Property);
        }

        /// <summary>
        /// Returns true if Property instances are equal
        /// </summary>
        /// <param name="input">Instance of Property to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Property input)
        {
            if (input == null)
            {
                return false;
            }

            return
            (
                Type == input.Type ||
                Type != null && Type.Equals(input.Type)
            ) && Key != null && Key.Equals(input.Key) && Value != null && Value.Equals(input.Value);
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

                if (Type != null)
                {
                    hashCode = hashCode * 59 + Type.GetHashCode();
                }

                if (Key != null)
                {
                    hashCode = hashCode * 59 + Key.GetHashCode();
                }

                if (Value != null)
                {
                    hashCode = hashCode * 59 + Value.GetHashCode();
                }

                return hashCode;
            }
        }

        public class PropertyKeyAdapter : JsonConverter
        {
            private static readonly Dictionary<string[], Type> Types =
                new Dictionary<string[], Type>(new Client.DiscriminatorComparer<string>())
                {
                    { new[] { "Identifier" }, typeof(Identifier) },
                    { new[] { "StringLiteral" }, typeof(StringLiteral) }
                };

            public override bool CanConvert(Type objectType)
            {
                return false;
            }

            public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            {
                serializer.Serialize(writer, value);
            }

            public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
                JsonSerializer serializer)
            {
                return Deserialize(reader, objectType, serializer);
            }

            private object Deserialize(JsonReader reader, Type objectType, JsonSerializer serializer)
            {
                switch (reader.TokenType)
                {
                    case JsonToken.StartObject:

                        var jObject = Newtonsoft.Json.Linq.JObject.Load(reader);

                        var discriminator = new[] { "type" }.Select(key => jObject[key].ToString()).ToArray();

                        Types.TryGetValue(discriminator, out var type);

                        return serializer.Deserialize(jObject.CreateReader(), type);

                    case JsonToken.StartArray:
                        return DeserializeArray(reader, objectType, serializer);

                    default:
                        return serializer.Deserialize(reader, objectType);
                }
            }

            private IList DeserializeArray(JsonReader reader, Type targetType, JsonSerializer serializer)
            {
                var elementType = targetType.GenericTypeArguments.FirstOrDefault();

                var list = (IList)Activator.CreateInstance(targetType);
                while (reader.Read() && reader.TokenType != JsonToken.EndArray)
                    list.Add(Deserialize(reader, elementType, serializer));

                return list;
            }
        }

        public class PropertyValueAdapter : JsonConverter
        {
            private static readonly Dictionary<string[], Type> Types =
                new Dictionary<string[], Type>(new Client.DiscriminatorComparer<string>())
                {
                    { new[] { "ArrayExpression" }, typeof(ArrayExpression) },
                    { new[] { "DictExpression" }, typeof(DictExpression) },
                    { new[] { "FunctionExpression" }, typeof(FunctionExpression) },
                    { new[] { "BinaryExpression" }, typeof(BinaryExpression) },
                    { new[] { "CallExpression" }, typeof(CallExpression) },
                    { new[] { "ConditionalExpression" }, typeof(ConditionalExpression) },
                    { new[] { "LogicalExpression" }, typeof(LogicalExpression) },
                    { new[] { "MemberExpression" }, typeof(MemberExpression) },
                    { new[] { "IndexExpression" }, typeof(IndexExpression) },
                    { new[] { "ObjectExpression" }, typeof(ObjectExpression) },
                    { new[] { "ParenExpression" }, typeof(ParenExpression) },
                    { new[] { "PipeExpression" }, typeof(PipeExpression) },
                    { new[] { "UnaryExpression" }, typeof(UnaryExpression) },
                    { new[] { "BooleanLiteral" }, typeof(BooleanLiteral) },
                    { new[] { "DateTimeLiteral" }, typeof(DateTimeLiteral) },
                    { new[] { "DurationLiteral" }, typeof(DurationLiteral) },
                    { new[] { "FloatLiteral" }, typeof(FloatLiteral) },
                    { new[] { "IntegerLiteral" }, typeof(IntegerLiteral) },
                    { new[] { "PipeLiteral" }, typeof(PipeLiteral) },
                    { new[] { "RegexpLiteral" }, typeof(RegexpLiteral) },
                    { new[] { "StringLiteral" }, typeof(StringLiteral) },
                    { new[] { "UnsignedIntegerLiteral" }, typeof(UnsignedIntegerLiteral) },
                    { new[] { "Identifier" }, typeof(Identifier) }
                };

            public override bool CanConvert(Type objectType)
            {
                return false;
            }

            public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            {
                serializer.Serialize(writer, value);
            }

            public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
                JsonSerializer serializer)
            {
                return Deserialize(reader, objectType, serializer);
            }

            private object Deserialize(JsonReader reader, Type objectType, JsonSerializer serializer)
            {
                switch (reader.TokenType)
                {
                    case JsonToken.StartObject:

                        var jObject = Newtonsoft.Json.Linq.JObject.Load(reader);

                        var discriminator = new[] { "type" }.Select(key => jObject[key].ToString()).ToArray();

                        Types.TryGetValue(discriminator, out var type);

                        return serializer.Deserialize(jObject.CreateReader(), type);

                    case JsonToken.StartArray:
                        return DeserializeArray(reader, objectType, serializer);

                    default:
                        return serializer.Deserialize(reader, objectType);
                }
            }

            private IList DeserializeArray(JsonReader reader, Type targetType, JsonSerializer serializer)
            {
                var elementType = targetType.GenericTypeArguments.FirstOrDefault();

                var list = (IList)Activator.CreateInstance(targetType);
                while (reader.Read() && reader.TokenType != JsonToken.EndArray)
                    list.Add(Deserialize(reader, elementType, serializer));

                return list;
            }
        }
    }
}