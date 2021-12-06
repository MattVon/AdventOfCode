using AdventOfCode.Models;

using System.Net;

namespace AdventOfCode.Services {
	public class HttpService {

		public static async Task<HttpResult> GetDataAsync(string url) {
			HttpResult result = new();
			try {
				if (string.IsNullOrEmpty(url)) {
					result.ExceptionMessage = $"{nameof(url)} is invalid.";
					return result;
				}

				using (HttpClient client = new HttpClient())
				using (HttpResponseMessage response = await client.GetAsync(new Uri(url))) {
					if (!response.IsSuccessStatusCode) {
						result.ExceptionMessage = response.StatusCode.ToString();
						return result;
					}

					result.Response = await response.Content.ReadAsStringAsync();
				}

			} catch (HttpRequestException ex) {
				Console.WriteLine();
			} catch (Exception ex) {
				Console.WriteLine();
			}

			return result;
		}

		public static HttpResult GetHtmlFromUrl(string url) {
			HttpResult result = new();

			try {
				if (string.IsNullOrEmpty(url)) {
					result.ExceptionMessage = $"{nameof(url)} is invalid.";
					return result;
				}

				using (WebClient client = new()) {
					result.Response = client.DownloadString(url);
				}
			} catch (HttpRequestException ex) {
				Console.WriteLine();
			} catch (Exception ex) {
				Console.WriteLine();
			}

			return result;
		}
	}
}
