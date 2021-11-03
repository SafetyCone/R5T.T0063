using System;


namespace R5T.T0063
{
    /// <summary>
    /// Marks a class as being a service action aggregation implementation.
    /// Also allows specifying that a class is *not* a service action aggregation implementation. This is useful for decorating extraneous class declarations that also happen to be in a service action aggregation implementation file, or in a file in the service action aggregation implementations directory.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public class ServiceActionAggregationImplementationMarkerAttribute : Attribute
    {
        private readonly bool zIsServiceActionAggregationImplementation;
        public bool IsServiceActionAggregationImplementation
        {
            get
            {
                return this.zIsServiceActionAggregationImplementation;
            }
        }


        public ServiceActionAggregationImplementationMarkerAttribute(
            bool isServiceActionAggregationImplementation = true)
        {
            this.zIsServiceActionAggregationImplementation = isServiceActionAggregationImplementation;
        }
    }
}
