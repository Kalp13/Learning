using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using BookStore_API.Contracts;
using BookStore_API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace BookStore_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly SignInManager<IdentityUser> signInManager;

        private readonly UserManager<IdentityUser> userManager;

        private ILoggerService loggerService;

        private IConfiguration configuration;

        #region Constructor

        /// <summary>
        /// Instantiates a new default instance of the <see cref="UsersController"/>
        /// </summary>
        /// <param name="signIn"></param>
        /// <param name="manager"></param>
        /// <param name="logger"></param>
        public UsersController(SignInManager<IdentityUser> signIn, 
                               UserManager<IdentityUser> manager,
                               ILoggerService logger,
                               IConfiguration config)
        {
            this.loggerService = logger;
            this.signInManager = signIn;
            this.userManager = manager;
            this.configuration = config;
        }

        #endregion

        /// <summary>
        /// Logs the user is with the given details.
        /// </summary>
        /// <param name="userDTO">
        /// </param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login([FromBody] UserDTO userDTO)
        {
            try
            {
                this.loggerService.LogInfo($"{this.GetControllerActionNames()}: Login Attempt from user {userDTO.Username}");

                string username = userDTO.Username;
                string password = userDTO.Password;
                var result = await this.signInManager.PasswordSignInAsync(username, password, false, false);

                if (result.Succeeded)
                {
                    var user = await this.userManager.FindByNameAsync(userDTO.Username).ConfigureAwait(false);
                    //var tokenString = await this.GenerateJSONWebToken(user);
                    this.loggerService.LogInfo($"{this.GetControllerActionNames()}: Successfully Authenticated {userDTO.Username}");

                    return Ok(/*new { token = tokenString }*/);
                }
                else
                {
                    this.loggerService.LogWarning($"{this.GetControllerActionNames()}: Authentication Failed for user: {userDTO.Username}");
                    return Unauthorized(userDTO);
                }
            }
            catch (Exception exc)
            {
                return this.InternalError(exc);
            }
        }

        #region Class Methods

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

        //private async Task<string> GenerateJSONWebToken(IdentityUser user)
        //{
        //    try
        //    {
        //        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Key"]));
        //        var credential = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

        //        var claims = new List<Claim>
        //        {
        //            new Claim(JwtRegisteredClaimNames.Sub, user.Email),
        //            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
        //            new Claim(ClaimTypes.NameIdentifier, user.Id),
        //        };

        //        var roles = await this.userManager.GetRolesAsync(user);
        //        claims.AddRange(roles.Select(x => new Claim(ClaimsIdentity.DefaultRoleClaimType, x)));

        //        var token = new JwtSecurityToken(this.configuration["JWT:Issuer"],
        //                                        this.configuration["JWT:Issuer"],
        //                                        claims,
        //                                        null,
        //                                        expires: DateTime.Now.AddMinutes(5),
        //                                        signingCredentials: credential);

        //        return new JwtSecurityTokenHandler().WriteToken(token);
        //    }
        //    catch (Exception exc)
        //    {
        //        throw exc;
        //    }
        //}

        #endregion
    }
}
