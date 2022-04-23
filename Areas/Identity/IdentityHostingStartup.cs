using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NetflixAndFriends_FinalProject_ENTPROG.Data;
using NetflixAndFriends_FinalProject_ENTPROG.Models;

[assembly: HostingStartup(typeof(NetflixAndFriends_FinalProject_ENTPROG.Areas.Identity.IdentityHostingStartup))]
namespace NetflixAndFriends_FinalProject_ENTPROG.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}