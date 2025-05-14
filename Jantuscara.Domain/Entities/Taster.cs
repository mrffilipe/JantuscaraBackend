namespace Jantuscara.Domain.Entities
{
    public class Taster : User
    {
        public ICollection<RecipeTaster> Recipes { get; private set; } = [];

        private Taster()
        {
        }

        public Taster(string name, DateOnly contractDate) : base(
            name,
            contractDate)
        {
        }
    }
}
