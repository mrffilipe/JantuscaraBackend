using Jantuscara.Domain.Entities;

namespace Jantuscara.Domain.Interfaces
{
    public interface IRestaurantRepository
    {
        Task AddRestaurantAsync(Restaurant restaurant);
        Task<Restaurant?> GetRestaurantByIdAsync(Guid restaurantId);
        Task<IEnumerable<Restaurant>> GetAllRestaurantsAsync();
        void DeleteRestaurantAsync(Restaurant restaurant);
        Task SaveChangesAsync();
    }
}
