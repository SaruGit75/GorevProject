using System;
using System.ComponentModel.DataAnnotations;

namespace Gorev.Models
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        [ScaffoldColumn(false)]
        public DateTime DateCreate { get; set; }
        [ScaffoldColumn(false)]
        public DateTime DateLastChange { get; set; }
        [ScaffoldColumn(false)]
        [StringLength(255)]
        public string CreatedById { get; set; }
        [ScaffoldColumn(false)]
        [StringLength(255)]
        public string ChangeById { get; set; }
        [ScaffoldColumn(false)]
        public bool IsRemoved { get; set; } = false;
    }
}
