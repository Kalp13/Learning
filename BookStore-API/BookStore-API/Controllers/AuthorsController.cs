using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using BookStore_API.Contracts;
using BookStore_API.Data;
using BookStore_API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor.TagHelpers;

namespace BookStore_API.Controllers
{
    /// <summary>
    /// Endpoint used to interact with the Authors in the book store's database.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorRepository authorRepository;

        private readonly ILoggerService loggerService;

        private readonly IMapper mapper;

        public AuthorsController(IAuthorRepository author, ILoggerService logger, IMapper map)
        {
            this.authorRepository = author;
            this.loggerService = logger;
            this.mapper = map;
        }

        /// <summary>
        /// Gets all the authors.
        /// </summary>
        /// <returns>
        ///     List of authors.
        /// </returns>
        [HttpGet]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAuthors()
        {
            try
            {
                this.loggerService.LogInfo($"{this.GetControllerActionNames()}: Attempting call.");
                var authors = await this.authorRepository.FindAll();
                var mappedAuthors = this.mapper.Map<IList<AuthorDTO>>(authors);

                this.loggerService.LogInfo($"{this.GetControllerActionNames()}: Call Successful");

                return Ok(mappedAuthors);
            }
            catch (Exception exc) 
            {
                return this.InternalError(exc);
            }
        }

        /// <summary>
        /// Gets a specific author with the given unique identifier.
        /// </summary>
        /// <returns>
        ///     A specific author.
        /// </returns>
        [HttpGet("{id}")]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAuthor(int id)
        {
            try
            {
                this.loggerService.LogInfo($"{this.GetControllerActionNames()}: Attempting call.");

                var author = await this.authorRepository.FindById(id).ConfigureAwait(false);
                if (author == null)
                {
                    this.loggerService.LogWarning($"{this.GetControllerActionNames()}: Failed to retrieve record with Id: {id}");
                    return NotFound($"No author found with Id - {id}");
                }

                var response = this.mapper.Map<AuthorDTO>(author);

                this.loggerService.LogInfo($"{this.GetControllerActionNames()}: Successfully got record with id: " + id);

                return Ok(response);
            }
            catch (Exception exc)
            {
                return this.InternalError(exc);
            }
        }

        /// <summary>
        /// Creates a new <see cref="Author"/> from the given <see cref="AuthorCreateDTO"/>.
        /// </summary>
        /// <param name="authorDTO">
        ///     The <see cref="AuthorCreateDTO"/> author to create.
        /// </param>
        /// <returns></returns>
        [HttpPost]
        [Authorize(Roles = "Administrator")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task <IActionResult> Create([FromBody] AuthorCreateDTO authorDTO)
        {
            try
            {
                this.loggerService.LogInfo($"{this.GetControllerActionNames()}: Create Attempted.");
                if (authorDTO == null)
                {
                    this.loggerService.LogWarning($"{this.GetControllerActionNames()}: Empty Request was submitted.");
                    return BadRequest(ModelState);
                }

                if (!ModelState.IsValid)
                {
                    this.loggerService.LogWarning($"{this.GetControllerActionNames()}: Data was incomplete.");
                    return BadRequest(ModelState);
                }

                var author = this.mapper.Map<Author>(authorDTO);
                var isSuccess = await this.authorRepository.Create(author);
                if (isSuccess)
                {
                    this.loggerService.LogInfo($"{this.GetControllerActionNames()}: Creation was successful.");
                    this.loggerService.LogInfo($"{this.GetControllerActionNames()}: {author}");
                    return Created($"Successfully created author.", new { author});
                }
                else
                {
                    this.loggerService.LogWarning($"{this.GetControllerActionNames()} : Creation failed.");
                    return StatusCode(StatusCodes.Status500InternalServerError, "Author creation failed.");
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
        /// <param name="authorDTO"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        [Authorize(Roles = "Administrator, Customer")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Update(int id, [FromBody] AuthorUpdateDTO authorDTO)
        {
            try
            {
                this.loggerService.LogInfo($"{this.GetControllerActionNames()}: Update attempted on record with Id: {id}");

                if (id <= 0 || id != authorDTO.Id)
                {
                    this.loggerService.LogWarning($"{this.GetControllerActionNames()}: Update failed with bad data - Id: {id}");
                    return BadRequest("Invalid author identifier passed through.");
                }

                if (authorDTO == null)
                {
                    this.loggerService.LogWarning($"{this.GetControllerActionNames()}: Data was empty");
                    return BadRequest(ModelState);
                }

                if (!ModelState.IsValid)
                {
                    this.loggerService.LogWarning($"Author properties are not valid.");
                    return BadRequest(ModelState);
                }

                var doesExist = await this.authorRepository.DoesExist(id);
                if (!doesExist)
                {
                    return NotFound($"{this.GetControllerActionNames()}: No record found with Id: {id}");
                }

                var author = this.mapper.Map<Author>(authorDTO);
                var isSuccess = await this.authorRepository.Update(author);
                if (isSuccess)
                {
                    this.loggerService.LogInfo($"{this.GetControllerActionNames()}: Update successful for record with Id: {id}");
                    return NoContent();
                }
                else
                {
                    this.loggerService.LogError($"{this.GetControllerActionNames()}: Update failed for record with Id: {id}");
                    return StatusCode(StatusCodes.Status500InternalServerError, "Author update failed.");
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
        [Authorize(Roles = "Customer")]
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
                    return BadRequest("Invalid author identifier passed through.");
                }

                var doesExist = await this.authorRepository.DoesExist(id);
                if (!doesExist)
                {
                    this.loggerService.LogWarning($"{this.GetControllerActionNames()}: Failed to retrieve record with Id: {id}");
                    return NotFound();
                }

                var author = await this.authorRepository.FindById(id);
                var isSuccess = await this.authorRepository.Delete(author);
                if (isSuccess)
                {
                    this.loggerService.LogInfo($"{this.GetControllerActionNames()}: Record with Id: {id} successfully deleted.");
                    return NoContent();
                }
                else
                {
                    this.loggerService.LogWarning($"{this.GetControllerActionNames()}: Delete failed for record with Id: {id}");
                    return StatusCode(StatusCodes.Status500InternalServerError, "Author delete failed.");
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

        private ObjectResult InternalError (Exception exc)
        {
            this.loggerService.LogError($"{this.GetControllerActionNames()} - {exc.Message} - {exc.InnerException}: {exc.InnerException?.Message}");

            return StatusCode(StatusCodes.Status500InternalServerError, "Something went wrong. Please contact the Administrator.");
        }
    }
}
