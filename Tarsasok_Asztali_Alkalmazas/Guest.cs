﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Tarsasok_Asztali_Alkalmazas;
//
//    var guest = Guest.FromJson(jsonString);

namespace Tarsasok_Asztali_Alkalmazas
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    // Guest osztály, vendékek tulajdonságai
    public partial class Guest
    {
        public Guest(long id, string gUsername, string gPassword, string gName, string gEmail, string gPhoneNumber, DateTimeOffset createdAt, DateTimeOffset updatedAt)
        {
            Id = id;
            GUsername = gUsername;
            GPassword = gPassword;
            GName = gName;
            GEmail = gEmail;
            GPhoneNumber = gPhoneNumber;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("g_username")]
        public string GUsername { get; set; }

        [JsonProperty("g_password")]
        public string GPassword { get; set; }

        [JsonProperty("g_name")]
        public string GName { get; set; }

        [JsonProperty("g_email")]
        public string GEmail { get; set; }

        [JsonProperty("g_phone_number")]
        public string GPhoneNumber { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }


    }

    public partial class Guest
    {
        public static Guest[] FromJson(string json) => JsonConvert.DeserializeObject<Guest[]>(json, Tarsasok_Asztali_Alkalmazas.Converter.Settings);
    }

    public static class SerializeGuest
    {
        public static string ToJson(this Guest[] self) => JsonConvert.SerializeObject(self, Tarsasok_Asztali_Alkalmazas.Converter.Settings);
    }

    internal static class ConverterGuest
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
