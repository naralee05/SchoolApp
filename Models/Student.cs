using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolApp.Models
{
    [Table("tbl_Students")]
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string FullName { get; set; } = string.Empty;
        [Required]
        public int MajorId { get; set; }
        [ForeignKey("MajorId")]
        public Major Major { get; set; } = null!;
    }
}