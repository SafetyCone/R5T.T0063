using System;


namespace R5T.T0063
{
    /// <summary>
    /// Marks an interface as being a service action aggregation definition.
    /// Also allows specifying that an interface is *not* a service action aggregation. This is useful for decorating extraneous interface declarations that also happen to be in a service action aggregation definition file, or in a file in the service action aggregation definitions directory.
    /// </summary>
    [AttributeUsage(AttributeTargets.Interface, Inherited = false, AllowMultiple = false)]
    public class ServiceActionAggregationMarkerAttribute : Attribute
    {
        private readonly bool zIsServiceActionAggregation;
        public bool IsServiceActionAggregation
        {
            get
            {
                return this.zIsServiceActionAggregation;
            }
        }


        public ServiceActionAggregationMarkerAttribute(
            bool isServiceActionAggregation = true)
        {
            this.zIsServiceActionAggregation = isServiceActionAggregation;
        }
    }
}
