using Jantuscara.Application.Common;
using Jantuscara.Application.DTOs.User;
using Jantuscara.Application.Interfaces.UseCases.User;
using Microsoft.AspNetCore.Mvc;

namespace Jantuscara.API.Controller
{
    public class UserController : BaseController
    {
        private readonly IAddChefUseCase _addChefUseCase;
        private readonly IGetChefByIdUseCase _getChefByIdUseCase;
        private readonly IGetAllChefsUseCase _getAllChefsUseCase;
        private readonly IUpdateChefUseCase _updateChefUseCase;
        private readonly IDeleteChefUseCase _deleteChefUseCase;

        private readonly IAddTasterUseCase _addTasterUseCase;
        private readonly IGetTasterByIdUseCase _getTasterByIdUseCase;
        private readonly IGetAllTastersUseCase _getAllTastersUseCase;
        private readonly IUpdateTasterUseCase _updateTasterUseCase;
        private readonly IDeleteTasterUseCase _deleteTasterUseCase;

        private readonly IAddEditorUseCase _addEditorUseCase;
        private readonly IGetEditorByIdUseCase _getEditorByIdUseCase;
        private readonly IGetAllEditorsUseCase _getAllEditorsUseCase;
        private readonly IUpdateEditorUseCase _updateEditorUseCase;
        private readonly IDeleteEditorUseCase _deleteEditorUseCase;

        public UserController(
            IAddChefUseCase addChefUseCase,
            IGetChefByIdUseCase getChefByIdUseCase,
            IGetAllChefsUseCase getAllChefsUseCase,
            IUpdateChefUseCase updateChefUseCase,
            IDeleteChefUseCase deleteChefUseCase,
            IAddTasterUseCase addTasterUseCase,
            IGetTasterByIdUseCase getTasterByIdUseCase,
            IGetAllTastersUseCase getAllTastersUseCase,
            IUpdateTasterUseCase updateTasterUseCase,
            IDeleteTasterUseCase deleteTasterUseCase,
            IAddEditorUseCase addEditorUseCase,
            IGetEditorByIdUseCase getEditorByIdUseCase,
            IGetAllEditorsUseCase getAllEditorsUseCase,
            IUpdateEditorUseCase updateEditorUseCase,
            IDeleteEditorUseCase deleteEditorUseCase)
        {
            _addChefUseCase = addChefUseCase;
            _getChefByIdUseCase = getChefByIdUseCase;
            _getAllChefsUseCase = getAllChefsUseCase;
            _updateChefUseCase = updateChefUseCase;
            _deleteChefUseCase = deleteChefUseCase;
            _addTasterUseCase = addTasterUseCase;
            _getTasterByIdUseCase = getTasterByIdUseCase;
            _getAllTastersUseCase = getAllTastersUseCase;
            _updateTasterUseCase = updateTasterUseCase;
            _deleteTasterUseCase = deleteTasterUseCase;
            _addEditorUseCase = addEditorUseCase;
            _getEditorByIdUseCase = getEditorByIdUseCase;
            _getAllEditorsUseCase = getAllEditorsUseCase;
            _updateEditorUseCase = updateEditorUseCase;
            _deleteEditorUseCase = deleteEditorUseCase;
        }

        [HttpPost]
        [Route("chef")]
        public async Task<ActionResult<IMessageResponse>> AddChef([FromBody] AddChefDto dto)
        {
            var result = await _addChefUseCase.ExecuteAsync(dto);
            return Ok(result);
        }

        [HttpGet]
        [Route("chef/{chefId:guid}")]
        public async Task<ActionResult<ChefDto?>> GetChefById(Guid chefId)
        {
            var result = await _getChefByIdUseCase.ExecuteAsync(chefId);
            return Ok(result);
        }

        [HttpGet]
        [Route("chef")]
        public async Task<ActionResult<IEnumerable<ChefDto>>> GetAllChef()
        {
            var result = await _getAllChefsUseCase.ExecuteAsync();
            return Ok(result);
        }

        [HttpPut]
        [Route("chef")]
        public async Task<ActionResult<IMessageResponse>> UpdateChef([FromBody] UpdateChefDto dto)
        {
            var result = await _updateChefUseCase.ExecuteAsync(dto);
            return Ok(result);
        }

        [HttpDelete]
        [Route("chef/{chefId:guid}")]
        public async Task<ActionResult<IMessageResponse>> DeleteChef(Guid chefId)
        {
            var result = await _deleteChefUseCase.ExecuteAsync(chefId);
            return Ok(result);
        }

        [HttpPost]
        [Route("taster")]
        public async Task<ActionResult<IMessageResponse>> AddTaster([FromBody] AddTasterDto dto)
        {
            var result = await _addTasterUseCase.ExecuteAsync(dto);
            return Ok(result);
        }

        [HttpGet]
        [Route("taster/{tasterId:guid}")]
        public async Task<ActionResult<TasterDto?>> GetTasterById(Guid tasterId)
        {
            var result = await _getTasterByIdUseCase.ExecuteAsync(tasterId);
            return Ok(result);
        }

        [HttpGet]
        [Route("taster")]
        public async Task<ActionResult<IEnumerable<TasterDto>>> GetAllTaster()
        {
            var result = await _getAllTastersUseCase.ExecuteAsync();
            return Ok(result);
        }

        [HttpPut]
        [Route("taster")]
        public async Task<ActionResult<IMessageResponse>> UpdateTaster([FromBody] UpdateTasterDto dto)
        {
            var result = await _updateTasterUseCase.ExecuteAsync(dto);
            return Ok(result);
        }

        [HttpDelete]
        [Route("taster/{tasterId:guid}")]
        public async Task<ActionResult<IMessageResponse>> DeleteTaster(Guid tasterId)
        {
            var result = await _deleteTasterUseCase.ExecuteAsync(tasterId);
            return Ok(result);
        }

        [HttpPost]
        [Route("editor")]
        public async Task<ActionResult<IMessageResponse>> AddEditor([FromBody] AddEditorDto dto)
        {
            var result = await _addEditorUseCase.ExecuteAsync(dto);
            return Ok(result);
        }

        [HttpGet]
        [Route("editor/{editorId:guid}")]
        public async Task<ActionResult<EditorDto?>> GetEditorById(Guid editorId)
        {
            var result = await _getEditorByIdUseCase.ExecuteAsync(editorId);
            return Ok(result);
        }

        [HttpGet]
        [Route("editor")]
        public async Task<ActionResult<IEnumerable<EditorDto>>> GetAllEditor()
        {
            var result = await _getAllEditorsUseCase.ExecuteAsync();
            return Ok(result);
        }

        [HttpPut]
        [Route("editor")]
        public async Task<ActionResult<IMessageResponse>> UpdateEditor([FromBody] UpdateEditorDto dto)
        {
            var result = await _updateEditorUseCase.ExecuteAsync(dto);
            return Ok(result);
        }

        [HttpDelete]
        [Route("editor/{editorId:guid}")]
        public async Task<ActionResult<IMessageResponse>> DeleteEditor(Guid editorId)
        {
            var result = await _deleteEditorUseCase.ExecuteAsync(editorId);
            return Ok(result);
        }
    }
}
