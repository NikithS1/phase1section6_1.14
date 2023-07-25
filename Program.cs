using System;
using System.IO;

namespace studentsdatadisplay
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\\mphasis\\Day 12\\studentsdatadisplay\\studentsdatadisplay\\students.txt\"; 

            try
            {
                string[] lines = File.ReadAllLines(filePath);

                Console.WriteLine("Student Data:");
                Console.WriteLine("-------------");

                // display student data line by line
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] data = lines[i].Split(',');
                    int studentID = int.Parse(data[0]);
                    string name = data[1];
                    int grade = int.Parse(data[2]);

                    Console.WriteLine($"ID: {studentID}, Name: {name}, Grade: {grade}");
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"File not found: {filePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.ReadLine();
        }
    }
}