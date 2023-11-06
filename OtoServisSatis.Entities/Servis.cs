using System.ComponentModel.DataAnnotations;

namespace OtoServisSatis.Entities
{
    public class Servis : IEntity
    {
        public int Id { get; set; }

        [Display(Name = "Servise Geliş Tarihi"), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public DateTime ServiseGelisTarihi { get; set; }

        [Display(Name = "Araç Sorunu"), Required(ErrorMessage = "{0} Boş Bırakılamaz!")] 
        public string AracSorunu { get; set; }

        [Display(Name = "Servis Ücreti"), Required(ErrorMessage = "{0} Boş Bırakılamaz!")] 
        public decimal ServisUcreti { get; set; }

        [Display(Name = "Servisten Çıkış Tarihi"), Required(ErrorMessage = "{0} Boş Bırakılamaz!")] 
        public DateTime ServistenCikisTarihi { get; set; }

        [Display(Name = "Yapılan İşlemler")] 
        public string? YapilanIslemler { get; set; }

        [Display(Name = "Granati Kapsamında Mı?"), Required(ErrorMessage = "{0} Boş Bırakılamaz!")] 
        public bool GarantiKapsamindaMi { get; set; }
       
        [StringLength(15), Display(Name = "Araç Plakası"), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string AracPlaka { get; set; }
        
        [StringLength(50), Display(Name = "Markası"), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string Marka { get; set; }
        
        [StringLength(50), Display(Name = "Modeli")]
        public string? Model { get; set; }
        
        [StringLength(50), Display(Name = "Kasa Tipi")]
        public string? KasaTipi { get; set; }
        
        [StringLength(50), Display(Name = "Şase Numarası")]
        public string? SaseNo { get; set; }

        [Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string Notlar { get; set; }
    }
}
