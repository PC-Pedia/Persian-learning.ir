﻿using Consts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Server
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "عنوان")]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrMsg.RequierdMsg)]
        [MaxLength(50, ErrorMessage = ErrMsg.MaxLenghtMsg)]
        [MinLength(3, ErrorMessage = ErrMsg.MinLenghtMsg)]
        [RegularExpression(@"[a-zا-یA-Z0-9آ\s_]*", ErrorMessage = ErrMsg.RegexMsg)]
        public string Title { get; set; }

        [Display(Name = "ادرس")]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrMsg.RequierdMsg)]
        [MaxLength(150, ErrorMessage = ErrMsg.MaxLenghtMsg)]
        [MinLength(3, ErrorMessage = ErrMsg.MinLenghtMsg)]
        [RegularExpression(@"[\w\._\:]*", ErrorMessage = ErrMsg.RegexMsg)]
        public string Url { get; set; }
        

        public virtual ICollection<Image> Images { get; set; }
    }
}
