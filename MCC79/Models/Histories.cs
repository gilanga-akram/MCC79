using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MCC79.Models
{
    [Table("tb_hr_histories")]
    public class Histories
    {
        [Key, Column("start_date")]
        public DateTime StartDate { get; set; }
        [Key, Column("employee_id")]
        public int EmployeeId { get; set; }
        [Required, Column("end_date")]
        public DateTime EndDate { get; set; }
        [Required, Column("department_id")]
        public int DepartmentId { get; set; }
        [Required, Column("job_id"), MaxLength(2)]
        public string JobId { get; set; }

    }
}
