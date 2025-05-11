using Jantuscara.Domain.Common;

namespace Jantuscara.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string Description { get; private set; }

        public ICollection<Recipe> Recipes { get; private set; }

        private Category()
        {
        }
    }
}
