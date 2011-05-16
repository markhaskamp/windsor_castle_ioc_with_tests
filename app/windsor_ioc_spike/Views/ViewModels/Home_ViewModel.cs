using System.Collections.Generic;
using windsor_ioc_spike.Models;

namespace windsor_ioc_spike.Views.ViewModels
{
    public class Home_ViewModel
    {
        public IList<Team> Teams { get; set; }

        public Home_ViewModel() {
            Teams = new List<Team>();
        }
    }
}