using Jantuscara.Application.DTOs.Recipe;
using Jantuscara.Application.Interfaces.UseCases.Recipe;
using Microsoft.AspNetCore.Mvc;

namespace Jantuscara.API.Controller
{
    public class RecipeController : BaseController
    {
        //private readonly IAddRecipeTestUseCase _addRecipeTestUseCase;
        private readonly ICreateRecipeUseCase _createRecipeUseCase;
        //private readonly IDeleteRecipeUseCase _deleteRecipeUseCase;
        //private readonly IGetRecipeByIdUseCase _getRecipeByIdUseCase;
        //private readonly IUpdateRecipeUseCase _updateRecipeUseCase;

        public RecipeController(
            ICreateRecipeUseCase createRecipeUseCase)
            //IAddRecipeTestUseCase addRecipeTestUseCase,
            //IDeleteRecipeUseCase deleteRecipeUseCase,
            //IGetRecipeByIdUseCase getRecipeByIdUseCase,
            //IUpdateRecipeUseCase updateRecipeUseCase)
        {
            //_addRecipeTestUseCase = addRecipeTestUseCase;
            _createRecipeUseCase = createRecipeUseCase;
            //_deleteRecipeUseCase = deleteRecipeUseCase;
            //_getRecipeByIdUseCase = getRecipeByIdUseCase;
            //_updateRecipeUseCase = updateRecipeUseCase;
        }

        //[HttpGet]
        //[Route("{id:guid}")]
        //public async Task<ActionResult<RecipeDetailsDto>> GetRecipeById(Guid id)
        //{
        //    var result = await _getRecipeByIdUseCase.ExecuteAsync(id);
        //    return Ok(result);
        //}

        [HttpPost]
        public async Task<ActionResult<string>> CreateRecipe([FromBody] CreateRecipeDto dto)
        {
            var result = await _createRecipeUseCase.ExecuteAsync(dto);
            return Ok(result);
        }

        //[HttpPut]
        //[Route("{id:guid}")]
        //public async Task<ActionResult<string>> UpdateRecipe(Guid id, [FromBody] UpdateRecipeDto dto)
        //{
        //    var result = await _updateRecipeUseCase.ExecuteAsync(id, dto);
        //    return Ok(result);
        //}

        //[HttpDelete]
        //[Route("{id:guid}")]
        //public async Task<ActionResult<string>> DeleteRecipe(Guid id)
        //{
        //    var result = await _deleteRecipeUseCase.ExecuteAsync(id);
        //    return Ok(result);
        //}
    }
}
