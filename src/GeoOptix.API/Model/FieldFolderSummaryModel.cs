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

using GeoOptix.API.Interface;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace GeoOptix.API.Model
{
    public class FieldFolderSummaryModel : IHasUrl
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("parentUrl")]
        public string ParentUrl { get; set; }


        [JsonProperty("objectType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ObjectType ObjectType { get; set; }


        [JsonProperty("datasetTypeId")]
        public int FolderTypeID { get; set; }
        public int? NotMeasuredReasonID { get; set; }
        public string NotMeasuredReason { get; set; }
        public string NotMeasuredReasonNote { get; set; }

        public FieldFolderSummaryModel(string name, int folderTypeID, string url, string parentUrl, ObjectType objectType, int? notMeasuredReasonID, string notMeasuredReason, string notMeasuredReasonNote)
        {
            Name = name;
            Url = url;
            ParentUrl = parentUrl;
            ObjectType = objectType;
            FolderTypeID = folderTypeID;
            NotMeasuredReasonID = notMeasuredReasonID;
            NotMeasuredReason = notMeasuredReason;
            NotMeasuredReasonNote = notMeasuredReasonNote;
        }

    }
}