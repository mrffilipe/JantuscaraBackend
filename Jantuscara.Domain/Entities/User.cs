using Jantuscara.Domain.Common;

namespace Jantuscara.Domain.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; private set; }
        public DateTime ContractDate { get; private set; }
    }
}
