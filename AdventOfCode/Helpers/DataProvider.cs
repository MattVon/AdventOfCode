namespace AdventOfCode.Helpers {
	using System.Collections.Generic;
	using System.Linq;

	internal static class DataProvider {

		internal static IEnumerable<string> GetInputData(string year, string challenge) {
			string dataSource = $"{Directory.GetCurrentDirectory()}/Data/Year/{year}/{challenge}.csv";

			using (StreamReader stream = new(dataSource)) {
				string data = stream.ReadToEnd();
				return data.Split(',').Select(item => item);
			}
		}
	}
}
