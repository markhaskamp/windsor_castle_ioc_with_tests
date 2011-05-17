using System.Collections.Generic;
using System.Web.Mvc;
using NUnit.Framework;
using Rhino.Mocks;
using windsor_ioc_spike.Controllers;
using windsor_ioc_spike.Models;
using windsor_ioc_spike.Repositories;
using windsor_ioc_spike.Views.ViewModels;

namespace windsor_ioc_spike_test
{
    [TestFixture]
    public class HomeController_test
    {
        [Test]
        public void Index_call_with_test_repo() {
            HomeController controller = new HomeController(new TeamTestRepo());

            ActionResult actionResult = controller.Index();
            ViewResult viewResult = (ViewResult) actionResult;
            Home_ViewModel viewModel = (Home_ViewModel) viewResult.ViewData.Model;

            Assert.AreEqual(2, viewModel.Teams.Count);
        }

        [Test]
        public void Index_calls_ITeamRepo_GetAllTeams() {
            MockRepository mockery = new MockRepository();
            ITeamRepo mockTeamRepo = mockery.DynamicMock<ITeamRepo>();

            using (mockery.Record()) {
                Expect.Call(mockTeamRepo.GetAllTeams()).Return(new List<Team>());
            }
            using (mockery.Playback()) {
                HomeController homeController = new HomeController(mockTeamRepo);
                homeController.Index();
            }

            mockery.VerifyAll();
        }
    }
}
