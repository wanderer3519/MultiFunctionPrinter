using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devices
{
    public interface IFax
    {
        public void Fax(string doc, string ip);
    }
}
