namespace Jantuscara.Domain.Entities
{
    public class Chef : User
    {
        public string TradeName { get; private set; } = string.Empty;

        public Guid RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; } = null!;

        public ICollection<Recipe> Recipes { get; private set; } = [];

        private Chef()
        {
        }

        public Chef(
            string name,
            DateOnly contractDate,
            string tradeName,
            Guid restaurantId) : base(
            name,
            contractDate)
        {
            TradeName = tradeName;
            RestaurantId = restaurantId;
        }

        public void UpdateTradeName(string tradeName)
        {
            TradeName = tradeName;
        }
    }
}
