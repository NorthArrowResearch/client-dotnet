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

namespace GeoOptix.API.Model
{
    public class TransferSummary : ITransferBase
    {
        public int id { get; set; }
        public int visitId { get; set; }
        public string datasetName { get; set; }
        public string url { get; set; }
        public string fileUrl { get; set; }
        public string closeUrl { get; set; }

        public string[] manifest { get; set; }
    }
}