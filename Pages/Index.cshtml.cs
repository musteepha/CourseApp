﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoursesWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoursesWebApp.Pages
{
    public class CoursesAndModulesModel : PageModel
    {
        // TODO: Create a DataAccessController object
        DataAccessController dac = new DataAccessController();

        // TODO: Create a collection for holding CoursesAndModules object
        public List<CoursesAndModules> CoursesAndModules;

        public void OnGet()
        {
            // TODO: Retrieve the data using the DataAccessController object and populate the CoursesAndModules object
            CoursesAndModules = dac.GetAllCoursesAndModules().ToList();
        }
    }
}
