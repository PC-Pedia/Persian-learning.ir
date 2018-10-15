using Consts;
using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Menu
    {
        [Key]
        public int ID { get; set; }
        public int ParrentID { get; set; }
        [Display(Name = "عنوان")]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrMsg.RequierdMsg)]
        [MaxLength(255, ErrorMessage = ErrMsg.MaxLenghtMsg)]
        [MinLength(3, ErrorMessage = ErrMsg.MinLenghtMsg)]
        [RegularExpression(@"[a-zا-یA-Z0-9آ\s_\-]*", ErrorMessage = ErrMsg.RegexMsg)]
        public string Title { get; set; }
        public int Sort { get; set; }
    }
}
