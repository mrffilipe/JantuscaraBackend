using Jantuscara.Application.Common;
using Jantuscara.Application.DTOs.Book;
using Jantuscara.Application.Interfaces.UseCases.Book;
using Jantuscara.Domain.Interfaces;

namespace Jantuscara.Application.UseCases.Book
{
    public class UpdateBookUseCase : IUpdateBookUseCase
    {
        private readonly IBookRepository _repository;

        public UpdateBookUseCase(IBookRepository repository)
        {
            _repository = repository;
        }

        public async Task<IMessageResponse> ExecuteAsync(UpdateBookDto dto)
        {
            var result = await _repository.GetBookByIdAsync(dto.Id);

            if (result == null)
            {
                throw new Exception("Livro não encontrado.");
            }

            result.UpdateInfo(dto.Title, dto.ISBN);

            await _repository.SaveChangesAsync();

            return new MessageResponse
            {
                Message = $"Livro '{dto.Title}' atualizado com sucesso!"
            };
        }
    }
}
