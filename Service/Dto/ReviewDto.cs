using System.Runtime.Serialization;

namespace Service.Dto
{
    [DataContract(IsReference = true)]
    public class ReviewDto
    {
        [DataMember]
        public int ReviewId { get; set; }

        [DataMember]
        public string Text { get; set; }

        [DataMember]
        public int ImprumutId { get; set; }

        [DataMember]
        public virtual ImprumutDto Imprumut { get; set; }
    }
}
