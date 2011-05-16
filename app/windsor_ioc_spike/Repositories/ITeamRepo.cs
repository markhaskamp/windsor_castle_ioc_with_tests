using System.Collections.Generic;
using windsor_ioc_spike.Models;

namespace windsor_ioc_spike.Repositories
{
    public interface ITeamRepo
    {
        IList<Team> GetAllTeams();
    }
}
