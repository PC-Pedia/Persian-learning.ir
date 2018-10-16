using Consts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Slider
    {
        [Key]
        public int ID { get; set; }
        public int CourseID { get; set; }
        public int ProfID { get; set; }

        [Display(Name ="ترتیب")]
        public int Sort { get; set; }

        [Display(Name ="لینک")]
        [Required(AllowEmptyStrings =false,ErrorMessage =ErrMsg.RequierdMsg)]
        public string Link { get; set; }


        [ForeignKey(nameof(ProfID))]
        public virtual Professor Professor { get; set; }


        [ForeignKey(nameof(CourseID))]
        public virtual Course Course { get; set; }

    }
}
