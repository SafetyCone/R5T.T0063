using System;

using Microsoft.Extensions.DependencyInjection;


namespace R5T.T0063
{
    /// <summary>
    /// Encapsulates the addition of a service <typeparamref name="TService"/> to an <see cref="IServiceCollection"/> instance.
    /// The action must be run to actually add the service.
    /// Useful in communicating service dependency relationships while configuring a services collection.
    /// </summary>
    /// <typeparam name="TService">
    /// The service definition type. The type parameter is a dummy, allowing the service action to communicate what service type of the action.
    /// The service type parameter is invariant (not 'out' nor 'in') because the Microsoft service provider does not have variance. (Meaning that service descriptor for type TBase will *not* provide an instance if TDerived : TBase is requested.)
    /// </typeparam>
    public interface IServiceAction<TService>
    {
        void Run(IServiceCollection services);
    }
}