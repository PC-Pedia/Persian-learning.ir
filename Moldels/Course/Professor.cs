using Consts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
    public class Professor
    {
        public int ID { get; set; }

        [Display(Name = "مدرک تحصیلی")]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrMsg.RequierdMsg)]
        [MaxLength(50, ErrorMessage = ErrMsg.MaxLenghtMsg)]
        [MinLength(3, ErrorMessage = ErrMsg.MinLenghtMsg)]
        public string Evidence { get; set; }

        [Display(Name = "مهارت اصلی")]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrMsg.RequierdMsg)]
        [MaxLength(50, ErrorMessage = ErrMsg.MaxLenghtMsg)]
        [MinLength(3, ErrorMessage = ErrMsg.MinLenghtMsg)]
        public string TopSkill { get; set; }

        public virtual ICollection<ProfSkill> ProfSkills { get; set; }
    }
    public class Skill
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "عنوان مهارت")]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrMsg.RequierdMsg)]
        [MaxLength(50, ErrorMessage = ErrMsg.MaxLenghtMsg)]
        [MinLength(3, ErrorMessage = ErrMsg.MinLenghtMsg)]
        [RegularExpression(@"[a-zا-یA-Z0-9آ\s_]*", ErrorMessage = ErrMsg.RegexMsg)]
        public string Title { get; set; }


        public virtual ICollection<ProfSkill> ProfSkills { get; set; }
    }
    public class ProfSkill
    {
        public int ID { get; set; }
        public int ProfID { get; set; }
        public int SkillID { get; set; }


        [ForeignKey(nameof(ProfID))]
        public virtual Professor professor { get; set; }

        [ForeignKey(nameof(SkillID))]
        public virtual Skill Skill { get; set; }

    }
}
