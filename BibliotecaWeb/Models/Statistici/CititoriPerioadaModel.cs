using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaWeb.Models.Statistici
{
    public class CititoriPerioadaModel
    {
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public List<CititorDto> cititori { get; set; }
    }
}
