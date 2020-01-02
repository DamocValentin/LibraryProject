using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Service.Dto
{
    [DataContract(IsReference = true)]
    public class AutorDto
    {
        public AutorDto() => Cartes = new HashSet<CarteDto>();

        [DataMember]
        public int AutorId { get; set; }

        [DataMember]
        public string Nume { get; set; }

        [DataMember]
        public string Prenume { get; set; }

        [DataMember]
        public virtual ICollection<CarteDto> Cartes { get; set; }
    }
}
