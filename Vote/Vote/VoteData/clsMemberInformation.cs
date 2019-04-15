using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; //added

namespace Vote.VoteData
{
    public class clsMemberInformation
    {
        [Required]
        [Display(Name = "ID")]
        public int ID { get; set; }

        [Required]
        [StringLength(50)] //SETS MAX LENGTH
        [Display(Name = "Member ID")]
        public string MemberID { get; set; }

        [Required]
        [StringLength(50)] //SETS MAX LENGTH
        [Display(Name = "Member Name")]
        public string MemberName { get; set; }
    }
}
