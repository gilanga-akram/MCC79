using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MCC79.Models
{
    [Table("tb_m_countries")]
    public class Countries
    {
        [Key, Column("id")]
        public int Id { get; set; }
        [Required, Column("name"), MaxLength(40)]
        public string Name { get; set; }
        [Required, Column("region_id")]
        public int RegionId { get; set; }
    }
}
