using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Conference.Models
{
    public class Speaker
    {
        public Int32 SpeakerID { get; set; }

        [Required(ErrorMessage="{0} is Required")]
        [Display(Name = "{0} name")]
        public String Name { get; set; }

        [DataType(DataType.EmailAddress)]
        public String EmailAddress { get; set; }

        public virtual List<Session> Sessions { get; set; }
    }

    //[MetadataType(typeof(SpeakerMetadata))]
    //public partial class Speaker
    //{

    //}

    //public class SpeakerMetadata
    //{
    //    [Required()]
    //    public Object Name { get; set; }
    //}
}
