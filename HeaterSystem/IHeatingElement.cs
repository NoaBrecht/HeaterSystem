using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeaterSystem
{
    public interface IHeatingElement
    {
        void Enable();
        void Disable();
    }
}
