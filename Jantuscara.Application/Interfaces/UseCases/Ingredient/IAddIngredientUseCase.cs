using Jantuscara.Application.Common;
using Jantuscara.Application.DTOs.Ingredient;

namespace Jantuscara.Application.Interfaces.UseCases.Ingredient
{
    public interface IAddIngredientUseCase
    {
        Task<IMessageResponse> ExecuteAsync(AddIngredientDto dto);
    }
}