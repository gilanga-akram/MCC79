using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MCC79.Models
{
    [Table("tb_m_jobs")]
    public class Jobs
    {
        [Key, Column("id")]
        public int Id { get; set; }
        [Required, Column("title"), MaxLength(50)]
        public string Title { get; set; }
        [Required, Column("min_salary")]
        public int MinSalary { get; set; }
        [Required, Column("max_salary")]
        public int MaxSalary { get; set;}
        
    }
}
