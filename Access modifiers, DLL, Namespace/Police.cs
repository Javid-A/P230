using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_modifiers__DLL__Namespace
{
    internal class Police:Utilities.Human
    {
        public Police()
        {
            HumanProtectedInternal = "protected internal";
            Utilities.Human human = new Utilities.Human();

            human.human
        }
    }
}
