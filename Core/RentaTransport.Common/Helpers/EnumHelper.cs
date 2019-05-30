using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RentaTransport.Common.Helpers
{
    public static class EnumHelper
    {
        public static IEnumerable<T> Get<T>()
        {
            var values = Enum.GetValues(typeof(T)).Cast<T>().AsEnumerable();
            return values;
        }
    }
}
