using Jantuscara.Application.Common;
using Jantuscara.Application.DTOs.Recipe;
using Jantuscara.Application.Interfaces.UseCases.Recipe;
using Jantuscara.Domain.Interfaces;

namespace Jantuscara.Application.UseCases.Recipe
{
    public class UpdateRecipeUseCase : IUpdateRecipeUseCase
    {
        private readonly IRecipeRepository _repository;

        public UpdateRecipeUseCase(IRecipeRepository repository)
        {
            _repository = repository;
        }

        public async Task<IMessageResponse> ExecuteAsync(UpdateRecipeDto dto)
        {
            var result = await _repository.GetRecipeByIdAsync(dto.Id);

            if (result == null)
            {
                throw new Exception("Receita não encontrada.");
            }

            result.UpdateInfo(dto.Name, dto.CreationDate);

            await _repository.SaveChangesAsync();

            return new MessageResponse
            {
                Message = $"Receita '{dto.Name}' atualizada com sucesso!"
            };
        }
    }
}
