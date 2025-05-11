namespace Jantuscara.Application.Interfaces.UseCases.Recipe
{
    public interface IDeleteRecipeUseCase
    {
        Task<string> ExecuteAsync(Guid id);
    }
}
