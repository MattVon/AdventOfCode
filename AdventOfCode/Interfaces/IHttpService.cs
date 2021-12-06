using AdventOfCode.Models;

namespace AdventOfCode.Interfaces {
	public interface IHttpService {
		Task<HttpResult> GetDataAsync(string url);
	}
}
