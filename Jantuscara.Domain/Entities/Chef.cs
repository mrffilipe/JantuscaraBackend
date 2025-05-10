namespace Jantuscara.Domain.Entities
{
    public class Chef : User
    {
        public string TradeName { get; private set; }

        public Guid RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }

        public ICollection<Recipe> CreatedRecipes { get; private set; }
    }
}
