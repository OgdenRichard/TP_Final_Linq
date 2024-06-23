using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TP_Final_Linq.DAL
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ProductId { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        public float Price { get; set; }

        //many to many
        public ICollection<Order> Orders { get; set; }

    }
}
