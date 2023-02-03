using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyExtension
{
    public static class MoneyExtension
    {
        public static int ToCents(this decimal amount)
        {
            if (amount <= 0)
                return 0;

            var value = amount
                .ToString("N2")
                .Replace(",", "")
                .Replace(".", "");

            if(string.IsNullOrEmpty(value))
                return 0;

            int.TryParse(value, out var result);
                return result;
        }
    }
}
