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
using Newtonsoft.Json;

namespace GeoOptix.API.Model
{
    public class FolderModel : FolderSummaryModel
    {
        [JsonProperty("dateCreated")]
        public DateTime DateCreated { get; set; }

        [JsonProperty("dateModified")]
        public DateTime DateModified { get; set; }

        [JsonProperty("published")]
        public bool Published { get; set; }

        [JsonProperty("locked")]
        public bool Locked { get; set; }

        [JsonProperty("files")]
        public IEnumerable<FileSummaryModel> Files { get; set; }


        public FolderModel(string name, string url, string parentUrl, ObjectType objectType, DateTime dateCreated, DateTime dateModified, bool published, bool locked, IEnumerable<FileSummaryModel> files) 
            : base(name, url, parentUrl, objectType)
        {
            DateCreated = dateCreated;
            DateModified = dateModified;
            Published = published;
            Locked = locked;
            Files = files;
        }
    }    
    
}