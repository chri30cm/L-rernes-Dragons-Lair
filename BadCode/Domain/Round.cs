using System.Collections.Generic;

namespace BadCode
{
    public class Round
    {
        private List<Match> matches = new List<Match>();
        public Team FreeRider { get; set; }
        public List<Team> WinningTeams {
            get {
                List<Team> winningTeams = new List<Team>();
                foreach (Match match in matches)
                {
                    if (match.Winner != null)
                        winningTeams.Add(match.Winner);
                }
                return winningTeams;
            }
        }
        public List<Team> LosingTeams {
            get {
                List<Team> losingTeams = new List<Team>();
                foreach (Match match in matches)
                {
                    if (match.Winner != null)
                    {
                        if (match.Winner == match.FirstOpponent)
                            losingTeams.Add(match.SecondOpponent);
                        else
                            losingTeams.Add(match.FirstOpponent);
                    }
                }
                return losingTeams;
            }
        }

        public void AddMatch(Match match)
        {
            matches.Add(match);
        }

        public int GetNumberOfMatches()
        {
            return matches.Count;
        }

        public Match GetMatch(Team team1, Team team2)
        {
            Match foundMatch = null;
            int idx = 0;
            while ((foundMatch == null) && (idx < matches.Count))
            {
                Match match = matches[idx];
                if (match.FirstOpponent.Name.Equals(team1.Name) && match.SecondOpponent.Name.Equals(team2.Name))
                {
                    foundMatch = match;
                }
                idx++;
            }
            return foundMatch;
        }

        public Match GetMatch(string teamName1, string teamName2)
        {
            Match foundMatch = null;
            int idx = 0;
            while ((foundMatch == null) && (idx < matches.Count))
            {
                Match match = matches[idx];
                if (match.FirstOpponent.Name.Equals(teamName1) && match.SecondOpponent.Name.Equals(teamName2))
                {
                    foundMatch = match;
                }
                idx++;
            }
            return foundMatch;
        }

        public List<Match> GetAllMatches()
        {
            return matches;
        }

        public bool IsRoundFinished()
        {
            bool allMatchesGotWinner = true;
            int idx = 0;
            while((idx < matches.Count) && allMatchesGotWinner)
            {
                allMatchesGotWinner = (matches[idx].Winner != null);
                idx++;
            }
            return allMatchesGotWinner;
        }
    }
}
