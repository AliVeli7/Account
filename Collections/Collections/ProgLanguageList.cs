using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    class ProgLanguageList <T>
        where T:ProgrammingLanguage
    {

        public  T[] list;
        public ProgLanguageList()
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
            foreach (ProgrammingLanguage item in list)
            {
                Console.WriteLine(item);
            }
        }

        
    }
}
