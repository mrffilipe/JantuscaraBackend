using Jantuscara.Application.Common;

namespace Jantuscara.Application.Interfaces.UseCases.Ingredient
{
    public interface IDeleteIngredientUseCase
    {
        Task<IMessageResponse> ExecuteAsync(Guid id);
    }
}