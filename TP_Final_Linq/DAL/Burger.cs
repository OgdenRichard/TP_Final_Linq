namespace TP_Final_Linq.DAL
{
    public class Burger : Food
    {
        public ICollection<Ingredient> Ingredients { get; set; }
    }
}
