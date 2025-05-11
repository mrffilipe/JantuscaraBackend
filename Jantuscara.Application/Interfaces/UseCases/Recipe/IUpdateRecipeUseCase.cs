using Jantuscara.Application.DTOs.Recipe;

namespace Jantuscara.Application.Interfaces.UseCases.Recipe
{
    public interface IUpdateRecipeUseCase
    {
        Task<string> ExecuteAsync(Guid id, UpdateRecipeDto dto);
    }
}
