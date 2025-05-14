using Jantuscara.Domain.Common;

namespace Jantuscara.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string Description { get; private set; } = string.Empty;

        public ICollection<Recipe> Recipes { get; private set; } = [];

        private Category()
        {
        }

        public Category(string description)
        {
            Description = description;
        }

        public void UpdateDescription(string description)
        {
            Description = description;
        }
    }
}
