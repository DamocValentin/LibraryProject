using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaWeb.Models.RestituireCarte
{
    public class RestituireCarteModel
    {
        public string numeCarte { get; set; }
        public string numeAutor { get; set; }
        public string prenumeAutor { get; set; }
        public string numeCititor { get; set; }
        public string prenumeCititor { get; set; }
        public string textReview { get; set; }
    }
}
