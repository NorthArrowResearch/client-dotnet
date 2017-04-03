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

namespace GeoOptix.API.Sample
{
    class Program
    {
        private static string _apiUrl = "https://qa.champmonitoring.org/api/v1";
        private static string _authUrl = "https://qa.keystone.sitkatech.com/core/connect/token";

        private static string _clientID = "<ClientID>";
        private static string _clientSecret = "<ClientSecret>";

        static void Main(string[] args)
        {
            ApiHelper helper = new ApiHelper(_apiUrl, _authUrl, _clientID, _clientSecret, "<UserName>", "<Password>");

            var response = helper.Get<ProgramModel>("program", "champ");

            Console.WriteLine(response.Payload.FullName);
        }
    }
}
