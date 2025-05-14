using Jantuscara.Domain.Common;

namespace Jantuscara.Domain.Entities
{
    public class Book : BaseEntity
    {
        public string Title { get; private set; } = string.Empty;
        public string ISBN { get; private set; } = string.Empty;

        public Guid EditorId { get; private set; }
        public Editor Editor { get; private set; } = null!;

        public ICollection<Recipe> Recipes { get; private set; } = [];

        private Book()
        {
        }

        public Book(string title, string iSBN, Guid editorId)
        {
            Title = title;
            ISBN = iSBN;
            EditorId = editorId;
        }

        public void UpdateInfo(string title, string isbn)
        {
            Title = title;
            ISBN = isbn;
        }
    }
}
