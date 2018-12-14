using System;
using System.Net.Http;

namespace DDNS.Core.ServiceProviders
{
    public class Internetbs : IServiceProvider
    {
        private string host;
        private string user;
        private string password;

        public Internetbs(string host, string user, string password)
        {
            this.host = host;
            this.user = user;
            this.password = password;
        }

        public async void Update()
        {
            HttpClient client = new HttpClient();
            string requestUrl = string.Format(
                "https://dyndns.topdns.com/update?hostname={0}&username={1}&password={2}",
                host, user, password);
            var result = await client.GetStringAsync(requestUrl);
            if (!result.StartsWith("good"))
                throw new Exception(string.Format("Update DDNS fail. Server returned {0}", result));
        }
    }
}
