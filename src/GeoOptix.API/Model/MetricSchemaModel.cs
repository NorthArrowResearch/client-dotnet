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
using Newtonsoft.Json.Converters;

namespace GeoOptix.API.Model
{
    public class MetricSchemaModel : IHasUrl
    {
        public const string SCHEMA_PUBLISHED_STRING = "SchemaPublished";

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("locked")]
        public bool Locked { get; set; }

        [JsonProperty("published")]
        public bool Published { get; set; }

        [JsonProperty("objectType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ObjectType ObjectType { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("attributes")]
        public List<MetricAttributeModel> Attributes { get; set; }

        [JsonProperty("instances")]
        public List<MetricInstanceSummaryModel> Instances { get; set; }


        public MetricSchemaModel(string name, bool locked, bool published, ObjectType objectType, string url, List<MetricAttributeModel> attributes, List<MetricInstanceSummaryModel> instances)
        {
            Name = name;
            Locked = locked;
            Published = published;
            ObjectType = objectType;
            Url = url;
            Attributes = attributes;
            Instances = instances;
        }
    }
}