using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProductManager.Core.Models;

[assembly: HostingStartup(typeof(ProductManage.Areas.Identity.IdentityHostingStartup))]
namespace ProductManage.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<ProductDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("ProductManagerConn")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
                    .AddEntityFrameworkStores<ProductDbContext>();
            });
        }
    }
}