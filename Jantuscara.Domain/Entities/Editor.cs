namespace Jantuscara.Domain.Entities
{
    public class Editor : User
    {
        public ICollection<Book> EditedBooks { get; private set; }

        private Editor()
        {
        }
    }
}
