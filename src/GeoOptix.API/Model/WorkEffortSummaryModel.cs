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
    public class WorkEffortSummaryModel : IHasUrl
    {
        [JsonProperty("id")]
        public int Id { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("desc")]
        public string Desc { get; private set; }

        [JsonProperty("startDate")]
        public DateTime? StartDate { get; private set; }

        [JsonProperty("organization")]
        public string Organization { get; private set; }

        [JsonProperty("crew")]
        public string Crew { get; private set; }

        [JsonProperty("durationDays")]
        public int? DurationDays { get; private set; }

        [JsonProperty("url")]
        public string Url { get; private set; }

        [JsonProperty("programUrl")]
        public string ProgramUrl { get; private set; }

        [JsonProperty("associatedVisitsUrl")]
        public string AssociatedVisitsUrl { get; private set; }

        [JsonProperty("objectType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ObjectType ObjectType
        {
            get { return ObjectType.WorkEffort; }
        }

        [Obsolete]
        public WorkEffortSummaryModel() { }

        public WorkEffortSummaryModel(int id, string name, string desc, DateTime? startDate, string organization, string crew, int? durationDays, string url, string programUrl, string associatedVisitsUrl)
        {
            Id = id;
            Name = name;
            Desc = desc;
            StartDate = startDate;
            Organization = organization;
            Crew = crew;
            DurationDays = durationDays;
            Url = url;
            ProgramUrl = programUrl;
            AssociatedVisitsUrl = associatedVisitsUrl;
        }
    }
}
