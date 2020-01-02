using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaWeb.Models.ImprumutCarte
{
    public class AlegereGenModel
    {
        public List<GenDto> genuri { get; set; }
        public Int16 stare { get; set; }
        public int cititorId { get; set; }
        public int selectedAnswer { get; set; }
    }
}
