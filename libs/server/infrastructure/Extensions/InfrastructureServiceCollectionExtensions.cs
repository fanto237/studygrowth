using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Extensions;

public static class InfrastructureServiceCollectionExtensions
{
  public static void AddInfrastructur(this IServiceCollection services, IConfiguration configuration)
  {

    var connectionString = configuration.GetConnectionString("Default");
    services.AddDbContext<ApplicationDbContext>(options =>
    {
      options.UseSqlite(connectionString);
    });
  }

}
