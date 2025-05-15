using Jantuscara.Application.Common;
using Jantuscara.Application.DTOs.User;
using Jantuscara.Application.Interfaces.UseCases.User;
using Jantuscara.Domain.Entities;
using Jantuscara.Domain.Interfaces;

namespace Jantuscara.Application.UseCases.User
{
    public class AddEditorUseCase : IAddEditorUseCase
    {
        private readonly IUserRepository _repository;

        public AddEditorUseCase(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<IMessageResponse> ExecuteAsync(AddEditorDto dto)
        {
            var newEditor = new Editor(dto.Name, dto.ContractDate);

            await _repository.AddEditorAsync(newEditor);

            return new MessageResponse
            {
                Message = $"Editor '{dto.Name}' criado com sucesso!"
            };
        }
    }
}
