using DotNet8.Clean.Domain.Features.Blog;
using DotNet8.Clean.Infrastructure.Features.Blog;
using Microsoft.EntityFrameworkCore;

namespace DotNet8.Clean.Presentation.Extensions;

public static class DependencyInjection
{
	#region AddDbContextService

	private static IServiceCollection AddDbContextService(this IServiceCollection services, WebApplicationBuilder builder)
	{
		builder.Services.AddDbContext<BlogDbContext>(
			opt =>
			{
				opt.UseSqlServer(builder.Configuration.GetConnectionString("DbConnection"));
				opt.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
			},
			ServiceLifetime.Transient,
			ServiceLifetime.Transient
		);

		return services;
	}

	#endregion

	#region AddRepositoryService

	private static IServiceCollection AddRepositoryService(this IServiceCollection services)
	{
		return services.AddScoped<IBlogRepository, BlogRepository>();
	}

	#endregion

	public static IServiceCollection AddDependencyInjection(this IServiceCollection services, WebApplicationBuilder builder)
	{
		return services.AddDbContextService(builder).AddRepositoryService();
	}
}
