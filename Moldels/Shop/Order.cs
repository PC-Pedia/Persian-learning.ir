using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Order
    {
        [Key]
        public int ID { get; set; }
        public string UserID { get; set; }

        [Display(Name = "قیمت")]
        public string Price { get; set; }

        [Display(Name = "وضعیت سفارش")]
        public int Status { get; set; }

        [Display(Name = "شناسه ی بانکی")]
        [MaxLength(50)]
        public string BankGetNumber { get; set; }

        [Display(Name = "شماره تراکنش بانکی")]
        [MaxLength(50)]
        public string BankTransNumber { get; set; }

        [Display(Name = "کد رهگیری پستی")]
        [MaxLength(50)]
        public string PostBarCode { get; set; }
        public DateTime Date { get; set; }
        public string Descreption { get; set; }


        [ForeignKey(nameof(UserID))]
        public virtual ApplicationUser User { get; set; }

        public virtual ICollection<GroupShoping> GroupShopings { get; set; }
    }
}
