using System;

using Microsoft.Extensions.DependencyInjection;


namespace R5T.T0063
{
    /// <summary>
    /// A service action that, when run, does nothing.
    /// This is useful when a <see cref="IServiceAction{TService}"/> dependency must be satisified, but the service itself has been added by external code.
    /// </summary>
    public class DoNothingServiceAction<TService> : IServiceAction<TService>
    {
        public void Run(IServiceCollection services)
        {
            // Do nothing.
        }
    }
}
