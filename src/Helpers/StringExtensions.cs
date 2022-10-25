namespace Helpers
{
    public static class StringExtensions
    {
        public static bool HasValue(this string data) 
            => string.IsNullOrWhiteSpace(data);
    }
}