using System.Diagnostics;
using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int hour = DateTime .Now.Hour;
            ViewBag.Greetings = hour > 12 ? "Good Afternoon" : "Good Morning";
            int UserCount = Repository.Users.Where(info => info.WillAttend == true).Count();

            var meetingInfo = new MeetingInfo()
            {
                Id = 1,
                Location = "Ankara, Turkey, Congresium",
                Date = new DateTime(2024, 02, 04, 20,0,0),
                NumberOfPeople = UserCount
            };
             
            return View(meetingInfo);
        }

    }
}
