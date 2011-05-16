using System.Collections.Generic;
using windsor_ioc_spike.Castle_Setup;
using windsor_ioc_spike.Models;

namespace windsor_ioc_spike.Repositories
{
    public class TeamRepo : ITeamRepo, IDependency
    {
        public IList<Team> GetAllTeams() {
            IList<Team> return_teams = new List<Team>(3);
            return_teams.Add(new Team {City = "Cincinnati", Nickname = "Reds"});
            return_teams.Add(new Team {City = "Milwaukee", Nickname = "Brewers"});
            return_teams.Add(new Team {City = "St. Louis", Nickname = "Cardinals"});

            return return_teams;
        }
    }
}