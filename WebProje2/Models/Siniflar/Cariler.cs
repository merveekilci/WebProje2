using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebProje2.Models.Siniflar
{
    public class Cariler
    {
        [Key]
        public int CarilerID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30, ErrorMessage = "Cari Adı En fazla 30 karakter uzunluğunda olabilir.")]
        public string CariAd { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        [Required(ErrorMessage ="Soyad alanı boş geçilemez !")]
        public string CariSoyad { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(13)]
        public string CariSehir { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string CariMail { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        public string Sifre { get; set; }
        public bool Durum { get; set; }
        public ICollection<SatisHareket> SatisHarekets { get; set; }

    }
}