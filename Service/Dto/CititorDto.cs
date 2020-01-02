using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Service.Dto
{
    [DataContract(IsReference = true)]
    public class CititorDto
    {
        public CititorDto() => Imprumuts = new HashSet<ImprumutDto>();

        [DataMember]
        public int CititorId { get; set; }

        [DataMember]
        public string Nume { get; set; }

        [DataMember]
        public string Prenume { get; set; }

        [DataMember]
        public string Adresa { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public short Stare { get; set; }

        [DataMember]
        public virtual ICollection<ImprumutDto> Imprumuts { get; set; }
    }
}
