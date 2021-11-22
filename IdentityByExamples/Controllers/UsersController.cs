using IdentityByExamples.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityByExamples.Controllers
{
    public class UsersController : Controller
    {
        UserManager<User> _userManager;

        public UsersController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        // GET: UsersController
        
        [Authorize(Roles = "Administrator")]
        public async Task<ActionResult> Index()
        {
            var listUser = new List<User>();

            var _users = _userManager.Users.ToList();

            foreach (var user in _users)
            {
                if ( await _userManager.IsInRoleAsync(user, "Visitor"))
                {
                    listUser.Add(user);
                }
            }


            return View(listUser);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete (string id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var user = await _userManager.FindByIdAsync(id);

            var result = await _userManager.DeleteAsync(user);
            return RedirectToAction(nameof(Index));
        }

    }
}
