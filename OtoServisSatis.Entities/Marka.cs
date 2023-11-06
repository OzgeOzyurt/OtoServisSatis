﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace OtoServisSatis.Entities
{
    public class Marka : IEntity
    {
        public int Id { get; set; }

        [StringLength(50), Display(Name = "Rol Adı"), Required(ErrorMessage = "{0} boş bırakılamaz!")]
        public string Adi { get; set; }
    }
}