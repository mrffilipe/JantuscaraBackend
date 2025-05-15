using Jantuscara.Application.DTOs.User;
using Jantuscara.Application.Interfaces.UseCases.User;
using Jantuscara.Domain.Interfaces;

namespace Jantuscara.Application.UseCases.User
{
    public class GetAllEditorsUseCase : IGetAllEditorsUseCase
    {
        private readonly IUserRepository _repository;

        public GetAllEditorsUseCase(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<EditorDto>> ExecuteAsync()
        {
            var result = await _repository.GetAllEditorsAsync();

            return result.Select(r => new EditorDto
            {
                Id = r.Id,
                Name = r.Name,
                ContractDate = r.ContractDate
            });
        }
    }
}
