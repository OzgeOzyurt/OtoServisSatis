using System.ComponentModel.DataAnnotations;

namespace OtoServisSatis.WebUI.Models
{
    public class CustomerLoginViewModel
    {
        [StringLength(50), Required(ErrorMessage = "{0} boş bırakılamaz!")]
        public string Email { get; set; }

        
        [StringLength(50), Display(Name = "Şifre"), Required(ErrorMessage = "{0} boş bırakılamaz!")]
        public string Sifre { get; set; }
    }
}
