//using L08HandsOn.Models;
//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace L08HandsOn.Controllers
//{
//    public class ManageUserController : Controller
//    {
//        public IActionResult Index()
//        {
//            return View();
//        }

//        [HttpGet]
//        public async Task<IActionResult> ManageUserRoles(string userId)
//        {
//            ViewBag.userId = userId;

//            var user = await userManager.FindByIdAsync(userId);

//            if (user == null)
//            {
//                ViewBag.ErrorMessage = $"User with Id = {userId} cannot be found";
//                return View("NotFound");
//            }

//            var model = new List<ManageUser>();

//            foreach (var role in roleManager.Roles)
//            {
//                var userRolesViewModel = new ManageUser
//                {
//                    RoleId = role.Id,
//                    RoleName = role.Name
//                };

//                if (await userManager.IsInRoleAsync(user, role.Name))
//                {
//                    userRolesViewModel.IsSelected = true;
//                }
//                else
//                {
//                    userRolesViewModel.IsSelected = false;
//                }

//                model.Add(userRolesViewModel);
//            }

//            return View(model);
//        }

//        [HttpPost]
//        public async Task<IActionResult>
//        ManageUserRoles(List<ManageUser> model, string userId)
//        {
//            var user = await userManager.FindByIdAsync(userId);

//            if (user == null)
//            {
//                ViewBag.ErrorMessage = $"User with Id = {userId} cannot be found";
//                return View("NotFound");
//            }

//            var roles = await userManager.GetRolesAsync(user);
//            var result = await userManager.RemoveFromRolesAsync(user, roles);

//            if (!result.Succeeded)
//            {
//                ModelState.AddModelError("", "Cannot remove user existing roles");
//                return View(model);
//            }

//            result = await userManager.AddToRolesAsync(user,
//                model.Where(x => x.IsSelected).Select(y => y.RoleName));

//            if (!result.Succeeded)
//            {
//                ModelState.AddModelError("", "Cannot add selected roles to user");
//                return View(model);
//            }

//            return RedirectToAction("EditUser", new { Id = userId });
//        }
//    }
//}
