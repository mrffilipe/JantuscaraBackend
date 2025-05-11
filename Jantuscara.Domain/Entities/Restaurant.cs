using Jantuscara.Domain.Common;

namespace Jantuscara.Domain.Entities
{
    public class Restaurant : BaseEntity
    {
        public string Name { get; private set; }
        public string Resume { get; private set; }

        public ICollection<Chef> Chefs { get; private set; }

        private Restaurant()
        {
        }
    }
}
