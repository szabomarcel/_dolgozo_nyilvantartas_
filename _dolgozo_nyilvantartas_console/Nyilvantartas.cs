﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Dolgozo;
//
//    var nyilvantartas = Nyilvantartas.FromJson(jsonString);

namespace Dolgozo
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Nyilvantartas
    {
        [JsonProperty("id")]
        public long NyilvantartaId { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string NyilvantartaName { get; set; }

        [JsonProperty("salary", NullValueHandling = NullValueHandling.Ignore)]
        public long? NyilvantartaSalary { get; set; }

        [JsonProperty("position", NullValueHandling = NullValueHandling.Ignore)]
        public string NyilvantartaPosition { get; set; }

        [JsonProperty("Id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("Name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("Salary", NullValueHandling = NullValueHandling.Ignore)]
        public long? Salary { get; set; }

        [JsonProperty("Position", NullValueHandling = NullValueHandling.Ignore)]
        public string Position { get; set; }
    }

    public partial class Nyilvantartas
    {
        public static Nyilvantartas[] FromJson(string json) => JsonConvert.DeserializeObject<Nyilvantartas[]>(json, Dolgozo.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Nyilvantartas[] self) => JsonConvert.SerializeObject(self, Dolgozo.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
