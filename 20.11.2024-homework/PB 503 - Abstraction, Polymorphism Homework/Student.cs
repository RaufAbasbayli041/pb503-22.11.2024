using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB_503___Abstraction__Polymorphism_Homework
{
    public class Student : User
    {
        private double _point;
        private byte ID { get; set; }
        public static byte Count;
        public string Fullname { get; set; }
        public double Point
        {
            get
            {
                return _point;
            }
            set
            {
                if (value >= 0)
                {
                    _point = value;
                }
                else
                {
                    Console.WriteLine("Point can't be less than zero!");
                }
                
            }
        }

        public void StudentInfo()
        {
            Count++;
            ID = Count;
            Console.WriteLine($"ID - {ID}, Fullname - {Fullname}, Point - {Point}");
        }

    }
}
