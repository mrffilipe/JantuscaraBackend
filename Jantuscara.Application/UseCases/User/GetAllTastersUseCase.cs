using Jantuscara.Application.DTOs.User;
using Jantuscara.Application.Interfaces.UseCases.User;
using Jantuscara.Domain.Interfaces;

namespace Jantuscara.Application.UseCases.User
{
    public class GetAllTastersUseCase : IGetAllTastersUseCase
    {
        private readonly IUserRepository _repository;

        public GetAllTastersUseCase(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<TasterDto>> ExecuteAsync()
        {
            var result = await _repository.GetAllTastersAsync();

            return result.Select(r => new TasterDto
            {
                Id = r.Id,
                Name = r.Name,
                ContractDate = r.ContractDate
            });
        }
    }
}
