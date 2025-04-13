﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Student : Person
    {
        public string program;
        public int year;
        public double fee;

        public Student(string name, string address, string program, int year, double fee) : base(name, address)
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
            this.year = year;
        }

        public double getFee()
        {
            return fee;
        }

        public void setFee(int fee)
        {
            this.fee = fee;
        }

        public new string toString()
        {
            return $"{name} lives at {address} and is enrolled in {program} for year {year} with a fee of {fee}";
        }

    }
}
