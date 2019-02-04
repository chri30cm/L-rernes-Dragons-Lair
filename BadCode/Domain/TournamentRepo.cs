using System.Collections.Generic;

namespace BadCode
{
    public class TournamentRepo
    {
        private List<Tournament> tournaments = new List<Tournament>();

        public void RegisterTournament(string name)
        {
            Tournament newTournament = new Tournament(name);
            RegisterTournament(newTournament);
        }

        public void RegisterTournament(Tournament tournament)
        {
            tournaments.Add(tournament);
        }

        public Tournament GetTournament(string tournamentName)
        {
            Tournament tournament = null;
            int idx = 0;
            while((tournament == null) && (idx < tournaments.Count))
            {
                if (tournaments[idx].TournamentName.Equals(tournamentName))
                {
                    tournament = tournaments[idx];
                }
                idx++;
            }
            return tournament;
        }
    }
}
