

using System;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            ProgrammingLanguage language1 = new ProgrammingLanguage("C#", 2000);
            ProgrammingLanguage language2 = new ProgrammingLanguage("C++", 1999);
            ProgrammingLanguage language3 = new ProgrammingLanguage("Java", 1998);
            ProgLanguageList<ProgrammingLanguage> progLanguageList = new ProgLanguageList<ProgrammingLanguage>();
            progLanguageList.Add(language1);
            progLanguageList.Add(language2);
            progLanguageList.Add(language3);
            
            
            


            foreach (ProgrammingLanguage item in progLanguageList.list)
            {
                item.Year.CompareTo(item.Year);
                Console.WriteLine(item);
            }

            
            Array.Sort(progLanguageList.list);
            foreach (var item in progLanguageList.list)
            {
                Console.WriteLine(item);
            }


        }

    } 
    
}
