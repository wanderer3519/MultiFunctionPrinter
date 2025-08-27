using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devices;

public interface IFax
{
    /* The main method to send a document from source to destination
        Inputs:
            - `doc`: the document to be sent in a string format
            - `telnum`: the telephone number of the receiving device
        Returns: 
            - `void`
     */
    public void Fax(string doc, string telnum);

    /*
        The property which returns the text associated with the fax message
     */
    public string FaxText
    {
        get; set;
    }
}
