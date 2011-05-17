using System.Collections.Generic;
using windsor_ioc_spike.Models;

namespace windsor_ioc_spike.Repositories
{
    public class TeamTestRepo : ITeamRepo
    {
        public IList<Team> GetAllTeams() {
            IList<Team> return_team = new List<Team>();
            return_team.Add(new Team {City = "Mason", Nickname = "Comets"});
            return_team.Add(new Team{City = "Eaton", Nickname = "Eagles"});

            return return_team;
        }
    }
}