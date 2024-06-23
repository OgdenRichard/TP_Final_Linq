namespace TP_Final_Linq.DAL
{
    public class Pizza : Food
    {
        // ONE TO ONE
        public long? DoughId { get; set; }
        public Dough Dough { get; set; }

        public ICollection<Ingredient> Ingredients { get; set; }
    }
}
