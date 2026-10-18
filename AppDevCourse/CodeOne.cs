// Program.cs
using System; // Importing the System namespace
using System.Collections.Generic;

namespace AppDevCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of strings
            List<string> techStack = new List<string> { "C#", "ASP.NET", "Entity Framework!" };

            // Adding items
            techStack.Add("Azure DevOps");

            // Iterating through a List
            foreach (var tech in techStack)
            {
                Console.WriteLine($"- {tech}");
            }
        }
    }
}