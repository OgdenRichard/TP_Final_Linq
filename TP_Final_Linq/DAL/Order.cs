using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TP_Final_Linq.DAL
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long OrderId { get; set; }

        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public Status Status { get; set; }

        public long UserId { get; set; }
        public User User { get; set; }

        public long DeliveryAddressId { get; set; }
        public Adress Adress {  get; set; }

        public ICollection<Product> Products { get; set; }

    }
}
