using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    internal class Program
    {
        static void BubbleSort(List<Student> students)
        {
            int n = students.Count;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (students[j].Age > students[j + 1].Age)
                    {
                        var temp = students[j];
                        students[j] = students[j + 1];
                        students[j + 1] = temp;
                    }
                }
            }
            
        }
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
        {
            new Student("Иван", 15),
            new Student("Мария", 14),
            new Student("Петър", 16),
            new Student("Ана", 13)
        };

            BubbleSort(students);

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

    }
}
