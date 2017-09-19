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
using GeoOptix.API.Model;
using System.IO;
using System.Collections.Generic;

namespace GeoOptix.API.Sample
{
    class Program
    {
        private static Dictionary<string, string> variables = DotEnvFile.DotEnvFile.LoadFile(@".env");
        private static int CHUNK_SIZE = (int)Math.Pow(20,6); // 20Mb default
        private static string API_BASE_URL = variables["API_BASE_URL"];
        private static string KEYSTONE_URL = variables["KEYSTONE_URL"];
        private static string KEYSTONE_USER = variables["KEYSTONE_USER"];
        private static string KEYSTONE_PASS = variables["KEYSTONE_PASS"];
        private static string KEYSTONE_CLIENT_ID = variables["KEYSTONE_CLIENT_ID"];
        private static string KEYSTONE_CLIENT_SECRET = variables["KEYSTONE_CLIENT_SECRET"];

        private static string filepath = variables["ZIPFILE"];
        private static FileInfo fileinfo = new FileInfo(filepath);
        private static int vid = Convert.ToInt16(variables["VISITID"]);

        static void Main(string[] args)
        {
            ApiHelper helper = new ApiHelper(API_BASE_URL, KEYSTONE_URL, KEYSTONE_CLIENT_ID, KEYSTONE_CLIENT_SECRET, KEYSTONE_USER, KEYSTONE_PASS);

            // First we go see if there is a file there already. with GET/visits/1/fieldFolders/Topo/files/Filename.zip
            var hashcode = ApiHelper.GetFileHashCode(filepath);
            var transferDetail = new TransferDetail
            {
                datasetName = ApiHelper.FieldFolderType.Topo,
                visitId = vid,
                manifest = new[] { new TransferManifestFile { hash = hashcode, name = fileinfo.Name }, }
            };

            var response = helper.CreateTransfer(transferDetail);
            var transfer = response.Payload;
            var resp = helper.UploadTransferFile(transfer.id, fileinfo.FullName, CHUNK_SIZE);

        }
    }
}
