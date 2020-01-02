using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Service.Dto
{
    [DataContract(IsReference = true)]
    public class ImprumutDto
    {
        public ImprumutDto() => Reviews = new HashSet<ReviewDto>();

        [DataMember]
        public int ImprumutId { get; set; }

        [DataMember]
        public DateTime DataImprumut { get; set; }

        [DataMember]
        public DateTime DataScadenta { get; set; }

        [DataMember]
        public DateTime? DataRestituire { get; set; }

        [DataMember]
        public int CarteId { get; set; }

        [DataMember]
        public int CititorId { get; set; }

        [DataMember]
        public virtual CarteDto Carte { get; set; }

        [DataMember]
        public virtual CititorDto Cititor { get; set; }

        [DataMember]
        public virtual ICollection<ReviewDto> Reviews { get; set; }
    }
}
