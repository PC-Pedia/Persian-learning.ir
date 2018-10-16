using Consts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
    public class Topic
    {
        [Key]
        public int ID { get; set; }
      
        public int CourseID { get; set; }

        [Display(Name = "عنوان")]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrMsg.RequierdMsg)]
        [MaxLength(50, ErrorMessage = ErrMsg.MaxLenghtMsg)]
        [MinLength(3, ErrorMessage = ErrMsg.MinLenghtMsg)]
        [RegularExpression(@"[.#a-zا-یA-Z0-9آ\s_]*", ErrorMessage = ErrMsg.RegexMsg)]
        public string Title { get; set; }


        public virtual ICollection<Heding> Heding { get; set; }

        [ForeignKey(nameof(CourseID))]
        [Display(Name = "دوره ")]
        public virtual Course Course { get; set; }
    }

}
