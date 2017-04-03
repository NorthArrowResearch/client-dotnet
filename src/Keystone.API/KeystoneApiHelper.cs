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

using IdentityModel.Client;

namespace Keystone.API
{
    public class KeystoneApiHelper
    {
        private readonly string _authUrl;
        private string ClientIdentifier { get; set; }
        private string ClientSecret { get; set; }
        
        public KeystoneApiHelper(string authUrl, string clientIdentifier, string clientSecret)
        {
            _authUrl = authUrl;
            ClientIdentifier = clientIdentifier;
            ClientSecret = clientSecret;
        }

        public TokenResponse RequestToken(string username, string password)
        {
            TokenClient client;
            if (!string.IsNullOrWhiteSpace(ClientIdentifier) && !string.IsNullOrWhiteSpace(ClientSecret))
            {
                client = new TokenClient(_authUrl, ClientIdentifier, ClientSecret);
            }
            else
            {
                client = new TokenClient(_authUrl);
            }

            return client.RequestResourceOwnerPasswordAsync(username, password, "keystone openid profile").Result;
        }
    }
}