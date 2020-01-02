using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Service.Dto
{
    [DataContract(IsReference = true)]
    public class GenDto
    {
        public GenDto() => Cartes = new HashSet<CarteDto>();

        [DataMember]
        public int GenId { get; set; }

        [DataMember]
        public string Descriere { get; set; }

        [DataMember]
        public virtual ICollection<CarteDto> Cartes { get; set; }
    }
}
