namespace Devices;

/*
    There is only 1 function for a printer
    It just prints to a "file"

    Input: File already in the system / currently using string doc
    Output: A new hard copy of the file
 */
public interface IPrinter
{
    /*
        The main method to read a document and print it
        Inputs:
            - doc: the text file to be printed
        Returns:
            - void: just prints the file
     */
    public void Print(string doc);


    /*
        Just to make the test cases work, storing the text to be printed here
     */
    public string PrintText
    {
        get;
        set;
    }
}
