using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/**
 * author: shahzaib malik
 * student id: 300852792
 * course id: COMP123
 * 
*/
namespace Assignment5
{
    /**
 * main driver class of the program 
 * @ properties firstname,lastname,idclass,grade
 * @method main(string[]) args
 */
    class Program
    {
        // public properties
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string idClass { get; set; }
        public string grade { get; set; }

        static void Main(string[] args)
        {
            
            Program student = new Program();
            bool menu = true;
            while (menu)
            {
                // show options in the console menu
                Console.WriteLine(" Please make your reservation");
                Console.WriteLine(" 1. Display grades");
                Console.WriteLine(" 2. Exit");
                Console.WriteLine("----------------------------------");
                string selection = Console.ReadLine();
                switch (selection)
                {
                    case "1": // The "1" neumeric key selects displaygrades
                        Console.WriteLine("please enter name of file to load");
                        string filename = Console.ReadLine();
                        Console.WriteLine();
                        if (filename == "grade.txt")
                        {
                            string gradefile = "..\\..\\grade.txt";

                            const char dlim = ',';
                            FileStream file = new FileStream(gradefile, FileMode.Open, FileAccess.Read);
                            StreamReader filereader = new StreamReader(file);
                            string recordFromfile;
                            string[] fields;

                            recordFromfile = filereader.ReadLine();
                            while (recordFromfile != null)
                            {

                                fields = recordFromfile.Split(dlim);
                                student.lastname = fields[0];
                                student.firstname = fields[1];
                                student.idClass = fields[2];
                                student.grade = fields[3];

                                Console.WriteLine("{0},{1},{2},{3}", student.lastname, student.firstname, student.idClass, student.grade);

                                recordFromfile = filereader.ReadLine();
                            }
                            filereader.Close();
                            file.Close();
                        }
                        else
                        {
                            Console.WriteLine("No such file exsists");
                        }
                        Console.WriteLine();
                        break;
                    case "2": // The "3" numeric Key to Exit the menu
                        menu = false;
                        break;
                    default:
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
