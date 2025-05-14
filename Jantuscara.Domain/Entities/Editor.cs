
namespace Jantuscara.Domain.Entities
{
    public class Editor : User
    {
        public ICollection<Book> Books { get; private set; } = [];

        private Editor()
        {
        }

        public Editor(string name, DateOnly contractDate) : base(
            name,
            contractDate)
        {
        }
    }
}
