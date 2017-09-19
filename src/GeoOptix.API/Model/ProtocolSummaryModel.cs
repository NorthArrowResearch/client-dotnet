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
    public class ProtocolSummaryModel 
    {
        [JsonProperty("id")]
        public int Id { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; private set; }

        [JsonProperty("description")]
        public string Description { get; private set; }

        [JsonProperty("documentFolder")]
        public string DocumentFolder { get; private set; }

        [JsonProperty("url")]
        public string Url { get; private set; }

        [JsonProperty("objectType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ObjectType ObjectType { get { return ObjectType.Protocol; } }
       
        [Obsolete]
        public ProtocolSummaryModel(){ }

        public ProtocolSummaryModel(int id, string name, string displayName, string description, string documentFolder, string url)
        {
            Id = id;
            Name = name;
            DisplayName = displayName;
            Description = description;
            DocumentFolder = documentFolder;
            Url = url;
        }
    }
}
