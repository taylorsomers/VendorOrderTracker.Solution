# Vendor & Order Tracker

  ### By Taylor Somers

## Description

  This is a console program created with C# and .NET. It simulates a bakery website that will greet the baker-owner, Pierre, allow him to view a list of vendors to whom he supplies orders of baked goods, display details on each vendor, and display details on the orders for each vendor. The program was built with C# integrated with HTML (CSHTML) and is the first major web-app I have been able to make with C#.

## Languages & Technologies Used:

  ### Programming Languages & Libraries
  * CSHTML
  * C#

  ### Operating Systems & Programs
  * Brave
  * Microsoft PowerShell
  * Microsoft Windows 10
  * Visual Studio Code
  * .NET Core

## Installation

  1.  Download a web browser, such as Apple Safari, Brave, Google Chrome, Microsoft Edge, Mozilla Firefox, or Yandex.
  2.  Navigate to https://github.com/taylorsomers/VendorOrderTracker.Solution.
  3.  Click the green "Clone or download" button at the right of the screen.
  4.  Select "Download ZIP."
  5.  Use a file extractor or unzip program (such as PeaZip, Unzipper, WinZip, Zipware, or 7-ZIP) to extract the ZIP files onto your computer.
  6.  In your browser, navigate to https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.106-macos-x64-installer for Mac or https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.203-windows-x64-installer for Windows and click the link "click here to download manually" if the download for .NET Core 2.2 SDK does not start automatically.
  7.  Double-click the downloaded .NET Core 2.2 SDK file and run the installer.
  8.  Open your computer's terminal and navigate to the directory bearing the name of the program and containing the top level subdirectories and files.
  9.  Enter the command "dotnet build" in the terminal.
  10. Enter the command "dotnet run" in the terminal. The program should begin to run in the console.

  ### Test Instructions

  1.  Open the application with Microsoft Visual Studio Code.
  2.  Press "ctrl" + "j" to open the terminal.
  3.  Navigate into the Bakery.Tests subdirectory by entering "cd Bakery.Tests" in the terminal.
  4.  Enter "dotnet test" in the terminal to run test suites.


## Specifications

  | Program Behavior | Example Behavior | Example Output |
  | ----------- | ----------- | ----------- |
  | Program will display a splash page welcoming Pierre. | N/A | "Pierre's Bakery Vendor & Order Tracker" |
  | Program will display a link to view all vendors that have been added to the tracking system. | N/A | "View Vendors" |
  | Program will display a link to add a new vendor to the tracking system. | N/A | "Add a New Vendor" |
  | If the "View Vendors" link is clicked and no vendors have been added to the tracking system, the webpage will display the appropriate message. | "View Vendors" > Click | "No vendors have been added yet!" |
  | If the "Add a New Vendor" link is clicked, program will display an input field for the new vendor name and description, as well as links to return to the Home page and to the list of vendors. | "Add a new Vendor" > Click | "Add a Vendor Here: Vendor Name:[] Vendor Description:[]; 'Back to Home Page'; 'Back to Vendors'" |
  | Program will accept user inputs for vendor name and description and display them in a list of vendors. | "Vendor Name:[Lloyd Wabbit's Wiffle Wine] Vendor Description:[Winery on the outskirts of town]" | "Vendors: Lloyd Wabbit's Wiffle Wine, Winery on the outskirts of town" |
  | Program will add an order date associated with a particular vendor when the user clicks the "Add a New Order" link. | "Lloyd Wabbit's Wiffle Wine" > Click; "Add a New Order" > Click; "Order Date:[Jan 17] > 'Add Order'" | "Here are all the Orders for this Vendor: 1. Jan 17" |


## Known Bugs

  * No known bugs at this time. If any are discovered, please feel free to reach out and let me know. If you would like to contribute any fixes or improvements, please do!

### Contributors

  * Taylor Somers

### License

This program is free to use under the GNU General Public License GPLv3. (C) 2020 Taylor Somers. All rights reserved.