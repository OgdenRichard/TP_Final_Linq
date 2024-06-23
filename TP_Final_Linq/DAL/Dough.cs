
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TP_Final_Linq.DAL
{
    public class Dough
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long DoughId {  get; set; }

        public string Name {  get; set; }

    }
}
