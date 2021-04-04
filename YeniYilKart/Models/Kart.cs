using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace YeniYilKart.Models
{
    [Table("Kartlar")]
    public class Kart
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Başlık")]
        public string Baslik { get; set; }

        [Required]
        [Display(Name = "Alıcı")]
        public string AliciAd { get; set; }
        [Display(Name = "Gönderen")]
        public string GondericiAd { get; set; }
        [Display(Name = "Mesaj")]
        public string Mesaj { get; set; }
        public string ResimAd { get; set; }
    }
}