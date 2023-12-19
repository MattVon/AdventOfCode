namespace AdventOfCode.AdventDays.Year.MXXIII {
	using AdventOfCode.AdventDays.Year.MXXIII.Challenges;

	internal static class TwentyThreeYearChallengeProvider {
		internal static void InitateAnnualChallenge(int adventId) {
			switch (adventId) {
				case 1:
					ChallengeOne.Start();
					break;
			}
		}
	}
}
