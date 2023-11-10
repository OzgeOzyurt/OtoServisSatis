﻿using System.ComponentModel.DataAnnotations;

namespace OtoServisSatis.Entities
{
    public class Kullanici : IEntity
    {
        public int Id { get; set; }

        [StringLength(50), Display(Name = "Ad"), Required(ErrorMessage ="{0} boş bırakılamaz!")]
        public string Adi { get; set; }

        [StringLength(50), Display(Name = "Soyad"), Required(ErrorMessage = "{0} boş bırakılamaz!")]
        public string Soyadi { get; set; }

        [StringLength(50), Required(ErrorMessage = "{0} boş bırakılamaz!")]
        public string Email { get; set; }

        [StringLength(20)]
        public string? Telefon { get; set; }

        [StringLength(50), Display(Name = "Kullanıcı Adı")]
        public string? KullaniciAdi { get; set; }

        [StringLength(50), Display(Name = "Şifre"), Required(ErrorMessage = "{0} boş bırakılamaz!")]
        public string Sifre { get; set; }
        
        [Display(Name = "Aktif")]
        public bool AktifMi { get; set; }
        
        [Display(Name = "Eklenme Tarihi"), ScaffoldColumn(false)]
        public DateTime? EklenmeTarihi { get; set; } = DateTime.Now;
        
        [Display(Name = "Kullanıcı Rolü"), Required(ErrorMessage = "{0} boş bırakılamaz!")]
        public int RolId { get; set; }

        [Display(Name = "Kullanıcı Rolü")]
        public virtual Rol? Rol { get; set; }
    }
}
