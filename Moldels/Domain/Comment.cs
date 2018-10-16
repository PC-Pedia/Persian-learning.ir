using Consts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
    public class Comment
    {
        public int ID { get; set; }
        public string UserID { get; set; }
        public int CourseID { get; set; }


        [Display(Name = "نظر")]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrMsg.RequierdMsg)]
        [MaxLength(255, ErrorMessage = ErrMsg.MaxLenghtMsg)]
        [MinLength(3, ErrorMessage = ErrMsg.MinLenghtMsg)]
        public string Text { get; set; }
        [ForeignKey(nameof(CourseID))]
        [Display(Name = "دوره ")]
        public Course Course { get; set; }
        [Display(Name = "کاربر ")]
        [ForeignKey(nameof(UserID))]
        public ApplicationUser User { get; set; }
    }
}
