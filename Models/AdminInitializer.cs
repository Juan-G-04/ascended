using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AscendedGuild.Models
{
	public static class AdminInitializer
	{
		// This method ensures there is one and only one admin account at all times
		public static async Task CreateRoles(
			IServiceProvider serviceProvider, IConfiguration configuration)
		{
			// Initialize custom role
			var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
			var userManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();
			string[] roles = {"Administrator"};

			// Create role if necessary
			foreach (var roleName in roles)
			{
				var roleExists = 
					await roleManager.RoleExistsAsync(roleName);
				
				if (!roleExists)
				{
					await roleManager.CreateAsync(new IdentityRole(roleName));
				}
			}

			// Create admin user if necessary		
			string adminEmail= Environment.GetEnvironmentVariable("ASCENDED_ADMIN_EMAIL");
			string adminPassword= Environment.GetEnvironmentVariable("ASCENDED_ADMIN_PWD");
			
			var _user = await userManager.FindByEmailAsync(adminEmail);

			if (_user == null)
			{				
				var adminUser = new IdentityUser()
				{
					UserName = adminEmail,
					Email = adminEmail
				};

				var createAdmin = await userManager.CreateAsync(adminUser, adminPassword);

				if (createAdmin.Succeeded)
				{
					// Assign admin user to admin role
					await userManager.AddToRoleAsync(adminUser, "Administrator");
				}
				else				
				{
					// Throw exception
				}
			}
		}
	}
}