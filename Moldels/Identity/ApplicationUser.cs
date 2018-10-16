using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class ApplicationUser : IdentityUser
    {

        [Display(Name ="نام")]
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Display(Name ="نام خانوادگی")]
        [MaxLength(100,ErrorMessage ="{0} نباید بیشتر از {1} باشد")]
        public string Family { get; set; }

        [MaxLength(100)]
        public string Country { get; set; }

        [MaxLength(100)]
        public string Province { get; set; }

        [MaxLength(100)]
        public string City { get; set; }

        [MaxLength(300)]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }

        [MaxLength(15)]
        public string PostalCode { get; set; }


        
        public virtual ICollection<NewsLetter> NewsLetter { get; set; }
        public virtual ICollection<ShopingCart> ShopingCart { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

        [NotMapped]
        public virtual ICollection<Messages> Messages { get; set; }

        [NotMapped]
        public virtual ICollection<Like> Likes { get; set; }

        [NotMapped]
        public virtual ICollection<Comment> Comments { get; set; }

        public virtual Image ImageProfile { get; set; }

    }
}
