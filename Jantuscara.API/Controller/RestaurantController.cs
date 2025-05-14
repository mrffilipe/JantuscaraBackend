using Jantuscara.Application.Common;
using Jantuscara.Application.DTOs.Restaurant;
using Jantuscara.Application.Interfaces.UseCases.Restaurant;
using Microsoft.AspNetCore.Mvc;

namespace Jantuscara.API.Controller
{
    public class RestaurantController : BaseController
    {
        private readonly IAddRestaurantUseCase _addRestaurantUseCase;
        private readonly IGetRestaurantByIdUseCase _getRestaurantByIdUseCase;
        private readonly IGetAllRestaurantsUseCase _getAllRestaurantsUseCase;
        private readonly IUpdateRestaurantUseCase _updateRestaurantUseCase;
        private readonly IDeleteRestaurantUseCase _deleteRestaurantUseCase;

        public RestaurantController(
            IAddRestaurantUseCase addRestaurantUseCase,
            IGetRestaurantByIdUseCase getRestaurantByIdUseCase,
            IGetAllRestaurantsUseCase getAllRestaurantsUseCase,
            IUpdateRestaurantUseCase updateRestaurantUseCase,
            IDeleteRestaurantUseCase deleteRestaurantUseCase)
        {
            _addRestaurantUseCase = addRestaurantUseCase;
            _getRestaurantByIdUseCase = getRestaurantByIdUseCase;
            _getAllRestaurantsUseCase = getAllRestaurantsUseCase;
            _updateRestaurantUseCase = updateRestaurantUseCase;
            _deleteRestaurantUseCase = deleteRestaurantUseCase;
        }

        [HttpPost]
        public async Task<ActionResult<IMessageResponse>> AddRestaurant([FromBody] AddRestaurantDto dto)
        {
            var result = await _addRestaurantUseCase.ExecuteAsync(dto);
            return Ok(result);
        }

        [HttpGet]
        [Route("{restaurantId:guid}")]
        public async Task<ActionResult<RestaurantDto?>> GetRestaurantById(Guid restaurantId)
        {
            var result = await _getRestaurantByIdUseCase.ExecuteAsync(restaurantId);
            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<RestaurantDto>>> GetAllRestaurant()
        {
            var result = await _getAllRestaurantsUseCase.ExecuteAsync();
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult<IMessageResponse>> UpdateRestaurant([FromBody] UpdateRestaurantDto dto)
        {
            var result = await _updateRestaurantUseCase.ExecuteAsync(dto);
            return Ok(result);
        }

        [HttpDelete]
        [Route("{restaurantId:guid}")]
        public async Task<ActionResult<IMessageResponse>> DeleteRestaurant(Guid restaurantId)
        {
            var result = await _deleteRestaurantUseCase.ExecuteAsync(restaurantId);
            return Ok(result);
        }
    }
}
