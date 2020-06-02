using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Net.Http;

namespace Labb1.Services
{
	public class ApiService
	{
		private const string DOMAIN = "https://localhost:44391";

		private readonly HttpClient client;

		public ApiService(IHttpClientFactory clientFactory)
		{
			this.client = clientFactory.CreateClient();
		}

		public IEnumerable<T> GetAll<T>(string apiPath)
		{
			var request = new HttpRequestMessage(HttpMethod.Get, DOMAIN + "/" + apiPath);
			var response = client.SendAsync(request).GetAwaiter().GetResult();
			return DeserializeJson<IEnumerable<T>>(response).GetAwaiter().GetResult();
		}

		public T GetOne<T>(string apiPath)
		{
			var request = new HttpRequestMessage(HttpMethod.Get, DOMAIN + "/" + apiPath);
			var response = client.SendAsync(request).GetAwaiter().GetResult();
			return DeserializeJson<T>(response).GetAwaiter().GetResult();
		}

		private async Task<T> DeserializeJson<T>(HttpResponseMessage content)
		{

			string jsonStr = await content.Content.ReadAsStringAsync();
			var result = JsonSerializer.Deserialize<T>(jsonStr, new JsonSerializerOptions()
			{
				PropertyNameCaseInsensitive = true
			});

			return result;
		}
	}
}
