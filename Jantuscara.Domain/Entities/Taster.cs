namespace Jantuscara.Domain.Entities
{
    public class Taster : User
    {
        public ICollection<Recipe> TestedRecipes { get; private set; }

        private Taster()
        {
        }
    }
}
