namespace AdventOfCode.Days {
	internal class ChallengeOne {


		internal static void Start() {
			List<int> inputData = GetInputData();
			int? previousMeasurement = null;
			int measurementCounter = 0;

			foreach (int measurement in inputData) {
				if (previousMeasurement == null) {
					previousMeasurement = measurement;
					continue;
				}

				if (measurement > previousMeasurement) {
					measurementCounter++;
				}

				previousMeasurement = measurement;
			}

			Console.WriteLine($"Answer: {measurementCounter}");
			Console.ReadLine();
		}

		private static List<int> GetInputData() {
			string dataSource = $"{Directory.GetCurrentDirectory()}/Data/ChallengeOne.csv";

			using (StreamReader stream = new StreamReader(dataSource)) {
				string data = stream.ReadToEnd();
				return data.Split(',').Select(int.Parse).ToList();
			}

		}
	}
}
