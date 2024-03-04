using System;
using System.IO;
//INPUT ASSIGNMENT

//Perform these actions and create a console app that includes the following:

//Asks the user for a number.

//Logs that number to a text file.

//Prints the text file back to the user.
namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            string inputNum = Console.ReadLine(); //ask user for a number
            File.WriteAllText(@"C:\\Users\\sarah\\Logs\\log.txt",inputNum);//this is the file path to write the input from user (a number via string input entry) to a text file
            string readText = File.ReadAllText(@"C:\\Users\\sarah\\Logs\\log.txt"); //this is a file text reader converting the text in the txt file, into string format. 
            Console.WriteLine(readText); //this displays the input from log txt file back to the user.

        }
    }
}
