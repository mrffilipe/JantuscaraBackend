using Jantuscara.Domain.Common;

namespace Jantuscara.Domain.Entities
{
    public class Restaurant : BaseEntity
    {
        public string Name { get; private set; } = string.Empty;
        public string Resume { get; private set; } = string.Empty;

        public ICollection<Chef> Chefs { get; private set; } = [];

        private Restaurant()
        {
        }

        public Restaurant(string name, string resume)
        {
            Name = name;
            Resume = resume;
        }

        public void UpdateInfo(string name, string resume)
        {
            Name = name;
            Resume = resume;
        }
    }
}
