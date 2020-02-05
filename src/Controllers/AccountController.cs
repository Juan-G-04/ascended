using System.Threading.Tasks;
using AscendedGuild.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AscendedGuild.Controllers
{
	public class AccountController : Controller
	{
		private readonly UserManager<IdentityUser> _userManager;
		private readonly SignInManager<IdentityUser> _signInManager;

		public AccountController(
			UserManager<IdentityUser> userManager,
			SignInManager<IdentityUser> signInManager)
		{
			_signInManager = signInManager;
			_userManager = userManager;
		}

		/// <summary>
		///	Allows the admin user to log in.		
		/// </summary>
		/// <remarks>
		/// This page is only accessible by url.
		/// There are no links to it since it is only for administration.
		/// </remarks>
		[HttpGet]
		public IActionResult Login()
		{
			return View();
		}

		/// <remarks>
		/// The sign-in is never browser cookie persisted.
		/// </remarks>
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Login(LoginViewModel model)
		{
			if (ModelState.IsValid)
			{
				var result = 
					await _signInManager.PasswordSignInAsync(
						model.Email, 
						model.Password, 
						isPersistent: false, 
						lockoutOnFailure: false);
				
				if (result.Succeeded)
				{
					return RedirectToAction("index", "home");
				}
				else
				{
					ModelState.AddModelError(string.Empty, "Invalid log in attempt");
				}				
			}
			
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Logout()
		{
			await _signInManager.SignOutAsync();
			return RedirectToAction("index", "home");
		}
	}
}