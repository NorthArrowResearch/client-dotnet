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

using System.Collections.Generic;
using GeoOptix.API.Interface;
using Newtonsoft.Json;

namespace GeoOptix.API.Model
{
    public class SiteModel : SiteSummaryModel, IHasFolderModels, IHasFileModels, IHasMetricSchemaModels
    {
        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("datum")]
        public string Datum { get { return "WGS84"; } }

        [JsonProperty("visits")]
        public List<VisitSummaryModel> Visits { get; set; }

        [JsonProperty("folders")]
        public IEnumerable<FolderSummaryModel> Folders { get; set; }

        [JsonProperty("files")]
        public IEnumerable<FileSummaryModel> Files { get; set; }

        [JsonProperty("metricSchemas")]
        public IEnumerable<MetricSchemaModel> MetricSchemas { get; set; }

        [JsonProperty("utmzone")]
        public string UtmZone { get; set; }

        // We need a parameterless constructor, sadly
        public SiteModel()
        {
            Visits = new List<VisitSummaryModel>();
        }


        public SiteModel(int id, string name, string url, string watershedUrl, string latitude, string longitude, string locale, string utmZone)
        {
            Visits = new List<VisitSummaryModel>();

            Id = id;
            Name = name;
            Url = url;
            WatershedUrl = watershedUrl;
            Latitude = latitude;
            Longitude = longitude;
            Locale = locale;
            UtmZone = utmZone;
        }
    }
}