using Consts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
    public class Heding
    {
        [Key]
        public int ID { get; set; }
        public int TopicID { get; set; }

        [Display(Name = "عنوان")]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrMsg.RequierdMsg)]
        [MaxLength(50, ErrorMessage = ErrMsg.MaxLenghtMsg)]
        [MinLength(3, ErrorMessage = ErrMsg.MinLenghtMsg)]
        [RegularExpression(@"[.#a-zا-یA-Z0-9آ\s_]*", ErrorMessage = ErrMsg.RegexMsg)]
        public string Title { get; set; }

        [Display(Name = "زمان")]
        public int Time { get; set; }

        [ForeignKey(nameof(TopicID))]
        [Display(Name = "سرفصل ")]
        public virtual Topic Topic { get; set; }
    }
}
