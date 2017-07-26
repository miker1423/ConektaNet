using Microsoft.Extensions.Options;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

using ConektaNet.Models.Configuration;

namespace ConektaNet.Services
{
    public class HttpHelper : IHttpHelper
    {
        private static HttpClient _client;
        private static string Version;
        private static string Language;
        private static string ApiKey;

        public HttpHelper(IOptions<Configuration> options)
        {
            _client = new HttpClient()
            {
                BaseAddress = new Uri(options.Value.BaseUrl)
            };

            var normalizedVersion = options.Value.ApiVersion.Replace(".", "");
            if(int.Parse(normalizedVersion) < 200)
            {
                throw new Exception("Not supported version");
            }
            else
            {
                Version = options.Value.ApiVersion;
                string VersionHeader = "application/vnd.conekta-v" + Version + "+json";

                Language = options.Value.Locale;

                ApiKey = Convert.ToBase64String(Encoding.UTF8.GetBytes(options.Value.ApiKey));

                _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(VersionHeader));
                _client.DefaultRequestHeaders.AcceptLanguage.Add(new StringWithQualityHeaderValue(Language));
                _client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("Conekta/v1 DotNetBindings10/Conekta::" + Version));
                _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", ApiKey + ":");
            }
        }

        public async Task<HttpResponseMessage> Delete(string path)
        {
            var request = CreateRequest(path, HttpMethod.Delete);
            try
            {
                return await _client.SendAsync(request);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<HttpResponseMessage> Get(string path)
        {
            var request = CreateRequest(path, HttpMethod.Get);

            try
            {
                return await _client.SendAsync(request);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<HttpResponseMessage> Post(string path, string json)
        {
            var request = CreateRequest(path, HttpMethod.Post, json);
            try
            {
                return await _client.SendAsync(request);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<HttpResponseMessage> Put(string path, string json)
        {
            var request = CreateRequest(path, HttpMethod.Put, json);
            try
            {
                return await _client.SendAsync(request);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private HttpRequestMessage CreateRequest(string path, HttpMethod method, string json = null)
        {
            var request = new HttpRequestMessage()
            {
                RequestUri = new Uri(path),
                Method = method
            };

            if(method == HttpMethod.Post || method == HttpMethod.Put)
            {
                request.Content = new StringContent(json, Encoding.UTF8, "application/json");
            }

            return request;
        }
    }
}
