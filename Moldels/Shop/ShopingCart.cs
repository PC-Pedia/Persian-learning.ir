using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class ShopingCart
    {
        [Key]
        public int ID { get; set; }
        public string UserID { get; set; }
        public int CourseID { get; set; }

        [Display(Name = "تاریخ")]
        public DateTime Date { get; set; }


        [ForeignKey(nameof(UserID))]
        [Display(Name = "کاربر ")]
        public virtual ApplicationUser User{ get; set; }

        [ForeignKey(nameof(CourseID))]
        [Display(Name = "دوره ")]
        public virtual Course Course { get; set; }

    }
}
