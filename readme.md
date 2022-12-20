# Hash Generator
This is a simple C# script that calculates the MD5, SHA1, and SHA256 hashes of a file. To use it, click on the button to open a file dialog and choose the desired file. The results will then be printed inside the text box.

# Prerequisites
.NET framework (version 5.0 or later)

# Usage
- Click on the button to open a file dialog to choose the desired file.
- The program will calculate the 3 hashes and then print them inside the text box.
- You can copy the contents from the text box

# Note
Each time you choose a new file it will overwrite the previous calculations.

# To recreate un Visual Studio
To recreate this Windows Form in Visual Studio, follow these steps:

- Open Visual Studio.
- Create a new project by going to File > New > Project.
- In the New Project dialog, select Windows Forms App (.NET Framework) under Visual C# in the left pane. Then, give your project a name and location, and click Create.
- This will create a new Windows Form project with a default form called Form1.
- Replace the code in Form1.cs with the code provided above.
- In the Designer view, create a button and a textbox if they're not already there. These are and should be the button1 and textbox1 elements referred to in the code.
- To run the program, press F5 or go to Debug > Start Debugging.
- When the form appears, click the button to select a file. The program will calculate the MD5, SHA1, and SHA256 hashes of the selected file and display them in the textbox.
