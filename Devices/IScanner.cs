using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devices;


public interface IScanner
{

    /*
        Input: 
            - doc: string version of the document
        Returns:
            - void: just takes the file and stores it
    */
    public void Scan(string doc);

    /*
        This is the document stored in the scanner after scanning
     */
    public string Document
    {
        get; set;
    }
}
