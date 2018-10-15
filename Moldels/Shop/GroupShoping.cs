using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
    public class GroupShoping
    {
        public int ID { get; set; }
        public int CourseID { get; set; }
        public int OrderID { get; set; }

        [ForeignKey(nameof(CourseID))]
        public virtual Course Course { get; set; }

        [ForeignKey(nameof(OrderID))]
        public virtual Order Order { get; set; }
    }
}
