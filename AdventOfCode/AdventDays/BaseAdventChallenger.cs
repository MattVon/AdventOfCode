namespace AdventOfCode.AdventDays {
	using AdventOfCode.AdventDays.Year.MXXIII;
	using AdventOfCode.Extensions;

	internal class BaseAdventChallenger {

		internal static void InitateAdventChallenge(int adventId) {

			string currentYear = DateTime.Now.Year.ToRoman();
			Console.WriteLine($"Current Year: {currentYear}");

			switch (currentYear) {
				case "MMXXIII":
					//ChallengeOne.Start();
					TwentyThreeYearChallengeProvider.InitateAnnualChallenge(adventId);
					break;
				default:
					Console.WriteLine("This challenge has not been created yet, sorry");
					break;
			}
		}
	}
}
