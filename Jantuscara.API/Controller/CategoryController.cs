using Jantuscara.Application.Common;
using Jantuscara.Application.DTOs.Category;
using Jantuscara.Application.Interfaces.UseCases.Category;
using Microsoft.AspNetCore.Mvc;

namespace Jantuscara.API.Controller
{
    public class CategoryController : BaseController
    {
        private readonly IAddCategoryUseCase _addCategoryUseCase;
        private readonly IGetCategoryByIdUseCase _getCategoryByIdUseCase;
        private readonly IGetAllCategoriesUseCase _getAllCategoriesUseCase;
        private readonly IUpdateCategoryUseCase _updateCategoryUseCase;
        private readonly IDeleteCategoryUseCase _deleteCategoryUseCase;

        public CategoryController(
            IAddCategoryUseCase addCategoryUseCase,
            IGetCategoryByIdUseCase getCategoryByIdUseCase,
            IGetAllCategoriesUseCase getAllCategoriesUseCase,
            IUpdateCategoryUseCase updateCategoryUseCase,
            IDeleteCategoryUseCase deleteCategoryUseCase)
        {
            _addCategoryUseCase = addCategoryUseCase;
            _getCategoryByIdUseCase = getCategoryByIdUseCase;
            _getAllCategoriesUseCase = getAllCategoriesUseCase;
            _updateCategoryUseCase = updateCategoryUseCase;
            _deleteCategoryUseCase = deleteCategoryUseCase;
        }

        [HttpPost]
        public async Task<ActionResult<IMessageResponse>> AddCategory([FromBody] AddCategoryDto dto)
        {
            var result = await _addCategoryUseCase.ExecuteAsync(dto);
            return Ok(result);
        }

        [HttpGet]
        [Route("{categoryId:guid}")]
        public async Task<ActionResult<CategoryDto?>> GetCategoryById(Guid categoryId)
        {
            var result = await _getCategoryByIdUseCase.ExecuteAsync(categoryId);
            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoryDto>>> GetAllCategories()
        {
            var result = await _getAllCategoriesUseCase.ExecuteAsync();
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult<IMessageResponse>> UpdateCategory([FromBody] UpdateCategoryDto dto)
        {
            var result = await _updateCategoryUseCase.ExecuteAsync(dto);
            return Ok(result);
        }

        [HttpDelete]
        [Route("{categoryId:guid}")]
        public async Task<ActionResult<IMessageResponse>> DeleteCategory(Guid categoryId)
        {
            var result = await _deleteCategoryUseCase.ExecuteAsync(categoryId);
            return Ok(result);
        }
    }
}
