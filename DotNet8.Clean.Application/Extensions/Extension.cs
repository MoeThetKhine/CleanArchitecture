﻿namespace DotNet8.Clean.Application.Extensions;

#region Extension

public static class Extension
{
	public static IServiceCollection AddMediatRService(this IServiceCollection services)
	{
		return services.AddMediatR(cf =>
		cf.RegisterServicesFromAssembly(typeof(Extension).Assembly));
	}
}

#endregion