using Jantuscara.Application.DTOs.Recipe;

namespace Jantuscara.Application.Interfaces.UseCases.Recipe
{
    public interface ICreateRecipeUseCase
    {
        Task<string> ExecuteAsync(CreateRecipeDto dto);
    }
}
