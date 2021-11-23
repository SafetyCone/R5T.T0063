using System;
using System.Collections.Generic;

using Microsoft.Extensions.DependencyInjection;

using R5T.T0063;


namespace System
{
    /// <summary>
    /// Some basic service collection extensions for working with service actions.
    /// </summary>
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Runs the provided service action, then builds a service provider and gets an instance of the requested service.
        /// </summary>
        public static ServiceProvider GetInstance<TService>(this IServiceCollection services,
            IServiceAction<TService> serviceAction,
            out TService instance)
        {
            services.Run(serviceAction);

            var serviceProvider = services.BuildServiceProvider();

            instance = serviceProvider.GetRequiredService<TService>();

            return serviceProvider;
        }

        /// <summary>
        /// Calls the <see cref="IServiceAction{TService}.Run(IServiceCollection)"/> method on the service collection.
        /// </summary>
        public static IServiceCollection RunServiceAction<TService>(this IServiceCollection services, IServiceAction<TService> serviceAction)
        {
            serviceAction.Run(services);

            return services;
        }

        /// <summary>
        /// Quality-of-life overload for <see cref="IServiceCollectionExtensions.RunServiceAction{T}(IServiceCollection, IServiceAction{T})"/>.
        /// </summary>
        public static IServiceCollection Run<TService>(this IServiceCollection services, IServiceAction<TService> serviceAction)
        {
            services.RunServiceAction(serviceAction);

            return services;
        }

        public static IServiceCollection Run<TService>(this IServiceCollection services,
            IEnumerable<IServiceAction<TService>> serviceActions)
        {
            foreach (var serviceAction in serviceActions)
            {
                services.RunServiceAction(serviceAction);
            }

            return services;
        }
    }
}
