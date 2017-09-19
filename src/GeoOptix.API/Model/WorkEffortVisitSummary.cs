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
    public class WorkEffortVisitSummaryModel : VisitSummaryModel
    {
        [JsonProperty("protocol")]
        public string Protocol { get; private set; }

        [JsonProperty("datasetStatuses")]
        public IEnumerable<VisitDatasetStatus> DatasetStatuses { get; private set; }

        [JsonProperty("streamName")]
        public string StreamName { get; private set; }

        [Obsolete]
        public WorkEffortVisitSummaryModel() { }

        public WorkEffortVisitSummaryModel(int id, string name, string url, string siteName, string siteUrl, string status, DateTime? lastMeasurementChange, int? sampleYear, DateTime? sampleDate, DateTime? lastUpdated, string protocol, string scoutingDocumentsUrl, IEnumerable<VisitDatasetStatus> datasetStatuses, string streamName)
            : base(id, name, url, siteName, siteUrl, status, lastMeasurementChange, sampleYear, sampleDate, lastUpdated, scoutingDocumentsUrl)
        {
            Protocol = protocol;
            DatasetStatuses = datasetStatuses;
            StreamName = streamName;
        } 
    }


    public class VisitDatasetStatus
    {
        [JsonProperty("datasetId")]
        public int DatasetId { get; private set; }

        [JsonProperty("datasetTypeId")]
        public int DatasetTypeId { get; private set; }

        [JsonProperty("datasetType")]
        public string DatasetType { get; private set; }

        [JsonProperty("datasetStatusId")]
        public int DatasetStatusId { get; private set; }

        [JsonProperty("datasetStatus")]
        public string DatasetStatus { get; private set; }

        [JsonProperty("datasetSubStatusId")]
        public int DatasetSubStatusId { get; private set; }

        [JsonProperty("datasetSubStatus")]
        public string DatasetSubStatus { get; private set; }

        [Obsolete]
        public VisitDatasetStatus() { }

        public VisitDatasetStatus(int datasetId, int datasetTypeId, string datasetType, int datasetStatusId, string datasetStatus, int datasetSubStatusId, string datasetSubStatus)
        {
            DatasetId = datasetId;
            DatasetTypeId = datasetTypeId;
            DatasetType = datasetType;
            DatasetStatusId = datasetStatusId;
            DatasetStatus = datasetStatus;
            DatasetSubStatusId = datasetSubStatusId;
            DatasetSubStatus = datasetSubStatus;
        }
    }
}
