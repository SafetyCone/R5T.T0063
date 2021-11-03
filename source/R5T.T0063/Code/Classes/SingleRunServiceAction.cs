using System;

using Microsoft.Extensions.DependencyInjection;


namespace R5T.T0063
{
    /// <summary>
    /// A service action implementation that ensures it is only run once.
    /// </summary>
    public class SingleRunServiceAction<TService> : IServiceAction<TService>
    {
        public Action<IServiceCollection> Action { get; }

        private bool HasRun { get; set; } = false;


        public SingleRunServiceAction(Action<IServiceCollection> action)
        {
            this.Action = action;
        }

        public void Run(IServiceCollection services)
        {
            if (!this.HasRun)
            {
                this.Action(services);

                this.HasRun = true;
            }
        }
    }
}