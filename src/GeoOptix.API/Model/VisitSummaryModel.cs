/* 
   Copyright 2017 Sitka Technology Group LLC

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/
using System;
using GeoOptix.API.Interface;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace GeoOptix.API.Model
{
    public class VisitSummaryModel : IHasUrl
    {
        [JsonProperty("id")]
        public int Id { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("url")]
        public string Url { get; private set; }

        [JsonProperty("siteName")]
        public string SiteName { get; private set; }

        [JsonProperty("siteUrl")]
        public string SiteUrl { get; private set; }

        [JsonProperty("lastMeasurementChange")]
        public DateTime? LastMeasurementChange { get; private set; }

        [JsonProperty("status")]
        public string Status { get; private set; }

        [JsonProperty("sampleYear")]
        public int? SampleYear { get; private set; }

        [JsonProperty("sampleDate")]
        public DateTime? SampleDate { get; private set; }

        [JsonProperty("lastUpdated")]
        public DateTime? LastUpdated { get; private set; }

        [JsonProperty("objectType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ObjectType ObjectType
        {
            get { return ObjectType.Visit; }
        }

        [JsonProperty("scoutingDocumentsUrl")]
        public string ScoutingDocumentsURL { get; set; }

        [Obsolete] public VisitSummaryModel() { }

        public VisitSummaryModel(int id, string name, string url, string siteName, string siteUrl, string status, DateTime? lastMeasurementChange, int? sampleYear, DateTime? sampleDate, DateTime? lastUpdated, string scoutingDocumentsUrl)
        {
            Id = id;
            Name = name;
            Url = url;
            LastMeasurementChange = lastMeasurementChange;
            SiteName = siteName;
            SiteUrl = siteUrl;
            Status = status;
            SampleYear = sampleYear;
            SampleDate = sampleDate;
            LastUpdated = lastUpdated;
            ScoutingDocumentsURL = scoutingDocumentsUrl;
        }
    }
}