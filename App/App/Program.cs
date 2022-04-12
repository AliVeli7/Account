using System;
using System.Collections.Generic;

namespace CourseManagmentApplication
{
    class Program
    {

        static void Main(string[] args)
        {
            
            List<Student> students = new List<Student>();
            Student student;
            List<Group> group  = new List<Group>();
            Group groups;
            
            for (int i = 1; i!=0; i++)
            {
                Console.WriteLine("1.Teni qrup Yarat\n 2.Grouplarin siyahisi\n 3.Qrup uzerinde duzelis \n 4. qrupdaki Telebelerin siyahisi \n 5.Butun telebelerin siyahisi \n 6.telebe yarat");
                int number = Convert.ToInt32(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        bool isOnline;
                       
                        Console.WriteLine("Please Enter Group No");
                        string no = Console.ReadLine();
                        Console.WriteLine("Please Enter Group Category");
                        string category = Console.ReadLine();
                        Console.WriteLine("Do you want to Online Group : Yes-1 or No-2?");
                        isOnline = Convert.ToBoolean(Console.ReadLine());
                        
                        groups = new Group(no, category, isOnline);
                        group.Add(groups);

                        break;
                    case 2:
                        foreach (var item in group)
                        {
                            Console.WriteLine(item.No);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter group No");
                        string groupNo = Console.ReadLine();
                        foreach (var item in group)
                        {
                            if (item.No == groupNo)
                            {
                                Console.WriteLine("Enter New No");
                                string NewNo = Console.ReadLine();
                                foreach (var checkitem in group)
                                {
                                    if (checkitem.No == NewNo)
                                    {
                                        Console.WriteLine("There is the same No in Group list");
                                    }
                                    else
                                    {
                                        item.No = NewNo;
                                    }
                                }
                            }
                        }

                        break;
                    case 4:
                        Console.WriteLine("Enter gROUP no");
                        string No = Console.ReadLine();

                        bool IsAvailable = false;
                        foreach (var item in group)
                        {
                            if (item.No==No)
                            {
                                IsAvailable = true;
                            }
                            
                        }

                        if (IsAvailable==true)
                        {
                            foreach (var Stitem in students)
                            {
                                if (No == Stitem.GroupNo)
                                {
                                    Console.WriteLine($"{Stitem.Name} {Stitem.GroupNo}");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Group is not Exist");
                        }
                        



                        break;
                    case 5:
                        foreach (var item in students)
                        {
                            Console.WriteLine($"{item.Name} {item.GroupNo}");
                        }
                        break;
                    case 6:
                        bool StudentType;
                        int studentCheck;
                        Console.WriteLine("Please Enter  Name");
                        string studentName = Console.ReadLine();
                        Console.WriteLine("Do you want to Zemanetli Group : Yes-1 or No-2?");
                        studentCheck = Convert.ToInt32(Console.ReadLine());
                        if (studentCheck == 1)
                        {
                            StudentType = true;
                        }
                        else
                        {
                            StudentType = false;
                        }
                        Console.WriteLine("Enter Group No");
                        string studentGroup = Console.ReadLine();
                        foreach (var item in group)
                        {
                            if (item.No == studentGroup)
                            {
                                student = new Student(studentName, studentGroup, StudentType);
                                students.Add(student);
                            }
                        }
                        break;
                    default:
                        break;
                }

            }




        }
    }
}
