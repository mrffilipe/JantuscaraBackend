using Jantuscara.Application.Common;
using Jantuscara.Application.DTOs.Recipe;

namespace Jantuscara.Application.Interfaces.UseCases.Recipe
{
    public interface IAddRecipeUseCase
    {
        Task<IMessageResponse> ExecuteAsync(AddRecipeDto dto);
    }
}
