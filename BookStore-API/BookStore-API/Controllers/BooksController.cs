using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookStore_API.Contracts;
using BookStore_API.Data;
using BookStore_API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore_API.Controllers
{
    /// <summary>
    /// Endpoint used to interact with the Books in the book store's database.
    /// </summary>
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public class BooksController : ControllerBase
    {
        private readonly IBookRepository bookRepository;

        private readonly ILoggerService loggerService;

        private readonly IMapper mapper;

        public BooksController(IBookRepository book, ILoggerService logger, IMapper map)
        {
            this.bookRepository = book;
            this.loggerService = logger;
            this.mapper = map;
        }

        /// <summary>
        /// Gets all the books.
        /// </summary>
        /// <returns>
        ///     List of books.
        /// </returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetBooks()
        {
            try
            {
                this.loggerService.LogInfo($"{this.GetControllerActionNames()}: Attempting call.");
                var books = await this.bookRepository.FindAll();
                var mappedBooks = this.mapper.Map<IList<BookDTO>>(books);

                this.loggerService.LogInfo($"{this.GetControllerActionNames()}: Call Successful");

                return Ok(mappedBooks);
            }
            catch (Exception exc)
            {
                return this.InternalError(exc);
            }
        }

        /// <summary>
        /// Gets a specific book with the given unique identifier.
        /// </summary>
        /// <returns>
        ///     A specific book.
        /// </returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetBook(int id)
        {
            try
            {
                this.loggerService.LogInfo($"{this.GetControllerActionNames()}: Attempt Call");

                var book = await this.bookRepository.FindById(id).ConfigureAwait(false);
                if (book == null)
                {
                    this.loggerService.LogWarning($"{this.GetControllerActionNames()}: Failed to retrieve record with Id: {id}");
                    return NotFound($"No book found with Id - {id}");
                }

                var response = this.mapper.Map<BookDTO>(book);

                this.loggerService.LogInfo($"{this.GetControllerActionNames()}: Successfully got record with id: " + id);

                return Ok(response);
            }
            catch (Exception exc)
            {
                return this.InternalError(exc);
            }
        }

        /// <summary>
        /// Creates a new <see cref="Book"/> from the given <see cref="BookCreateDTO"/>.
        /// </summary>
        /// <param name="bookDTO">
        ///     The <see cref="BookCreateDTO"/> author to create.
        /// </param>
        /// <returns></returns>
        [HttpPost]
        [Authorize(Roles = "Administrator")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Create([FromBody] BookCreateDTO bookDTO)
        {
            try
            {
                this.loggerService.LogInfo($"{this.GetControllerActionNames()}: Create Attempted.");
                if (bookDTO == null)
                {
                    this.loggerService.LogWarning($"{this.GetControllerActionNames()}: Empty Request was submitted.");
                    return BadRequest(ModelState);
                }

                if (!ModelState.IsValid)
                {
                    this.loggerService.LogWarning($"{this.GetControllerActionNames()}: Data was incomplete.");
                    return BadRequest(ModelState);
                }

                var book = this.mapper.Map<Book>(bookDTO);
                var isSuccess = await this.bookRepository.Create(book);
                if (isSuccess)
                {
                    this.loggerService.LogInfo($"{this.GetControllerActionNames()}: Creation was successful.");
                    this.loggerService.LogInfo($"{this.GetControllerActionNames()}: {book}");
                    return Created($"Successfully created Book.", new { book });
                }
                else
                {
                    this.loggerService.LogWarning($"{this.GetControllerActionNames()} : Creation failed.");
                    return StatusCode(StatusCodes.Status500InternalServerError, "Book creation failed.");
                }
            }
            catch (Exception exc)
            {
                return this.InternalError(exc);
            }
        }

        /// <summary>
        /// Updates an existing book with the given identifier and <see cref="BookUpdateDTO"/>.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="bookDTO"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Update(int id, [FromBody] BookUpdateDTO bookDTO)
        {
            try
            {
                this.loggerService.LogInfo($"{this.GetControllerActionNames()}: Update attempted on record with Id: {id}");

                if (id <= 0 || id != bookDTO.Id)
                {
                    this.loggerService.LogWarning($"{this.GetControllerActionNames()}: Update failed with bad data - Id: {id}");
                    return BadRequest("Invalid book identifier passed through.");
                }

                if (bookDTO == null)
                {
                    this.loggerService.LogWarning($"{this.GetControllerActionNames()}: Data was empty");
                    return BadRequest(ModelState);
                }

                if (!ModelState.IsValid)
                {
                    this.loggerService.LogWarning($"{this.GetControllerActionNames()}: Data was incomplete");
                    return BadRequest(ModelState);
                }

                var doesExist = await this.bookRepository.DoesExist(id);
                if (!doesExist)
                {
                    return NotFound($"{this.GetControllerActionNames()}: No record found with Id: {id}");
                }

                var book = this.mapper.Map<Book>(bookDTO);
                var isSuccess = await this.bookRepository.Update(book);
                if (isSuccess)
                {
                    this.loggerService.LogInfo($"{this.GetControllerActionNames()}: Update successful for record with Id: {id}");
                    return NoContent();
                }
                else
                {
                    this.loggerService.LogError($"{this.GetControllerActionNames()}: Update failed for record with Id: {id}");
                    return StatusCode(StatusCodes.Status500InternalServerError, "Book update failed.");
                }
            }
            catch (Exception exc)
            {
                return this.InternalError(exc);
            }
        }

        /// <summary>
        /// Updates an existing author with the given identifier and <see cref="AuthorUpdateDTO"/>.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                this.loggerService.LogInfo($"{this.GetControllerActionNames()}: Delete Attempted on record with Id: {id}");

                if (id <= 0)
                {
                    this.loggerService.LogWarning($"{this.GetControllerActionNames()}: Delete failed with bad data - Id: {id}");
                    return BadRequest("Invalid book identifier passed through.");
                }

                var doesExist = await this.bookRepository.DoesExist(id);
                if (!doesExist)
                {
                    this.loggerService.LogWarning($"{this.GetControllerActionNames()}: Failed to retrieve record with Id: {id}");
                    return NotFound();
                }

                var book = await this.bookRepository.FindById(id);
                var isSuccess = await this.bookRepository.Delete(book);
                if (isSuccess)
                {
                    this.loggerService.LogInfo($"{this.GetControllerActionNames()}: Record with Id: {id} successfully deleted.");
                    return NoContent();
                }
                else
                {
                    this.loggerService.LogWarning($"{this.GetControllerActionNames()}: Delete failed for record with Id: {id}");
                    return StatusCode(StatusCodes.Status500InternalServerError, "Book delete failed.");
                }
            }
            catch (Exception exc)
            {
                return this.InternalError(exc);
            }
        }

        private string GetControllerActionNames()
        {
            var controller = ControllerContext.ActionDescriptor.ControllerName;
            var action = ControllerContext.ActionDescriptor.ActionName;

            return $"{controller} - {action}";
        }

        private ObjectResult InternalError(Exception exc)
        {
            this.loggerService.LogError($"{this.GetControllerActionNames()} - {exc.Message} - {exc.InnerException}: {exc.InnerException?.Message}");

            return StatusCode(StatusCodes.Status500InternalServerError, "Something went wrong. Please contact the Administrator.");
        }
    }
}
