﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Tarsasok_Asztali_Alkalmazas;
//
//    var boardGame = BoardGame.FromJson(jsonString);

namespace Tarsasok_Asztali_Alkalmazas
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class BoardGame
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("bg_name")]
        public string BgName { get; set; }

        [JsonProperty("min_players")]
        public long MinPlayers { get; set; }

        [JsonProperty("max_players")]
        public long MaxPlayers { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        public override string ToString()
        {
            return BgName;
        }
    }

    public partial class BoardGame
    {
        public static BoardGame[] FromJson(string json) => JsonConvert.DeserializeObject<BoardGame[]>(json, Tarsasok_Asztali_Alkalmazas.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this BoardGame[] self) => JsonConvert.SerializeObject(self, Tarsasok_Asztali_Alkalmazas.Converter.Settings);
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
