using Jantuscara.Application.DTOs.User;
using Jantuscara.Application.Interfaces.UseCases.User;
using Jantuscara.Domain.Interfaces;

namespace Jantuscara.Application.UseCases.User
{
    public class GetChefChampionByYearUseCase : IGetChefChampionByYearUseCase
    {
        private readonly IUserRepository _repository;

        public GetChefChampionByYearUseCase(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<ChefChampionDto>> ExecuteAsync(int year)
        {
            var chefs = await _repository.GetAllChefsByYearAsync(year);

            if (chefs == null || !chefs.Any())
            {
                throw new Exception("Não há cozinheiros para este ano.");
            }

            // Projeção para calcular a quantidade de receitas
            var chefDtos = chefs.Select(chef => new ChefChampionDto
            {
                Id = chef.Id,
                Name = chef.Name,
                ContractDate = chef.ContractDate,
                TradeName = chef.TradeName,
                RestaurantId = chef.RestaurantId,
                QuantityRecipe = chef.Recipes.Count
            }).ToList();

            // Calcula o maior número de receitas
            var maxRecipes = chefDtos.Max(c => c.QuantityRecipe);

            // Retorna somente os campeões (com maior número de receitas)
            var champions = chefDtos.Where(c => c.QuantityRecipe == maxRecipes);

            return champions;
        }

    }
}
