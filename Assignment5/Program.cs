using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment5
{
    class Program
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string idClass { get; set; }
        public string grade { get; set; }

        static void Main(string[] args)
        {
            Program student = new Program();

            try
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

                    Console.WriteLine("{0},{1},{2},{3}",student.lastname,student.firstname,student.idClass,student.grade);

                        recordFromfile = filereader.ReadLine();
                    }
                filereader.Close();
                file.Close();
            }

            

            catch (Exception exception)
            {
                Console.WriteLine("error: " + exception.Message);
            }
            

    }
}
}
