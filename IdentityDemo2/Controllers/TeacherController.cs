﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IdentityDemo2.Controllers
{
    [Authorize(Roles = "TEACHER")]
    public class TeacherController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }




        ////*** Viraj working here ***/////////////////////////////////////////////////////////////////


        ////*** Viraj Completed ***////////////////////////////////////////////////////////////////////












        ////*** Rushikesh working here ***/////////////////////////////////////////////////////////////


        ////*** Rushikesh Completed ***////////////////////////////////////////////////////////////////














        ////*** Bhagyesh working here ***////////////////////////////////////////////////////////////////


        ////*** Bhagyesh Completed ***////////////////////////////////////////////////////////////////////////////










        ////*** Ankita working here ***/////////////////////////////////////////////////////////////////


        ////*** Ankita Completed ***///////////////////////////////////////////////////////////////////////////







        ////*** Vaishnavi working here ***////////////////////////////////////////////////////////////////


        ////*** Vaishanavi Completed ***/////////////////////////////////////////////////////////////////

    }
}
