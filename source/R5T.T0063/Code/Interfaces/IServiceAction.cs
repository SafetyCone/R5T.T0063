using System;

using Microsoft.Extensions.DependencyInjection;


namespace R5T.T0063
{
    /// <summary>
    /// Encapsulates the addition of a service <typeparamref name="TService"/> to a <see cref="IServiceCollection"/> instance.
    /// Must be run to actually add the service.
    /// Useful in communicating serivce dependency relationships while configuring a services collection.
    /// </summary>
    /// <typeparam name="TService">The service definition type. The type parameter is a dummy, allowing the service action to communicate what service type of the action.</typeparam>
    /// <remarks>
    /// No covariance or contravariance, because the Microsoft DI-continer is not covariant or contravariant.
    /// </remarks>
    public interface IServiceAction<TService>
    {
        void Run(IServiceCollection services);
    }
}