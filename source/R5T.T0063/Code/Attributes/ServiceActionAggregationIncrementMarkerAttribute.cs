using System;


namespace R5T.T0063
{
    /// <summary>
    /// Marks an interface as being a service action aggregation increment definition.
    /// Also allows specifying that an interface is *not* a service action aggregation increment. This is useful for decorating extraneous interface declarations that also happen to be in a service action aggregation increment definition file, or in a file in the service action aggregation increment definitions directory.
    /// </summary>
    [AttributeUsage(AttributeTargets.Interface, Inherited = false, AllowMultiple = false)]
    public class ServiceActionAggregationIncrementMarkerAttribute : Attribute
    {
        private readonly bool zIsServiceActionAggregationIncrement;
        public bool IsServiceActionAggregation
        {
            get
            {
                return this.zIsServiceActionAggregationIncrement;
            }
        }


        public ServiceActionAggregationIncrementMarkerAttribute(
            bool isServiceActionAggregationIncrement = true)
        {
            this.zIsServiceActionAggregationIncrement = isServiceActionAggregationIncrement;
        }
    }
}
