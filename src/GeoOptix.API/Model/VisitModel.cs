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
using System.Collections.Generic;
using GeoOptix.API.Interface;
using Newtonsoft.Json;

namespace GeoOptix.API.Model
{
    public class VisitModel : VisitSummaryModel, IHasFolderModels, IHasFileModels, IHasFieldFolderModels, IHasMetricSchemaModels
    {
        [JsonProperty("organizationName")]
        public string OrganizationName { get; private set; }

        [JsonProperty("siteName")]
        public string SiteName { get; private set; }

        [JsonProperty("hitchName")]
        public string HitchName { get; private set; }

        [JsonProperty("crewName")]
        public string CrewName { get; private set; }

        [JsonProperty("protocol")]
        public string Protocol { get; private set; }

        [JsonProperty("panel")]
        public string Panel { get; private set; }

        [JsonProperty("useOrder")]
        public int UseOrder { get; private set; }

        [JsonProperty("designUrl")]
        public string DesignUrl { get; private set; }

        [JsonProperty("tags")]
        public string[] Tags { get; private set; }

        [JsonProperty("folders")]
        public IEnumerable<FolderSummaryModel> Folders { get; set; }

        [JsonProperty("files")]
        public IEnumerable<FileSummaryModel> Files { get; set; }

        [JsonProperty("fieldFolders")]
        public IEnumerable<FolderSummaryModel> FieldFolders { get; set; }

        [JsonProperty("metricSchemas")]
        public IEnumerable<MetricSchemaModel> MetricSchemas { get; set; }

        [JsonProperty("measurements")]
        public IEnumerable<MeasurementSummaryModel> Measurements { get; set; }

        [JsonProperty("siteApiEndpoint")]
        public string SiteApiEndpoint { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [Obsolete] public VisitModel() { }

        public VisitModel(int id, string name, string url, string siteName, string siteUrl, string status, DateTime? lastMeasurementChange, int? sampleYear, DateTime? sampleDate, DateTime? lastUpdated, 
                          string organizationName, string hitchName, string crewName, string protocol, string panel, int useOrder, string designUrl, string[] tags, 
                          IEnumerable<MeasurementSummaryModel> measurements, string designSiteUrl, string category)
            : base(id, name, url, siteUrl, status, lastMeasurementChange, sampleYear, sampleDate, lastUpdated)
        {
            SiteName = siteName;
            OrganizationName = organizationName;
            HitchName = hitchName;
            CrewName = crewName;
            Protocol = protocol;
            Panel = panel;
            UseOrder = useOrder;
            DesignUrl = designUrl;
            Tags = tags;
            Measurements = measurements;
            SiteApiEndpoint = designSiteUrl;
            Category = category;
        }
    }
}