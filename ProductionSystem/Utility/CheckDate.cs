using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionSystem.Utility
{
    public static class CheckDate
    {
        public static Boolean IsValid(String input)
        {
            DateTime tempDate;
            return DateTime.TryParse(input, out tempDate);
        }
    }
}
