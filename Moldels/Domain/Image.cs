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
        public string UserID { get; set; }


        [Display(Name = "آدرس")]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrMsg.RequierdMsg)]
        [MaxLength(255, ErrorMessage = ErrMsg.MaxLenghtMsg)]
        [MinLength(3, ErrorMessage = ErrMsg.MinLenghtMsg)]
        public string FileName { get; set; }

        [Display(Name = "متن جایگزین")]
        [MaxLength(100, ErrorMessage = ErrMsg.MaxLenghtMsg)]
        [MinLength(3, ErrorMessage = ErrMsg.MinLenghtMsg)]
        public string Alt { get; set; }


        [ForeignKey(nameof(ServerID))]
        [Display(Name = "سرور ")]
        public virtual Server Server { get; set; }

        [ForeignKey(nameof(CourseID))]
        [Display(Name = "دوره ")]
        public virtual Course Course { get; set; }

        [ForeignKey(nameof(CategoryID))]
        [Display(Name = "دسته بندی ")]
        public virtual Category Category { get; set; }

        [ForeignKey(nameof(UserID))]
        [Display(Name = "کاربر ")]
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
