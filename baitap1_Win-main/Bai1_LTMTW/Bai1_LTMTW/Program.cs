using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_LTMTW
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
           
            List<Student> students = new List<Student>
        {
            new Student(1, "A", 16),
            new Student(2, "B", 18),
            new Student(3, "C", 14),
            new Student(4, "AA", 17),
            new Student(5, "F", 19)
        };

            // a. In danh sách toàn bộ danh sách học sinh
            Console.WriteLine("Danh sach toan bo hoc sinh:");
            foreach (var student in students)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }
            Console.WriteLine();

            // b. Tìm và in ra danh sách các học sinh có tuổi từ 15 đến 18
            var ageGroup = students.Where(s => s.Age >= 15 && s.Age <= 18).ToList();
            Console.WriteLine("Danh sach hoc sinh co tuoi tu 15 den 18:");
            foreach (var student in ageGroup)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }
            Console.WriteLine();

            // c. Tìm và in ra học sinh có tên bắt đầu bằng chữ "A"
            var studentsStartingWithA = students.Where(s => s.Name.StartsWith("A")).ToList();
            Console.WriteLine("Danh sach hoc sinh co ten bat dau chu A");
            foreach (var student in studentsStartingWithA)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }
            Console.WriteLine();

            // d. Tính tổng tuổi của tất cả học sinh trong danh sách
            var totalAge = students.Sum(s => s.Age);
            Console.WriteLine($"Tong tuoi cua hoc sinh: {totalAge}");
            Console.WriteLine();

            // e. Tìm và in ra học sinh có tuổi lớn nhất
            var oldestStudent = students.OrderByDescending(s => s.Age).FirstOrDefault();
            Console.WriteLine("Hoc sinh co tuoi lon nhat:");
            Console.WriteLine($"Id: {oldestStudent.Id}, Name: {oldestStudent.Name}, Age: {oldestStudent.Age}");
            Console.WriteLine();

            // f. Sắp xếp danh sách học sinh theo tuổi tăng dần và in ra danh sách sau khi sắp xếp
            var sortedByAge = students.OrderBy(s => s.Age).ToList();
            Console.WriteLine("Danh sach hoc sinh sau khi sap xep theo tuoi tang dan:");
            foreach (var student in sortedByAge)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }
            Console.ReadLine();
        }
    }
}
