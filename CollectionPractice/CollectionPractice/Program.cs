using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> nums = new List<int>();

            //nums.Add(5);
            //nums.Add(55);
            //nums.Add(45);
            //nums.Add(9);

            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var item in words)
            //{
            //    Console.WriteLine(item);
            //}

            //for (int i = 0; i < nums.Count; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}

            //if (nums.Count == 4)
            //{
            //    Console.WriteLine("List count is {0}", nums.Count );
            //}

            //Console.WriteLine(nums[0]);


            //List<Person> people = new List<Person>();

            //Person person1 = new Person();
            //person1.Name = "Sadiq";
            //person1.Id = 5;
            //person1.Email = "sadiq@gmail.com";

            //Person person2 = new Person
            //{
            //    Id = 6,
            //    Name = "Mirsamir",
            //    Email = "mirsamir@gmail.com"
            //};

            //people.Add(person2);

            //people.Add(person1);

            //people.Add(new Person { Id = 1, Name = "Orxan", Email = "orxan@gmail.com" });
            //people.Add(new Person { Id = 44, Name = "Orxan", Email = "orxan17@gmail.com" });
            //people.Add(new Person { Id = 2, Name = "Ramil", Email = "ramil@gmail.com" });
            //people.Add(new Person { Id = 3, Name = "Seid", Email = "seid@gmail.com" });
            //people.Add(new Person { Id = 4, Name = "Emil", Email = "emil@gmail.com" });

            //Console.WriteLine(person2.Name);


            //GetStudents(people);

            //GetNumbers(nums);

            //var result = GetPeopleByName(people, "Orxan");

            //Console.WriteLine(result.Name + " - " + result.Id + " - " + result.Email);

            //var result = GetPeopleByName(people, "Orxan");

            //foreach (var item in result )
            //{
            //    Console.WriteLine(item.Name + " - " + item.Id + " - " + item.Email);
            //}


            //Hashtable datas = new Hashtable();

            //datas.Add(1, "Mamed");
            //datas.Add(2, "Qezenfer");
            //datas.Add(3, "Fidan");

            //foreach (DictionaryEntry item in datas)
            //{
            //    Console.WriteLine(item.Key + "-" + item.Value);

            //}


            //SortedList datas = new SortedList();

            //datas.Add(1, "Mamed");
            //datas.Add(2, "Qezenfer");
            //datas.Add(3, "Fidan");
            //datas.Add(4, "Cavid");

            //foreach (DictionaryEntry item in datas)
            //{
            //    Console.WriteLine(item.Key + "-" + item.Value);
            //}


            //ArrayList datas = new ArrayList();

            //datas.Add( "Mamed");
            //datas.Add(2);
            //datas.Add(true);


            //foreach (var item in datas)
            //{
            //    Console.WriteLine(item);
            //}


            //HashSet<int> datas = new HashSet<int>();

            //datas.Add(1);
            //datas.Add(2);
            //datas.Add(1);

            //foreach (var item in datas)
            //{
            //    Console.WriteLine(item);

            //}


            //Stack<int> datas = new Stack<int>();

            //datas.Push(5);
            //datas.Push(28);
            //datas.Push(19);

            //foreach (var item in datas)
            //{
            //    Console.WriteLine(item);
            //}



            //Queue<int> datas = new Queue<int>();

            //datas.Enqueue(5);
            //datas.Enqueue(28);
            //datas.Enqueue(19);



            //foreach (var item in datas)
            //{
            //    Console.WriteLine(item);
            //}


            //Dictionary<string, string> datas = new Dictionary<string, string>();

            //datas.Add("SuperAdmin", "Mirsamir");
            //datas.Add("Admin", "Seid");
            //datas.Add("Mod", "Sadiq");
            //datas.Add("Member", "Adil");

            //foreach (KeyValuePair<string, string> item in datas)
            //{
            //    //Console.WriteLine($"Name : {item.Value}, Role : {item.Key}");

            //    if (item.Key == "SuperAdmin")
            //    {
            //        Console.WriteLine($"Name : {item.Value}, Role : {item.Key}");
            //        break;
            //    }
            //}


            //SortedList<int, string> datas = new SortedList<int, string>();

            //datas.Add(2, "Fazil");
            //datas.Add(1, "Qabil");
            //datas.Add(3, "Serraf");

            //foreach (KeyValuePair<int, string> item in datas)
            //{
            //    Console.WriteLine(item);

            //    Console.WriteLine(item.Key + "-" + item.Value);
            //}



        }


        

    //    public static Person GetPersonByName(List<Person> people, string name)
    //    {
    //        var person = people.Find(m => m.Name == name);
    //        return person;
    //    }


    //    public static List<Person> GetPeopleByName(List<Person> people, string name)
    //    {
    //        var persons = people.FindAll(m => m.Name == name);
    //        return persons;
    //    }



    //    public static void GetStudents(List<Person> students)
    //    {
    //        foreach (var stu in students)
    //        {
    //            Console.WriteLine("Students : Id - {0}, Name - {1}, Email - {2}", stu.Id, stu.Name, stu.Email);
    //        }

    //    }


    //    public static  void GetNumbers(List<int> numbers)
    //    {
    //        foreach (var item in numbers)
    //        {
    //            Console.WriteLine(item);
    //        }
    //    }
    //}



    //public class Person
    //{
    //    public int Id { get; set; }

    //    public string Name { get; set; }

    //    public string Email { get; set; }
    //}
}
