using System;
using ConsoleApp10.Models;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("mirzeaysel@gmail.com","Aysel2022");
            Console.WriteLine(user.email);
            Console.WriteLine(user.Password);
            Console.WriteLine(user.Id);

        ShowInfo:
        menu:
            Console.WriteLine("====== User Menu ======\n" + "1. Show info\n" + "2. Create new group\n");

            Console.Write("Your choice: ");
            string choice = Console.ReadLine();

            Group group = new Group("AP04", 15);
            Student student = new Student("Roza Abdullayeva", 100);
            switch (choice)
            {
                case "1":
                    user.ShowInfo();
                    Console.WriteLine("***********************************************************8******************************************************************************");
                    break;
                    //goto menu;
                case "2":
                    Console.WriteLine(group.GroupNo);
                    Console.WriteLine(group.StudentLimit);
                    Console.WriteLine("***************************************************************************************************************************************");
                    break;

                   
                    if (Group.CheckGroupNo("AA101") == true)
                    {
                        Console.WriteLine(group.GroupNo);
                    }
                    if (group.StudentLimit >5 || group.StudentLimit <18)
                    {
                        Console.WriteLine();
                    }
                    Console.WriteLine("Qrup uğurla yaradıldı");

                    Group group1 = new Group("AA1",14);

                    bool check = true;
                    Console.WriteLine("1.Show all students");
                    Console.WriteLine("2.Get student by id");
                    Console.WriteLine("3.Add student");
                    string groupChoice = Console.ReadLine();
                    switch (groupChoice)
                    {
                        case "1":
                            student.StudentInfo();

                            break;
                        case "2":
                            group.GetAllStudents();
                            break;
                        case "3":
                            student.StudentInfo();
                             Group group2 = new Group("A2", 10);
                            group.AddStudent(student);
                            break;
                        case "0":
                            Console.WriteLine("Menu Stop");
                            break;
                        default:
                            Console.WriteLine("make the right groupChoice");
                            break;
                    }
                    break;
                default:
                    break;
            }

        }

    }




}

        
    


