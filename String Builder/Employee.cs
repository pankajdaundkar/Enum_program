using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Builder
{
    public class Employee
    {
        public enum Dept { HR = 101, Admin, Sales, Development, Testing };


        public class Employee1 
        {
            protected int id;
            protected string name;
            protected double bs, hra, ta, da, pf, gross;
            private static int count;
            private Dept dept;
            public Employee1(string name, double bs, Dept dept)
            {
                count++;
                id = count;
                this.name = name;
                this.bs = bs;
                this.dept = dept;
            }
            // to allow method to be overriden we use virtual keyword
            public virtual void CalculateSalary()
            {
                hra = bs * 0.40;
                ta = bs * 0.20;
                da = bs * 0.15;
                pf = bs * 0.12;
                gross = (bs + hra + ta + da) - pf;
            }
            public string PrintEmpSalary()
            {
                return $"id={id}, name={name}, gross ={gross}";
            }
              //ToString()  --> from base class object
            public override string ToString()
            {
                return $"Employee -> id = {id}, name = {name}, gross = {gross}, Dept = {dept} ";
            }

            public string PrintDetails()
            {
                return $"Employee -> id = {id}, name = {name}, gross = {gross} ";
            }
              public string Print()
              {
                 return $"Employee -> id = {id}, name = {name}, gross = {gross}";
              }
        }

    }
}
