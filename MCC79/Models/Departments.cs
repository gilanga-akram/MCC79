using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MCC79.Models
{
    [Table("tb_m_departments")]
    public class Departments
    {
        [Key,Column("id")]
        public int Id { get; set; }
        [Required, Column("name"), MaxLength(30)]
        public string Name { get; set; }
        [Required, Column("location_id"),]
        public int LocationId { get; set; }
        [Required, Column("manager_id")]
        public int ManagerId { get; set; }

    }
}
