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
    public class ProgramModel : ProgramSummaryModel, IHasFolderModels, IHasFileModels, IHasMetricSchemaModels
    {
        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("watersheds")]
        public List<WatershedSummaryModel> Watersheds { get; set; }

        [JsonProperty("folders")]
        public IEnumerable<FolderSummaryModel> Folders { get; set; }

        [JsonProperty("files")]
        public IEnumerable<FileSummaryModel> Files { get; set; }

        [JsonProperty("metricSchemas")]
        public IEnumerable<MetricSchemaModel> MetricSchemas { get; set; }

        [JsonProperty("programApiEndpoint")]
        public string ProgramApiEndpoint { get; set; }

        public ProgramModel()
        {
            Watersheds = new List<WatershedSummaryModel>();
        }
    }
}