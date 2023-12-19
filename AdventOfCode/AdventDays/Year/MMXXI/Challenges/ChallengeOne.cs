namespace AdventOfCode.AdventDays.Year.MMXXI.Challenges {
	using AdventOfCode.Helpers;

	internal class ChallengeOne {
		internal static void Start() {
			IEnumerable<string> inputData = DataProvider.GetInputData("MMXXI", "Challenge One");
			int? previousMeasurement = null;
			int measurementCounter = 0;

			//foreach (int measurement in inputData) {
			//	if (previousMeasurement == null) {
			//		previousMeasurement = measurement;
			//		continue;
			//	}

			//	if (measurement > previousMeasurement) {
			//		measurementCounter++;
			//	}

			//	previousMeasurement = measurement;
			//}

			Console.WriteLine($"Answer: {measurementCounter}");
			Console.ReadLine();
		}
	}
}
