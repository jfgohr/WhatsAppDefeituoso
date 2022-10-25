using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Helpers
{
    public static class ObjectExtensions
    {
        public static bool HasValue(this object data)
        {
            if (data == null)
                return false;

            if (data is string dataAsString)
                return dataAsString.HasValue();

            if (data is int dataAsInt)
                return dataAsInt > 0;

            if (data is IEnumerable<object> dataAsEnumerable)
                dataAsEnumerable.Any();

            if(data is DataGridViewRow dataAsDataGridViewRow)
                return dataAsDataGridViewRow != null;

            return true;
        }
    }
}
