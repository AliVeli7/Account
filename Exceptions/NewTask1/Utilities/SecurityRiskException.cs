using System;
using System.Collections.Generic;
using System.Text;

namespace NewTask1.Utilities
{
    class SecurityRiskException:Exception
    {
        public SecurityRiskException(string message):base(message)
        {
                
        }
    }
}
