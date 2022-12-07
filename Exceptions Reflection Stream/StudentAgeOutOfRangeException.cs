using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_Reflection_Stream
{
    internal class StudentAgeOutOfRangeException:Exception
    {
        public StudentAgeOutOfRangeException(string message):base(message)
        {

        }
        public StudentAgeOutOfRangeException()
        {

        }
    }
}
