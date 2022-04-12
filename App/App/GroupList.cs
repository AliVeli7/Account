using System;
using System.Collections.Generic;
using System.Text;

namespace CourseManagmentApplication
{
    class GroupList<T> where T :Group
    {
        public T[] list;
        public GroupList()
        {
            list = new T[0];
        }


        public void Add(T member)
        {
            Array.Resize(ref list, list.Length + 1);
            list[list.Length - 1] = member;
        }




        public void ShowAll()
        {
            foreach (Group item in list)
            {
                Console.WriteLine(item);
            }
        }



    }
}
