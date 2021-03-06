// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using CodeBeautify;
//
//    var welcome3 = Welcome3.FromJson(jsonString);

namespace CodeBeautify
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Welcome3
    {
        [JsonProperty("took")]
        public long Took { get; set; }

        [JsonProperty("timed_out")]
        public bool TimedOut { get; set; }

        [JsonProperty("_shards")]
        public Shards Shards { get; set; }

        [JsonProperty("hits")]
        public Hits Hits { get; set; }
    }

    public partial class Hits
    {
        [JsonProperty("total")]
        public Total Total { get; set; }

        [JsonProperty("max_score")]
        public double MaxScore { get; set; }

        [JsonProperty("hits")]
        public Hit[] HitsHits { get; set; }
    }

    public partial class Hit
    {
        [JsonProperty("_index")]
        public Index Index { get; set; }

        [JsonProperty("_type")]
        public HitType Type { get; set; }

        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("_score")]
        public double Score { get; set; }

        [JsonProperty("_source")]
        public Source Source { get; set; }
    }

    public partial class Source
    {
        [JsonProperty("type")]
        public TypeEnum Type { get; set; }

        [JsonProperty("package_attr_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PackageAttrName { get; set; }

        [JsonProperty("package_attr_name_reverse", NullValueHandling = NullValueHandling.Ignore)]
        public string PackageAttrNameReverse { get; set; }

        [JsonProperty("package_attr_name_query", NullValueHandling = NullValueHandling.Ignore)]
        public string[] PackageAttrNameQuery { get; set; }

        [JsonProperty("package_attr_name_query_reverse", NullValueHandling = NullValueHandling.Ignore)]
        public string[] PackageAttrNameQueryReverse { get; set; }

        [JsonProperty("package_attr_set", NullValueHandling = NullValueHandling.Ignore)]
        public string PackageAttrSet { get; set; }

        [JsonProperty("package_attr_set_reverse", NullValueHandling = NullValueHandling.Ignore)]
        public string PackageAttrSetReverse { get; set; }

        [JsonProperty("package_pname", NullValueHandling = NullValueHandling.Ignore)]
        public string PackagePname { get; set; }

        [JsonProperty("package_pname_reverse", NullValueHandling = NullValueHandling.Ignore)]
        public string PackagePnameReverse { get; set; }

        [JsonProperty("package_pversion", NullValueHandling = NullValueHandling.Ignore)]
        public string PackagePversion { get; set; }

        [JsonProperty("package_platforms", NullValueHandling = NullValueHandling.Ignore)]
        public string[] PackagePlatforms { get; set; }

        [JsonProperty("package_outputs", NullValueHandling = NullValueHandling.Ignore)]
        public PackageOutput[] PackageOutputs { get; set; }

        [JsonProperty("package_license", NullValueHandling = NullValueHandling.Ignore)]
        public PackageLicense[] PackageLicense { get; set; }

        [JsonProperty("package_license_set", NullValueHandling = NullValueHandling.Ignore)]
        public string[] PackageLicenseSet { get; set; }

        [JsonProperty("package_maintainers", NullValueHandling = NullValueHandling.Ignore)]
        public PackageMaintainer[] PackageMaintainers { get; set; }

        [JsonProperty("package_maintainers_set", NullValueHandling = NullValueHandling.Ignore)]
        public string[] PackageMaintainersSet { get; set; }

        [JsonProperty("package_description")]
        public string PackageDescription { get; set; }

        [JsonProperty("package_description_reverse")]
        public string PackageDescriptionReverse { get; set; }

        [JsonProperty("package_longDescription")]
        public string PackageLongDescription { get; set; }

        [JsonProperty("package_longDescription_reverse")]
        public string PackageLongDescriptionReverse { get; set; }

        [JsonProperty("package_hydra")]
        public object PackageHydra { get; set; }

        [JsonProperty("package_system", NullValueHandling = NullValueHandling.Ignore)]
        public PackageSystem? PackageSystem { get; set; }

        [JsonProperty("package_homepage", NullValueHandling = NullValueHandling.Ignore)]
        public Uri[] PackageHomepage { get; set; }

        [JsonProperty("package_position", NullValueHandling = NullValueHandling.Ignore)]
        public string PackagePosition { get; set; }

        [JsonProperty("option_source", NullValueHandling = NullValueHandling.Ignore)]
        public string OptionSource { get; set; }

        [JsonProperty("option_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OptionName { get; set; }

        [JsonProperty("option_name_reverse", NullValueHandling = NullValueHandling.Ignore)]
        public string OptionNameReverse { get; set; }

        [JsonProperty("option_name_query", NullValueHandling = NullValueHandling.Ignore)]
        public string[] OptionNameQuery { get; set; }

        [JsonProperty("option_name_query_reverse", NullValueHandling = NullValueHandling.Ignore)]
        public string[] OptionNameQueryReverse { get; set; }

        [JsonProperty("option_description", NullValueHandling = NullValueHandling.Ignore)]
        public string OptionDescription { get; set; }

        [JsonProperty("option_description_reverse", NullValueHandling = NullValueHandling.Ignore)]
        public string OptionDescriptionReverse { get; set; }

        [JsonProperty("option_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OptionType { get; set; }

        [JsonProperty("option_default", NullValueHandling = NullValueHandling.Ignore)]
        public string OptionDefault { get; set; }

        [JsonProperty("option_example")]
        public string OptionExample { get; set; }

        [JsonProperty("option_flake")]
        public object OptionFlake { get; set; }
    }

    public partial class PackageLicense
    {
        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }
    }

    public partial class PackageMaintainer
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("github")]
        public string Github { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public partial class Total
    {
        [JsonProperty("value")]
        public long Value { get; set; }

        [JsonProperty("relation")]
        public string Relation { get; set; }
    }

    public partial class Shards
    {
        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("successful")]
        public long Successful { get; set; }

        [JsonProperty("skipped")]
        public long Skipped { get; set; }

        [JsonProperty("failed")]
        public long Failed { get; set; }
    }

    public enum Index { Nixos2621112128D0Aa28Edef51Fd8Fef38B132Ffc0155595Df };

    public enum PackageOutput { Bin, Out };

    public enum PackageSystem { X8664Linux };

    public enum TypeEnum { Option, Package };

    public enum HitType { Doc };

    public partial class Welcome3
    {
        public static Welcome3 FromJson(string json) => JsonConvert.DeserializeObject<Welcome3>(json, CodeBeautify.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Welcome3 self) => JsonConvert.SerializeObject(self, CodeBeautify.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                IndexConverter.Singleton,
                PackageOutputConverter.Singleton,
                PackageSystemConverter.Singleton,
                TypeEnumConverter.Singleton,
                HitTypeConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class IndexConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Index) || t == typeof(Index?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "nixos-26-21.11-2128d0aa28edef51fd8fef38b132ffc0155595df")
            {
                return Index.Nixos2621112128D0Aa28Edef51Fd8Fef38B132Ffc0155595Df;
            }
            throw new Exception("Cannot unmarshal type Index");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Index)untypedValue;
            if (value == Index.Nixos2621112128D0Aa28Edef51Fd8Fef38B132Ffc0155595Df)
            {
                serializer.Serialize(writer, "nixos-26-21.11-2128d0aa28edef51fd8fef38b132ffc0155595df");
                return;
            }
            throw new Exception("Cannot marshal type Index");
        }

        public static readonly IndexConverter Singleton = new IndexConverter();
    }

    internal class PackageOutputConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PackageOutput) || t == typeof(PackageOutput?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "bin":
                    return PackageOutput.Bin;
                case "out":
                    return PackageOutput.Out;
            }
            throw new Exception("Cannot unmarshal type PackageOutput");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (PackageOutput)untypedValue;
            switch (value)
            {
                case PackageOutput.Bin:
                    serializer.Serialize(writer, "bin");
                    return;
                case PackageOutput.Out:
                    serializer.Serialize(writer, "out");
                    return;
            }
            throw new Exception("Cannot marshal type PackageOutput");
        }

        public static readonly PackageOutputConverter Singleton = new PackageOutputConverter();
    }

    internal class PackageSystemConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PackageSystem) || t == typeof(PackageSystem?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "x86_64-linux")
            {
                return PackageSystem.X8664Linux;
            }
            throw new Exception("Cannot unmarshal type PackageSystem");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (PackageSystem)untypedValue;
            if (value == PackageSystem.X8664Linux)
            {
                serializer.Serialize(writer, "x86_64-linux");
                return;
            }
            throw new Exception("Cannot marshal type PackageSystem");
        }

        public static readonly PackageSystemConverter Singleton = new PackageSystemConverter();
    }

    internal class TypeEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TypeEnum) || t == typeof(TypeEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "option":
                    return TypeEnum.Option;
                case "package":
                    return TypeEnum.Package;
            }
            throw new Exception("Cannot unmarshal type TypeEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TypeEnum)untypedValue;
            switch (value)
            {
                case TypeEnum.Option:
                    serializer.Serialize(writer, "option");
                    return;
                case TypeEnum.Package:
                    serializer.Serialize(writer, "package");
                    return;
            }
            throw new Exception("Cannot marshal type TypeEnum");
        }

        public static readonly TypeEnumConverter Singleton = new TypeEnumConverter();
    }

    internal class HitTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(HitType) || t == typeof(HitType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "_doc")
            {
                return HitType.Doc;
            }
            throw new Exception("Cannot unmarshal type HitType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (HitType)untypedValue;
            if (value == HitType.Doc)
            {
                serializer.Serialize(writer, "_doc");
                return;
            }
            throw new Exception("Cannot marshal type HitType");
        }

        public static readonly HitTypeConverter Singleton = new HitTypeConverter();
    }
}
