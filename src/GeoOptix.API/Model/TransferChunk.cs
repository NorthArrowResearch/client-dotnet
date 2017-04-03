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
    public class TransferChunk
    {
        public int chunk { get; set; }
        public int totalChunks { get; set; }
        public decimal chunkSize { get; set; }
        public decimal totalSize { get; set; }
        public string fileIdentifier { get; set; }
        public string fileName { get; set; }
        public string filePath { get; set; }
    }
}