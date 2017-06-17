using System.Threading.Tasks;
using System.Net.Http;

namespace ConektaNet.Services
{
    public interface IHttpHelper
    {
        Task<HttpResponseMessage> Get(string path);
        Task<HttpResponseMessage> Post(string path, string json);
        Task<HttpResponseMessage> Put(string path, string json);
        Task<HttpResponseMessage> Delete(string path);
    }
}
