﻿using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyInventory.Areas.Identity.Data;
using MyInventory.Data;

[assembly: HostingStartup(typeof(MyInventory.Areas.Identity.IdentityHostingStartup))]
namespace MyInventory.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<MyInventoryContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("MyInventoryContextConnection")));

                services.AddDefaultIdentity<MyInventoryUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<MyInventoryContext>();
            });
        }
    }
}