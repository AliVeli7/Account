using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Collections
{
    public class ProgrammingLanguage:IComparable<ProgrammingLanguage>
    {
        
        public string Name;
        public  int Year;



        public ProgrammingLanguage(string name, int year)
        {
            Name = name;
            Year = year;
           
        }
        
        public int CompareTo(ProgrammingLanguage other)
        {
            return this.Year.CompareTo(other.Year);
        }

        public override string ToString()
        {
            return $"Name:{Name} Year:{Year}";
        }



    }
}
