using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Service.Dto
{
    [DataContract(IsReference = true)]
    public class CarteDto
    {
        public CarteDto() => Imprumuts = new HashSet<ImprumutDto>();

        [DataMember]
        public int CarteId { get; set; }

        [DataMember]
        public string Titlu { get; set; }

        [DataMember]
        public int AutorId { get; set; }

        [DataMember]
        public int GenId { get; set; }

        [DataMember]
        public virtual AutorDto Autor { get; set; }

        [DataMember]
        public virtual GenDto Gen { get; set; }

        [DataMember]
        public virtual ICollection<ImprumutDto> Imprumuts { get; set; }
    }
}
