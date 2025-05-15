using Jantuscara.Application.DTOs.User;
using Jantuscara.Application.Interfaces.UseCases.User;
using Jantuscara.Domain.Interfaces;

namespace Jantuscara.Application.UseCases.User
{
    public class GetTasterByIdUseCase : IGetTasterByIdUseCase
    {
        private readonly IUserRepository _repository;

        public GetTasterByIdUseCase(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<TasterDto?> ExecuteAsync(Guid id)
        {
            var result = await _repository.GetTasterByIdAsync(id);

            if (result == null)
            {
                throw new Exception("Degustador não encontrado.");
            }

            return new TasterDto
            {
                Id = result.Id,
                Name = result.Name,
                ContractDate = result.ContractDate
            };
        }
    }
}
