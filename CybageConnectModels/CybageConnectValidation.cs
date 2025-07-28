using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CybageConnect
{
    public class CybageConnectValidation
    {
        public bool CheckForEmptyData(string dataname)
        {
            bool validationtionStatus = true;
            if (dataname.Length == 0)
            {
                validationtionStatus = false;
                throw new CybageConnectException("This field should not be \"empty\"");
            }
            return validationtionStatus;
        }
        public bool CheckForMobileNumber(long Number)
        {
            string num = Number.ToString();
            bool validationtionStatus = true;
            if (num.Length == 0)
            {
                validationtionStatus = false;
                throw new CybageConnectException("This field should not be \"empty\"");
            }
            return validationtionStatus;
        }
    }
}
