using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VeterinaryClinic.Models
{
    public class EmailViewModel : Controller
    {
        public string email { get; set; }
        public string subject { get; set; }
        public string text { get; set; }
    }
}
