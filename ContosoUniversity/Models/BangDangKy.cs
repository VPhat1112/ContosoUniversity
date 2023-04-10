using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public enum Kind
    {
        Sang,Chieu
    }
    public class BangDangKy
    {
        [Key] public int EnrollmentID { get; set; }

        public int IdCalam { get; set; }
        public int IDCongNhan { get; set; }
        [DisplayFormat(NullDisplayText = "No Kind")]
        public Kind? kind { get; set; }

        public Calam calam { get; set; }
        public CongNhan congNhan { get; set; }
    }
}
