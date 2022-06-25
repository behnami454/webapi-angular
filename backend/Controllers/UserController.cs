using backend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private UserManager<User> _userManager;

        private SignInManager<User> _singInManager;

        public UserController(UserManager<User> userManager, SignInManager<User> signInManager)
        {

            _userManager = userManager;
            _singInManager = signInManager;

        }

        [HttpPost]
        [Route("Register")]
        //POST : /api/ApplicationUser/Register
        public async Task<Object> PostUser(UserModel model)
        {
            var User = new User()
            {
                UserName = model.UserName,
                Email = model.Email,
            };

            try
            {
                var result = await _userManager.CreateAsync(User, model.Password);
                return Ok(result);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
