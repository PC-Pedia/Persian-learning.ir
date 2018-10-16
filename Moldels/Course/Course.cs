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
        [Display(Name = "دسته بندی")]
        public int CateID { get; set; }
        [Display(Name = "دوره")]
        public int? CourseID { get; set; }
        [Display(Name = "نوع دوره")]
        public int? CourseTypeID { get; set; }
        [Display(Name = "وضعیت دوره")]
        public int? CourseStateID { get; set; }
        [Display(Name = " استاد")]
        public int? ProfID { get; set; }

        [Display(Name = "عنوان فارسی")]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrMsg.RequierdMsg)]
        [MaxLength(255, ErrorMessage = ErrMsg.MaxLenghtMsg)]
        [MinLength(3, ErrorMessage = ErrMsg.MinLenghtMsg)]
        
        public string TitleFa { get; set; }

        [Display(Name = "عنوان لاتین")]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrMsg.RequierdMsg)]
        [MaxLength(255, ErrorMessage = ErrMsg.MaxLenghtMsg)]
        [MinLength(3, ErrorMessage = ErrMsg.MinLenghtMsg)]
       
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
        

        [ForeignKey(nameof(CateID))]
        [Display(Name = "دسته بندی ")]
        public virtual Category Category { get; set; }

        [ForeignKey(nameof(CourseID))]
        [Display(Name = "پیش نیاز ")]
        public virtual Course CourseBefore { get; set; }

        [ForeignKey(nameof(CourseTypeID))]
        [Display(Name = "نوع دوره ")]
        public virtual CourseType CourseType { get; set; }

        [ForeignKey(nameof(CourseStateID))]
        [Display(Name = "وضعیت دوره ")]
        public virtual CourseState CourseState { get; set; }

        [ForeignKey(nameof(ProfID))]
        [Display(Name = "استاد ")]
        public virtual Professor professor { get; set; }

        public virtual ICollection<GroupShoping> GroupShopings { get; set; }
        public virtual ICollection<ShopingCart> ShopingCarts { get; set; }
        public virtual ICollection<Topic> Topics { get; set; }

        public ICollection<Movie> Movies { get; set; }

        [NotMapped]
        public virtual ICollection<Like> Likes { get; set; }

        [NotMapped]
        public virtual ICollection<Comment> Comments { get; set; }

    }
}
