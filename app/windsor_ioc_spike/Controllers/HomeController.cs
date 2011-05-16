using System.Web.Mvc;
using windsor_ioc_spike.Repositories;
using windsor_ioc_spike.Views.ViewModels;

namespace windsor_ioc_spike.Controllers
{
    public class HomeController : Controller
    {
        public ITeamRepo teamRepo { get; set; }
        private Home_ViewModel viewModel;

        public ActionResult Index() {
            viewModel = new Home_ViewModel();
            viewModel.Teams = teamRepo.GetAllTeams();

            return View(viewModel);
        }

    }
}
