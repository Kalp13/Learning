using BookStore.WebAPI.Contracts;
using Microsoft.AspNetCore.Identity;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.WebAPI.Data
{
    public static class SeedData
    {
        public async static Task Seed(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            await SeedRoles(roleManager).ConfigureAwait(false);
            await SeedUsersAsync(userManager).ConfigureAwait(false);
        }

        private static async Task SeedUsersAsync(UserManager<IdentityUser> userManager)
        {
            if (await userManager.FindByEmailAsync("admin@bookstore.com") == null)
            {
                var user = new IdentityUser
                {
                    UserName = "admin",
                    Email = "admin@bookstore.com"
                };
                
                var result = await userManager.CreateAsync(user, "Password@1");

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, "Administrator").ConfigureAwait(false);
                }
            }

            if (await userManager.FindByEmailAsync("administrator@bookstore.com") == null)
            {
                var user = new IdentityUser
                {
                    UserName = "administrator",
                    Email = "administrator@bookstore.com"
                };

                var result = await userManager.CreateAsync(user, "Password@1");

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, "Administrator").ConfigureAwait(false);
                }
            }

            if (await userManager.FindByEmailAsync("customer01@gmail.com") == null)
            {
                var user = new IdentityUser
                {
                    UserName = "customer01",
                    Email = "customer01@gmail.com"
                };

                var result = await userManager.CreateAsync(user, "Password@1");

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, "Customer").ConfigureAwait(false);
                }
            }

            if (await userManager.FindByEmailAsync("customer02@gmail.com") == null)
            {
                var user = new IdentityUser
                {
                    UserName = "customer02",
                    Email = "customer02@gmail.com"
                };

                var result = await userManager.CreateAsync(user, "Password@1");

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, "Customer").ConfigureAwait(false);
                }
            }
        }

        private static async Task SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            if (!await roleManager.RoleExistsAsync("Administrator"))
            {
                var role = new IdentityRole
                {
                    Name = "Administrator"
                };
                await  roleManager.CreateAsync(role);
            }

            if (!await roleManager.RoleExistsAsync("Customer"))
            {
                var role = new IdentityRole
                {
                    Name = "Customer"
                };
                await roleManager.CreateAsync(role);
            }
        }
    }
}
