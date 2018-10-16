using Consts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Price
    {
        [Key]
        public int ID { get; set; }
        public int CourseID { get; set; }

        [Display(Name ="تاریخ")]
        [Required(AllowEmptyStrings =false,ErrorMessage =ErrMsg.RequierdMsg)]
        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }

        [Display(Name = "قیمت")]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrMsg.RequierdMsg)]
        [MaxLength(14, ErrorMessage = ErrMsg.MaxLenghtMsg)]
        [MinLength(3, ErrorMessage = ErrMsg.MinLenghtMsg)]
        [RegularExpression(@"[\d,]*",ErrorMessage =ErrMsg.RegexMsg)]
        public string Pric { get; set; }


        [ForeignKey(nameof(CourseID))]
        [Display(Name = "دوره ")]
        public virtual Course Course { get; set; }
    }
}
