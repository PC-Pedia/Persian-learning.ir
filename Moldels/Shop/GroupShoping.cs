using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
    public class GroupShoping
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "دوره ")]
        public int CourseID { get; set; }
        public int OrderID { get; set; }

        [ForeignKey(nameof(CourseID))]
        [Display(Name = "دوره ")]
        public virtual Course Course { get; set; }

        [ForeignKey(nameof(OrderID))]
        [Display(Name = "سفارش ")]
        public virtual Order Order { get; set; }
    }
}
