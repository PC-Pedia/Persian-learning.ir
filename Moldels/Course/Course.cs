using Consts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Course
    {
        [Key]
        public int ID { get; set; }
        public string UserID { get; set; }
        public int CateID { get; set; }
        public int ProfessorID { get; set; }
        public int? CourseID { get; set; }
        public int CourseTypeID { get; set; }
        public int CourseStateID { get; set; }

        [Display(Name = "عنوان فارسی")]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrMsg.RequierdMsg)]
        [MaxLength(255, ErrorMessage = ErrMsg.MaxLenghtMsg)]
        [MinLength(3, ErrorMessage = ErrMsg.MinLenghtMsg)]
        [RegularExpression(@"[a-zا-یA-Z0-9آ\s_\-]*", ErrorMessage = ErrMsg.RegexMsg)]
        public string TitleFa { get; set; }

        [Display(Name = "عنوان لاتین")]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrMsg.RequierdMsg)]
        [MaxLength(255, ErrorMessage = ErrMsg.MaxLenghtMsg)]
        [MinLength(3, ErrorMessage = ErrMsg.MinLenghtMsg)]
        [RegularExpression(@"[a-zا-یA-Z0-9آ\s_\-]*", ErrorMessage = ErrMsg.RegexMsg)]
        public string TitleEn { get; set; }

        [Display(Name = "معرفی اجمالی")]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrMsg.RequierdMsg)]
        [Column(TypeName = "nvarchar(max)")]
        public string Text { get; set; }


        [Display(Name = "تاریخ شروع")]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }

        [Display(Name = "تاریخ پایان")]
        [DataType(DataType.Date)]
        public DateTime? EndDate { get; set; }


        [Display(Name = "ظرفیت")]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrMsg.RequierdMsg)]
        public int Count { get; set; }


        [Display(Name = "بازدید")]
        public int Visit { get; set; }




        public virtual ICollection<Price> Prices { get; set; }
        public virtual ICollection<Image> Images { get; set; }


        [ForeignKey(nameof(UserID))]
        public virtual ApplicationUser User { get; set; }

        [ForeignKey(nameof(CateID))]
        public virtual Category Category { get; set; }

        [ForeignKey(nameof(CourseID))]
        public virtual Course CourseBefore { get; set; }

        [ForeignKey(nameof(CourseTypeID))]
        public virtual CourseType CourseType { get; set; }

        [ForeignKey(nameof(CourseStateID))]
        public virtual CourseState CourseState { get; set; }

        [ForeignKey(nameof(ProfessorID))]
        public virtual Professor professor { get; set; }

        public virtual ICollection<GroupShoping> GroupShopings { get; set; }
        public virtual ICollection<ShopingCart> ShopingCarts { get; set; }
        public virtual ICollection<Topic> Topics { get; set; }



        [NotMapped]
        public virtual ICollection<Like> Likes { get; set; }

        [NotMapped]
        public virtual ICollection<Comment> Comments { get; set; }

    }
}
