using Jantuscara.Application.Common;
using Jantuscara.Application.DTOs.Recipe;
using Jantuscara.Application.Interfaces.UseCases.Recipe;
using Microsoft.AspNetCore.Mvc;

namespace Jantuscara.API.Controller
{
    public class RecipeController : BaseController
    {
        private readonly IAddRecipeUseCase _addRecipeUseCase;
        private readonly IGetRecipeByIdUseCase _getRecipeByIdUseCase;
        private readonly IGetAllRecipesUseCase _getAllRecipesUseCase;
        private readonly IUpdateRecipeUseCase _updateRecipeUseCase;
        private readonly IDeleteRecipeUseCase _deleteRecipeUseCase;

        public RecipeController(
            IAddRecipeUseCase addRecipeUseCase,
            IGetRecipeByIdUseCase getRecipeByIdUseCase,
            IGetAllRecipesUseCase getAllRecipesUseCase,
            IUpdateRecipeUseCase updateRecipeUseCase,
            IDeleteRecipeUseCase deleteRecipeUseCase)
        {
            _addRecipeUseCase = addRecipeUseCase;
            _getRecipeByIdUseCase = getRecipeByIdUseCase;
            _getAllRecipesUseCase = getAllRecipesUseCase;
            _updateRecipeUseCase = updateRecipeUseCase;
            _deleteRecipeUseCase = deleteRecipeUseCase;
        }

        [HttpPost]
        public async Task<ActionResult<IMessageResponse>> AddRecipe([FromBody] AddRecipeDto dto)
        {
            var result = await _addRecipeUseCase.ExecuteAsync(dto);
            return Ok(result);
        }

        [HttpGet]
        [Route("{recipeId:guid}")]
        public async Task<ActionResult<RecipeDto>> GetRecipeById(Guid recipeId)
        {
            var result = await _getRecipeByIdUseCase.ExecuteAsync(recipeId);
            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult<RecipeDto>> GetAllRecipe()
        {
            var result = await _getAllRecipesUseCase.ExecuteAsync();
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult<IMessageResponse>> UpdateRecipe([FromBody] UpdateRecipeDto dto)
        {
            var result = await _updateRecipeUseCase.ExecuteAsync(dto);
            return Ok(result);
        }

        [HttpDelete]
        [Route("{recipeId:guid}")]
        public async Task<ActionResult<RecipeDto>> DeleteRecipe(Guid recipeId)
        {
            var result = await _deleteRecipeUseCase.ExecuteAsync(recipeId);
            return Ok(result);
        }
    }
}
