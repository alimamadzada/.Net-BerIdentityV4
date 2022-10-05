using berylliumv2.Models;
using berylliumv2.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace berylliumv2.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;

        public AccountController(UserManager<AppUser> _userManager, SignInManager<AppUser> _signInManager)
        {
            userManager = _userManager;
            signInManager = _signInManager;
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel viewModel)
        {
            if (!ModelState.IsValid) return View();
            AppUser newUser = new AppUser()
            {
                Name = viewModel.Name,
                Surname = viewModel.Surname,
                Email = viewModel.Email,
                Age = viewModel.Age,
                UserName = viewModel.Email.Split("@")[0],
            };
            IdentityResult result = await userManager.CreateAsync(newUser, viewModel.Password);
            if (!result.Succeeded)
            {
                foreach (IdentityError item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
                return View(viewModel);
            }
            await signInManager.SignInAsync(newUser, false);
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel viewModel)
        {
            if (!ModelState.IsValid) return View();
            AppUser loginUser = await userManager.FindByEmailAsync(viewModel.Email);
            if (loginUser == null)
            {
                ModelState.AddModelError("", "Email or password is wrong.");
                return View(viewModel);
            }
            Microsoft.AspNetCore.Identity.SignInResult result = await signInManager.PasswordSignInAsync(loginUser, viewModel.Password, viewModel.StayLoggedIn, true);
            if (!result.Succeeded)
            {

                if (result.IsLockedOut)
                {
                    ModelState.AddModelError("", "You are locked out, please try again after 30 seconds.");
                }
                else
                {
                    ModelState.AddModelError("", "Email or password is wrong.");
                }
                return View(viewModel);
            }
            return RedirectToAction("Index", "Home");
        }
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
