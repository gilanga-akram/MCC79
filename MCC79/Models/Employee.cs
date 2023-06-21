using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace MCC79.Models
{
    [Table("tb_m_employees")]
    public class Employee
    {
        [Key, Column("id")]
        public int Id { get; set; }
        [Required, Column("first_name"),MaxLength(10)]
        public string FirstName { get; set; }
        [Column("last_name"), MaxLength(10)]
        public string LastName { get; set; }
        [Required, Column ("email") , MaxLength(25)]
        public string Email { get; set; }
        [Required, Column ("phone_number"), MaxLength(12)]
        public string PhoneNumber { get; set; }
        [Required, Column ("hire_date")]
         public DateTime HireDate { get; set; }
        [Required, Column ("salary")]
        public int salary { get; set; }
        [Column ("commision_pct")]
        public float CommisionPct { get; set; }
        [Required, Column("manager_id")]
        public int ManagerId { get; set; }
        [Required, Column("job_id"), MaxLength(2)]
        public string JobId{ get; set; }
        [Required, Column("department_id")]
        public int DepartmentId { get; set; }



    }
}
