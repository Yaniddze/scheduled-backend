﻿using System;
using System.Linq;
using Domain.Entities;
using Domain.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Data
{
    public static class DatabaseInitializer
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var scope = serviceProvider.CreateScope();
            var sp = scope.ServiceProvider;

            var dbContext = sp.GetRequiredService<AppDbContext>();
            dbContext.Database.Migrate();

            var userManager = sp.GetRequiredService<UserManager<User>>();
            var rolesManager = sp.GetRequiredService<RoleManager<IdentityRole<int>>>();
            var logger = sp.GetService<ILogger<AppDbContext>>();

            using var txn = dbContext.Database.BeginTransaction();
            Seed(dbContext, userManager, rolesManager, logger);

            txn.Commit();
        }

        private static void Seed(AppDbContext dbContext, UserManager<User> userManager,
            RoleManager<IdentityRole<int>> roleManager, ILogger<AppDbContext> logger)
        {
            try
            {
                var roles = Enum.GetNames(typeof(UserRole));
                var dbRoles = dbContext.Roles.ToList();
                if (roles.Length > dbRoles.Count)
                {
                    var rolesToAdd = roles.Where(r => dbRoles.All(dbr => dbr.Name != r));
                    foreach (var role in rolesToAdd)
                    {
                        roleManager.CreateAsync(new IdentityRole<int>(role)).Wait();
                    }
                }
                
                dbContext.SaveChanges();
            }
            catch (Exception e)
            {
                logger.LogCritical(e.Message);

                throw;
            }
        }
    }
}