using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FBLeague.Models;

namespace FBLeague.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddFBData()
        {
            return View();
        }
        public ActionResult SaveUser(FBData u)
        {
            StreamWriter sw = new
             StreamWriter(Server.MapPath("~/App_Data/users.txt"), true);
            sw.WriteLine("User details added on: " +
             DateTime.Now.ToString());
            sw.WriteLine("MatchID: " + u.MatchID);
            sw.WriteLine("TeamName1: " + u.TeamName1);
            sw.WriteLine("TeamName2: " + u.TeamName2);
            sw.WriteLine("Status: " + u.Status);
            sw.WriteLine("WinningTeam: " + u.WinningTeam);




            sw.WriteLine();
            sw.Close();
            return Content("User details have been saved");
        }
    }
}