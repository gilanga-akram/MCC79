using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MCC79.Models
{
    [Table("tb_m_locations")]
    public class Locations
    {
        [Key, Column("id")]
        public int Id { get; set; }
        [Required, Column("street_address"), MaxLength(40)]
        public string StreetAddress { get; set; }
        [Required, Column("postal_code"), MaxLength(20)]
        public string PostalCode { get; set; }
        [Required, Column("city"), MaxLength(30)]
        public string City { get; set; }
        [Required, Column("state_province"), MaxLength(30)]
        public string StateProvince { get; set; }
        [Required, Column("country_id"), MaxLength(2)]
        public string CountryId { get; set; }



    }
}
