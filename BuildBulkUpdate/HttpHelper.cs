using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BuildBulkUpdate
{
    /// <summary>
    /// Never create a class like this outside of a console app!!
    /// </summary>
    public static class HttpHelper
    {
        private static HttpClient _client;

        static HttpHelper()
        {
            var handler = new HttpClientHandler() {
                UseDefaultCredentials = true,
                UseProxy = true,
                Proxy = new WebProxy("http://www-proxy.sandvik.com:8080", true, new string[0], CredentialCache.DefaultCredentials),
            };

            _client = new HttpClient(handler, true);
        }

        public static string Get(string url)
        {
            url += "?api-version=2.0";
            Console.WriteLine("GET " + url);

            var result = _client.GetAsync(url).Result;
            if (result.StatusCode != HttpStatusCode.OK)
            {
                throw new Exception(result.ToString());
            }

            return result.Content.ReadAsStringAsync().Result;
        }

        internal static string Put(string url, string data)
        {
            //url = "http://requestb.in/1i7la9u1";

            url += "?api-version=2.0";
            Console.WriteLine("PUT " + url);

            var ms = new MemoryStream();
            var sw = new StreamWriter(ms, Encoding.UTF8);
            sw.Write(data);
            sw.Flush();

            ms.Position = 0;
            var content = new StreamContent(ms);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json") { CharSet = "utf-8" };

            var result = _client.PutAsync(url, content).Result;
            var rcontent = result.Content.ReadAsStringAsync().Result;
            if (result.StatusCode != HttpStatusCode.OK)
            {
                throw new Exception(result.ToString() + rcontent);
            }

            return rcontent;
        }
    }
}
