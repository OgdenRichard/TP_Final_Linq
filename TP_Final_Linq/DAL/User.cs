using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TP_Final_Linq.DAL
{
    public class User
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long UserId { get; set; }

        [MaxLength(50)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
        [MaxLength(255)]
        public string Mail { get; set; }

        // ONE TO MANY
        public long AdresseId { get; set; }
        public Adress Adresse { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
