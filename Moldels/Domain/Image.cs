using Consts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Image
    {
        [Key]
        public int ID { get; set; }
        public int ServerID { get; set; }
        public int? CourseID { get; set; }
        public int? CategoryID { get; set; }
        public int? ProfID { get; set; }


        [Display(Name = "آدرس")]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrMsg.RequierdMsg)]
        [MaxLength(255, ErrorMessage = ErrMsg.MaxLenghtMsg)]
        [MinLength(3, ErrorMessage = ErrMsg.MinLenghtMsg)]
        public string FileName { get; set; }

        [Display(Name = "متن جایگزین")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = ErrMsg.RequierdMsg)]
        [MaxLength(100, ErrorMessage = ErrMsg.MaxLenghtMsg)]
        [MinLength(3, ErrorMessage = ErrMsg.MinLenghtMsg)]
        //[RegularExpression(@"[.#a-zا-یA-Z0-9آ\s_]*", ErrorMessage = ErrMsg.RegexMsg)]
        public string Alt { get; set; }


        [ForeignKey(nameof(ServerID))]
        public virtual Server Server { get; set; }

        [ForeignKey(nameof(CourseID))]
        public virtual Course Course { get; set; }

        [ForeignKey(nameof(CategoryID))]
        public virtual Category Category { get; set; }

        [ForeignKey(nameof(ProfID))]
        public virtual Professor Professor { get; set; }
    }
}
