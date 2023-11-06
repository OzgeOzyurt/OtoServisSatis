using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace OtoServisSatis.Entities
{
    public class Arac : IEntity
    {
        public int Id { get; set; }
       
        [Display(Name = "Marka Adı"), Required(ErrorMessage = "{0} boş bırakılamaz!")]
        public int MarkaId { get; set; }

        [StringLength(50), Required(ErrorMessage = "{0} boş bırakılamaz!")]
        public string Renk { get; set; }
       
        [Display(Name = "Fiyatı"), Required(ErrorMessage = "{0} boş bırakılamaz!")]
        public decimal Fiyati { get; set; }

        [StringLength(50), Required(ErrorMessage = "{0} boş bırakılamaz!")]
        public string Modeli { get; set; }

        [Display(Name = "Kasa Tipi"), StringLength(50), Required(ErrorMessage = "{0} boş bırakılamaz!")]
        public string KasaTipi { get; set; }

        [Display(Name = "Model Yılı")]
        public int ModelYili { get; set; }

        [Display(Name = "Satşta Mı?")] 
        public bool SatistaMi { get; set; }
        
        [Required(ErrorMessage = "{0} boş bırakılamaz!")]
        public string Notlar { get; set; }
       
        public virtual Marka? Marka { get; set; } //Araç sınıfı ile Marka sınıf arasında bağlantı
    }
}
