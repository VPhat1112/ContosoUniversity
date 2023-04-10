using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Calam
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key] public int IdCalam { get; set; }

        public string Title { get; set; }
        public int Credits { get; set; }

        public ICollection<BangDangKy> bangDangKies { get; set; }
    }
}
