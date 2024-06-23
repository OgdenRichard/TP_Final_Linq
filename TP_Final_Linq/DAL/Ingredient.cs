using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TP_Final_Linq.DAL
{
    public class Ingredient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long IngredientId { get; set; }

        [MaxLength(255)]
        public string Name { get; set; }

        public float Kcal { get; set; }

        public long? PizzaId { get; set; }
        public Pizza Pizza { get; set; }

        public long? BurgerId { get; set; }
        public Burger Burger { get; set; }
    }
}
