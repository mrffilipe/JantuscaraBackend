using Jantuscara.Application.Common;
using Jantuscara.Application.DTOs.Ingredient;

namespace Jantuscara.Application.Interfaces.UseCases.Ingredient
{
    public interface IUpdateIngredientUseCase
    {
        Task<IMessageResponse> ExecuteAsync(UpdateIngredientDto dto);
    }
}