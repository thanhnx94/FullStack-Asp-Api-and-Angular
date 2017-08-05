using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEnd_Api.Models
{
    public class User
    {
        public int Id { get; set; }
        public string name { get; set; }
        public int status { get; set; }
    }
}