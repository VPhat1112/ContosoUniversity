using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public class CongNhan
    {
        [Key]public int IDCongNhan { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime BirthDay { get; set; }

        public ICollection<BangDangKy> bangDangKies { get; set; }

    }
}
