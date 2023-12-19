// See https://aka.ms/new-console-template for more information

using AdventOfCode.AdventDays;
using AdventOfCode.Models;

AdventCode adventChallenges = CreateAdventCodeChallenges();

if (adventChallenges == null || adventChallenges.Challenges.Count == 0) {
	Console.WriteLine("ERROR: No challenges found, exiting...");
	return;
}

Console.WriteLine("Select which challenge to accomplish today by entering the ID from the below list");

foreach(Challenge challenge in Enumerable.Reverse(adventChallenges.Challenges)) {
	Console.WriteLine($"Date: {challenge.Date.ToShortDateString()} - Id: {challenge.Id}");
}

Console.Write("Start challenge: ");
string? value = Console.ReadLine();

if (!int.TryParse(value, out int selectedChallenge)) {
	Console.WriteLine("ERROR: Invalid input");
	return;
}

BaseAdventChallenger.InitateAdventChallenge(selectedChallenge);

Console.ReadLine();

static AdventCode CreateAdventCodeChallenges() {
	AdventCode adventCode = new() { Challenges = new List<Challenge>() };
	int numberOfDays = DateTime.Now.Day;

	for (int i = 0; i < numberOfDays; i++) {
		adventCode.Challenges.Add(new Challenge {
			Id = DateTime.Now.AddDays(-i).Day,
			Date = DateTime.Now.AddDays(-i).Date
		});
	}

	return adventCode;
}