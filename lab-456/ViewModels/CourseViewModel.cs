using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using lab_456.Models;

namespace lab_456.ViewModels
{
    public class CourseViewModel
    {
        public int Place { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public string Heading { get; internal set; }

        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    }
}