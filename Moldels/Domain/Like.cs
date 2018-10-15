using Consts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
    public class Like
    {
        public int ID { get; set; }
        public string UserID { get; set; }
        public int CourseID { get; set; }

        [ForeignKey(nameof(CourseID))]
        public Course Course { get; set; }
        [ForeignKey(nameof(UserID))]
        public ApplicationUser User { get; set; }
    }
}
