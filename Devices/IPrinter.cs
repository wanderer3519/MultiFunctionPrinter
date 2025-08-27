namespace Devices;

/*
    There is only 1 function for a printer
    It just prints to a "file"

    Input: File already in the system / currently using string doc
    Output: A new hard copy of the file
 */
public interface IPrinter
{
    public void Print(string doc);

    public string PrintText
    {
        get;
        set;
    }
}
