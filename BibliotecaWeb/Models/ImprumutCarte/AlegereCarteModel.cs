using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaWeb.Models.ImprumutCarte
{
    public class AlegereCarteModel
    {
        public List<CarteDto> carti { get; set; }
        public int cititorId { get; set; }
        public int selectedAnswer { get; set; }
    }
}
