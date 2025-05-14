using Jantuscara.Application.Common;
using Jantuscara.Application.DTOs.Ingredient;
using Jantuscara.Application.Interfaces.UseCases.Ingredient;
using Microsoft.AspNetCore.Mvc;

namespace Jantuscara.API.Controller
{
    public class IngredientController : BaseController
    {
        private readonly IAddIngredientUseCase _addIngredientUseCase;
        private readonly IGetIngredientByIdUseCase _getIngredientByIdUseCase;
        private readonly IGetAllIngredientsUseCase _getAllIngredientsUseCase;
        private readonly IUpdateIngredientUseCase _updateIngredientUseCase;
        private readonly IDeleteIngredientUseCase _deleteIngredientUseCase;

        public IngredientController(
            IAddIngredientUseCase addIngredientUseCase,
            IGetIngredientByIdUseCase getIngredientByIdUseCase,
            IGetAllIngredientsUseCase getAllIngredientsUseCase,
            IUpdateIngredientUseCase updateIngredientUseCase,
            IDeleteIngredientUseCase deleteIngredientUseCase)
        {
            _addIngredientUseCase = addIngredientUseCase;
            _getIngredientByIdUseCase = getIngredientByIdUseCase;
            _getAllIngredientsUseCase = getAllIngredientsUseCase;
            _updateIngredientUseCase = updateIngredientUseCase;
            _deleteIngredientUseCase = deleteIngredientUseCase;
        }

        [HttpPost]
        public async Task<ActionResult<IMessageResponse>> AddIngredient([FromBody] AddIngredientDto dto)
        {
            var result = await _addIngredientUseCase.ExecuteAsync(dto);
            return Ok(result);
        }

        [HttpGet]
        [Route("{ingredientId:guid}")]
        public async Task<ActionResult<IngredientDto?>> GetIngredientById(Guid ingredientId)
        {
            var result = await _getIngredientByIdUseCase.ExecuteAsync(ingredientId);
            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<IngredientDto>>> GetAllIngredient()
        {
            var result = await _getAllIngredientsUseCase.ExecuteAsync();
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult<IMessageResponse>> UpdateIngredient([FromBody] UpdateIngredientDto dto)
        {
            var result = await _updateIngredientUseCase.ExecuteAsync(dto);
            return Ok(result);
        }

        [HttpDelete]
        [Route("{ingredientId:guid}")]
        public async Task<ActionResult<IMessageResponse>> DeleteIngredient(Guid ingredientId)
        {
            var result = await _deleteIngredientUseCase.ExecuteAsync(ingredientId);
            return Ok(result);
        }
    }
}
