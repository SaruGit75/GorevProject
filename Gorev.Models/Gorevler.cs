using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Gorev.Models
{
    public class Gorevler : BaseEntity
    {
        [Required]
        [StringLength(255)]
        [Display(Name = "Görev Adı")]
        public string GorevAdi { get; set; }
        [Display(Name = "Tamamlandı Mı?")]
        public bool IsCompleted { get; set; } = false;
    }
}
