using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Builder
{
   
        public enum Streams { CS, IT, Electrical, Electronic, Mech, Civil };
        public class Student
        {
            private int rollno, m1, p1, s1;
            private string name;
            double percentage, total;
            private Streams streams;
            public Student(string name, int rollno, int m1, int p1, int s1, Streams streams)
            {
                this.name = name;
                this.rollno = rollno;
                this.streams = streams;
                this.m1 = m1;
                this.p1 = p1;
                this.s1 = s1;
            }
            public void Calculate()
            {
                total = m1 + p1 + s1;
                percentage = (total / 300) * 100;
            }

            public override string ToString()
            {
                return $"The name is = {name}\n The roll no is = {rollno}\n The percentage is = {percentage}.\n stream is = {streams}";
            }
        }
    

}
