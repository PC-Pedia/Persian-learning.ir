using Consts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }

        [Display(Name ="عنوان")]
        [Required(AllowEmptyStrings =false,ErrorMessage = ErrMsg.RequierdMsg)]
        [MaxLength(50,ErrorMessage =ErrMsg.MaxLenghtMsg)]
        [MinLength(3, ErrorMessage = ErrMsg.MinLenghtMsg)]
        [RegularExpression(@"[a-zا-یA-Z0-9آ\s_]*",ErrorMessage =ErrMsg.RegexMsg)]
        public string Title { get; set; }


        public virtual ICollection<Course> Courses { get; set; }
        public virtual Image Image { get; set; }
    }
}
