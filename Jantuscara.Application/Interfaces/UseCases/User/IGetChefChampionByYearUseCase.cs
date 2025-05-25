using Jantuscara.Application.DTOs.User;

namespace Jantuscara.Application.Interfaces.UseCases.User
{
    public interface IGetChefChampionByYearUseCase
    {
        Task<IEnumerable<ChefChampionDto>> ExecuteAsync(int year);
    }
}
