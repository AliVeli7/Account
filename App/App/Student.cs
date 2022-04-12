using System;
using System.Collections.Generic;
using System.Text;

namespace CourseManagmentApplication
{
    class Student
    {
        public string Name { get; set; }

        public String  GroupNo; 

        public bool Type { get; set; }

        public Student[] list;
       
        public Student(string name, string _group,bool type)
        {
            Name = name;
            GroupNo = _group;
            Type = type;
        }

        public void Add(Student student)
        {
            Array.Resize(ref list, list.Length + 1);
            list[list.Length - 1] = student;
        }



    }
}
