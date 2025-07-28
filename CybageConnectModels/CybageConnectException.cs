using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CybageConnect
{
    public class CybageConnectException:Exception
    {
        public CybageConnectException(string exceptionMessage):base(exceptionMessage)
        {
            
        }
    }
}
