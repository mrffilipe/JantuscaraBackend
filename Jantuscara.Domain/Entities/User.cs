using Jantuscara.Domain.Common;

namespace Jantuscara.Domain.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; protected set; } = string.Empty;
        public DateOnly ContractDate { get; protected set; }

        protected User()
        {
        }

        protected User(string name, DateOnly contractDate)
        {
            Name = name;
            ContractDate = contractDate;
        }

        protected void UpdateInfo(string name, DateOnly contractDate)
        {
            Name = name;
            ContractDate = contractDate;
        }
    }
}
