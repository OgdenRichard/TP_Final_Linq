using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TP_Final_Linq.DAL
{
    public class Adress
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long AdresseId {  get; set; }

        [MaxLength(255)]
        public string Street { get; set; }

        [MaxLength(255)]
        public string City { get; set; }

        [MaxLength(255)]
        public string State { get; set; }

        [MaxLength(5)]
        public string Zip { get; set; }

        [MaxLength(255)]
        public string Country { get; set; }

        // ONE TO MANY
        public ICollection<User> Users { get; set; }

        // ONE TO MANY
        public ICollection<Order> Orders { get; set; }

    }
}
