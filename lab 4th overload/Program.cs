using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

namespace lab_4th_overload
{
     public class List1<T>
     {
            List<int> list = new List<int>();
            public List1(List<int> list)
            {
                this.list = list;
            }

            public void Print()
            {
                foreach (var u in list)
                {
                    Console.WriteLine(u);
                }
                Console.WriteLine();
            }
            public static List1<T> operator +(List1<T> a, List1<T> b)
            {
                a.list.Union(b.list);
                return new List1<T>(a.list);
            }
            public static List1<T> operator --(List1<T> a)
            {
                a.list.Remove(1);
                return new List1<T>(a.list);
            }

            public static bool operator ==(List1<T> a1, List1<T> a2)
            {
                return a1.list.SequenceEqual(a2.list);
            }
            public static bool operator !=(List1<T> a1, List1<T> a2)
            {
                return !a1.list.SequenceEqual(a2.list);
            }
            public static bool operator ~(List1<T> a)
            {

                if (!a.list.Any())
                {
                    return true;
                }
                else 
                return false;
            }

        public class Date
        {
            public int Day { get; set; }
            public string Month { get; set; }
            public int Year { get; set; }


            public Date(int day, string month, int year)
            {
                Day = day;
                Month = month;
                Year = year;
            }
            public void GetDay()
            {
                Console.WriteLine(Day + " " + Month + " " + Year);
            }
        }
        public class Owner
        {
            public string Name { get; set; }
            public string Organization { get; set; }
            public int Id { get; set; }


            public Owner(string name, string org, int id)
            {
                Name = name;
                Organization = org;
                Id = id;
            }
            public void GetInfoAboutOwner()
            {
                Console.WriteLine(Name + " " + Organization + " " + Id);
            }
        }




    }
        
    class Program
    {
        static void Main(string[] args)
        {
            List1<int> list1 = new List1<int>(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 66 });
            List1<int> list2 = new List1<int>(new List<int> { 1, 2, 66 });
            List1<int> list3 = list1 + list2;
            Console.WriteLine("Объеденение двух списков");
            list3.Print();
            List1<int> list4 = --list2;
            Console.WriteLine("Удаление элемента из начала списка");
            list4.Print();
            Console.WriteLine("Проверка на равенство");
            Console.WriteLine(list3 == list4);
            Console.WriteLine("Проверка пустой ли список");
            List1<int> list5 = new List1<int>(new List<int> { });
            Console.WriteLine(~list5);
            List1<string>.Date  today = new List1<string>.Date(20, "October", 2021);
            today.GetDay();
            List1<string>.Owner owner =new List1<string>.Owner("Alexandra","BSTU", 468995);
            owner.GetInfoAboutOwner();
        }
    }
}