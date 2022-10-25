namespace Helpers
{
    public static class ObjectExtensions
    {
        public static bool HasValue(this object data)
        {
            if (data == null)
                return false;

            var dataAsString = data as string;
            if (dataAsString != null)
                return dataAsString.HasValue();
            
            var dataAsEnumerable = data as IEnumerable<object>;
            if(dataAsEnumerable != null)
                dataAsEnumerable.Any();

            return false;
        }
    }
}
