using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devices;

/*
    Scan
    Input: reads from console
    Output: makes a soft copy of the file as an attribute
 */
public interface IScanner
{
    public void Scan(string doc);
    public string Document
    {
        get; set;
    }
}
