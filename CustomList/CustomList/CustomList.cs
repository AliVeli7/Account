using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Customlist<T> where T: class
    {
       
        int _capacity;
        public int Capacity
        {
            get
            {
                return _capacity;
            }
            protected set
            {
                _capacity = value;
            }
        }
        public bool IsZero;
        public int index=0;
        public T[] list;

        public Customlist(int capacity=1)
        {
            list = new T[Capacity];
            if (capacity==1)
            {
                IsZero = true;
                _capacity = capacity;
            }
            else
            {
                IsZero = false;
                _capacity = capacity;
            }
            
        }

        

        public bool Contains(T member)
        {
            bool IsAvialable = false;


            for (int i = 0; i < list.Length; i++)
            {
                if (list[i]==member)
                {
                    IsAvialable = true;
                }
                
            }

            if (IsAvialable == true)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public T this[int index]
        {
            get
            {
                if (index > list.Length - 1)
                {
                    throw new OutOfCapasityException("This index is not exist");
                }
                else if (list[index] == null)
                {
                    throw new EmptyBookException("This index is not set");
                }
                return list[index];

            }
            set
            {
                if (index <= list.Length - 1 && list[index] == null)
                {
                    list[index] = value;
                }
            }

        }
        public void Add(T member)
        {
            if (IsZero==true)
            {
                bool IsAvialable = false;


                for (int i = 0; i < list.Length; i++)
                {
                    if (list[i] == member)
                    {
                        IsAvialable = true;
                    }

                }
                if (IsAvialable == false)
                {
                   
                    if (index > list.Length)
                    {
                        Array.Resize(ref list, list.Length *2);
                        Console.WriteLine("afaf");
                    }
                    
                    list[index] = member;
                    index++;
                }
                else
                {
                    Console.WriteLine("not Added");
                }
            }
            else
            {

                bool IsAvialable = false;


                for (int i = 0; i < list.Length; i++)
                {
                    if (list[i] == member)
                    {
                        IsAvialable = true;
                    }

                }
                if (IsAvialable == false)
                {
                    index++;
                    if (index > list.Length)
                    {
                        Array.Resize(ref list, list.Length +Capacity);
                    }
                    list[index] = member;
                }
                else
                {
                    Console.WriteLine("not Added");
                }

            }

        }



        public void clear()
        {
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = null;
            }
        }




        public void remove(int index)
        {
            int j = -1;
            for (int i = 0; i < list.Length; i++)
            {              
                if (i!=index)
                {
                    j++;
                    list[j] = list[i];
                }
            }
        }


        public void remove(T member)
        {
            int i;
            for (i = 0; i < list.Length; i++)
            {
                if (list[i]==member)
                {
                    break;
                }
            }


            for (int j = 0; j < list.Length; j++)
            {
                int n = -1;
                if (j!=i)
                {
                    n++;
                    list[j] = list[j];
                }
                
            }
        }

        


    }
}
