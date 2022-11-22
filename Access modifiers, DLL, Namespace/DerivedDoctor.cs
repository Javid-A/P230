using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace Access_modifiers__DLL__Namespace
{
    internal class DerivedDoctor:Doctor
    {
        public DerivedDoctor()
        {
            DoctorProtected
        }
    }
}
