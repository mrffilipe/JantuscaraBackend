using Jantuscara.Domain.Common;

namespace Jantuscara.Domain.Entities
{
    public class Book : BaseEntity
    {
        public string Title { get; private set; }
        public string ISBN { get; private set; }

        public Guid EditorId { get; private set; }
        public Editor Editor { get; private set; }

        public ICollection<Recipe> IncludedRecipes { get; private set; }
    }
}
