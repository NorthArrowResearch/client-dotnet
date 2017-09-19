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
using System.Collections.Generic;

namespace GeoOptix.API.Sample
{
    class Program
    {
        private static Dictionary<string, string> variables = DotEnvFile.DotEnvFile.LoadFile(@".env");

        private static string API_BASE_URL = variables["API_BASE_URL"];
        private static string KEYSTONE_URL = variables["KEYSTONE_URL"];
        private static string KEYSTONE_USER = variables["KEYSTONE_USER"];
        private static string KEYSTONE_PASS = variables["KEYSTONE_PASS"];
        private static string KEYSTONE_CLIENT_ID = variables["KEYSTONE_CLIENT_ID"];
        private static string KEYSTONE_CLIENT_SECRET = variables["KEYSTONE_CLIENT_SECRET"];

        static void Main(string[] args)
        {
            ApiHelper helper = new ApiHelper(API_BASE_URL, KEYSTONE_URL, KEYSTONE_CLIENT_ID, KEYSTONE_CLIENT_SECRET, KEYSTONE_USER, KEYSTONE_PASS);

            var response = helper.Get<ProgramModel>("program", "champ");

            Console.WriteLine(String.Format("Response: {0}", response.Payload.FullName));
        }
    }
}
