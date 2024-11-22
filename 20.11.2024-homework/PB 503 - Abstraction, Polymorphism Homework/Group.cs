using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PB_503___Abstraction__Polymorphism_Homework
{
    public class Group : Student
    {
       
        public string GroupNo;
        private int _studentLimit;

        private int _minStudentLimit = 5;
        private int _maxStudentLimit = 18;
        public int StudentLimit
        {
            get
            {
                return _studentLimit;
            }
            set
            {
                if (value >= _minStudentLimit && value <= _maxStudentLimit)
                {
                    _studentLimit = value;
                }
                else
                {
                    Console.WriteLine("Group must contain from 5 to 18 student!");
                }
            }
        }

        public Student[] _students = Array.Empty<Student>();
        public bool CheckGroupNo(string groupNo)
        {
            for (int i = 0; i < 2; i++)
            {
                if (char.IsLower(groupNo[i]))
                {
                    return false;
                }
            }

            for (int i = 2; i < groupNo.Length; i++)
            {
                if (!char.IsDigit(groupNo[i]))
                {
                    return false;
                }
            }
            return true;
        }

        


        public void GetStudent(byte ID)
        {
            foreach (Student std in _students)
            {


            }

        }

        public Student[] GetAllStudents(Student student)
        {
            Student[] students = Array.Empty<Student>();
            Array.Resize(ref students, students.Length + 1);
            students[^1] = student;
            foreach (Student std in students)
            {
                Console.WriteLine($"{std.Fullname},{std.Point} ");

            }
            return students;
        }


        public Student [] AddStudent(Student student)
        {
            Array.Resize(ref _students, _students.Length + 1);
            _students[^1] = student;

            Student[] newStd = Array.Empty<Student>();

            if (_students.Length >= _minStudentLimit || _studentLimit <= _maxStudentLimit )
            {
                
                newStd = new Student[_students.Length];                
            }
            

            return newStd;

            //foreach (var stundent in _students)
            //{
            //    if (_students.Length < 5 || _students.Length > 18)
            //    {
            //        Console.WriteLine("--");
            //    }
            //    else
            //    {
            //        Console.WriteLine("+++");
            //    }
            //}

        }



    }
}
