using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MCC79.Models
{
    [Table("tb_m_regions")]
    public class Regions
    {
        [Key, Column("id")]
        public int Id { get; set; }
        [Required, Column("name_varchar"), MaxLength(20)]
        public string Name { get; set; }
    }
}
