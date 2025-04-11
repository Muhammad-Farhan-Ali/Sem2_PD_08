using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Student:Person
    {
        private string program;
        private int year;
        private double fee;

        public Student(string name, string address,string program,int year,double fee) : base(name, address)
        {
            this.program = program;
            this.year = year;
            this.fee = fee;
        }
        public string getProgram()
        {
            return program;
        }
        public void setProgram(string program)
        {
            this.program = program;
        }
        public int getYear()
        {
            return year;
        }
        public void setYear(int year)
        {
            if(year < 0)
            {
                return;
            }
            this.year = year;
        }
        public double getFee()
        {
            return fee;
        }
        public void setFee(double fee)
        {
            if(fee< 0)
            {
                return;
            }
            this.fee = fee;
        }
        public new string toString()
        {
            string person=base.toString();
            return $"Student[{person}, program={program},year={year},fee={fee}]";
        }
    }
}
