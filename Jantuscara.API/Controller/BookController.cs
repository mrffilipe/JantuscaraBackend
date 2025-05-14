using Jantuscara.Application.Common;
using Jantuscara.Application.DTOs.Book;
using Jantuscara.Application.Interfaces.UseCases.Book;
using Microsoft.AspNetCore.Mvc;

namespace Jantuscara.API.Controller
{
    public class BookController : BaseController
    {
        private readonly IAddBookUseCase _addBookUseCase;
        private readonly IGetBookByIdUseCase _getBookByIdUseCase;
        private readonly IGetAllBooksUseCase _getAllBooksUseCase;
        private readonly IUpdateBookUseCase _updateBookUseCase;
        private readonly IDeleteBookUseCase _deleteBookUseCase;

        public BookController(
            IAddBookUseCase addBookUseCase,
            IGetBookByIdUseCase getBookByIdUseCase,
            IGetAllBooksUseCase getAllBooksUseCase,
            IUpdateBookUseCase updateBookUseCase,
            IDeleteBookUseCase deleteBookUseCase)
        {
            _addBookUseCase = addBookUseCase;
            _getBookByIdUseCase = getBookByIdUseCase;
            _getAllBooksUseCase = getAllBooksUseCase;
            _updateBookUseCase = updateBookUseCase;
            _deleteBookUseCase = deleteBookUseCase;
        }

        [HttpPost]
        public async Task<ActionResult<IMessageResponse>> AddBook([FromBody] AddBookDto dto)
        {
            var result = await _addBookUseCase.ExecuteAsync(dto);
            return Ok(result);
        }

        [HttpGet]
        [Route("{bookId:guid}")]
        public async Task<ActionResult<BookDto?>> GetBookById(Guid bookId)
        {
            var result = await _getBookByIdUseCase.ExecuteAsync(bookId);
            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookDto>>> GetAllBook()
        {
            var result = await _getAllBooksUseCase.ExecuteAsync();
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult<IMessageResponse>> UpdateBook([FromBody] UpdateBookDto dto)
        {
            var result = await _updateBookUseCase.ExecuteAsync(dto);
            return Ok(result);
        }

        [HttpDelete]
        [Route("{bookId:guid}")]
        public async Task<ActionResult<IMessageResponse>> DeleteBook(Guid bookId)
        {
            var result = await _deleteBookUseCase.ExecuteAsync(bookId);
            return Ok(result);
        }
    }
}
