### Interface segmentation: Multi Function printer

## UML Diagram for the project
<img src="MultiFunctionPrinter.png"/>

This project is an illustration of the design principle interface segmentation, 
where a multi function printer is implemented.

## Design
There are two modules in the project.

- Devices
    - This module contains all the interfaces and devices used in this project. These are
        - Interfaces:
            - `IFax`: The interface for a pure fax machine
            - `IScanner`: The interface for a pure scanner
            - `IPrinter`: The interface for a pure printer
        - Classes:
            - `AllRoundPrinter`: 
                - This printer supports multiple functions
                - Scanning: It can scan documents
                - Printing: It can print documents
                - Fax: It can send faxes too
            - `NoFaxPrinter`:
                - This printer supports multiple functions
                - But it does not support fax
                - Scanning: It can scan documents
                - Printing: It can print documents

- UnitTests
    - This module has unit tests for all the classes mentioned above
        - `TestAllroundPrinter`: Tests the `AllRoundPrinter` class
        - `TestNoFaxPrinter`: Tests the `NoFaxPrinter` class

## Methodology
- Printing: 
    - Once a document is provided as a string, it is stored as a variable `PrintedText` in the `IPrinter`
- Scanning:
    - Once a document is provided as a string, it is stored as a variable `Document` in the `IScanner`
- Fax:
    - Once a document and an ip address are provided, a message stating `Sending <document> to <ip>` is stored in the `IFax`

## Shortcoming
Currently, no console writing or logging is used because, it made testing harder for me.


## Environment
This project runs with dotnet or Visual Studio 2022 when required workloads/tools are installed