using Enum_Struct_Upcasting_Downcasting.Models;
using System;

namespace Enum_Struct_Upcasting_Downcasting
{
    class Program
    {
        
        static void Main(string[] args)
        {
            #region Params
            //Getelements(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10);

            #endregion


            #region Enum
            //CheckRole(101);

            #endregion

            #region Nullable
            //Test test = new Test();
            //Console.WriteLine(test.Word);

            //string name = null;
            //int? age = null;

            //var result = age == null ? 24 : 25;

            //var result = age ?? 25;

            //Console.WriteLine(result);

            //Test test = null;
            //Console.WriteLine(test.Number.ToString());
            #endregion

            #region Struct
            //Test1 test = new Test1("Ilkin");

            //Console.WriteLine(test.Num);

            //Test2 test = new Test2(5);
            #endregion

            #region Upcasting,Boxing,Implicit
            //Eagle eagle1 = new Eagle();


            //Animal eagle2 = eagle1;

            //Eagle eagle3 = new Eagle();

            //Shark shark1 = new Shark();

            //Animal shark2 = new Shark();

            //Animal[] animals = { eagle1, eagle2, eagle3,shark1,shark2 };

            //foreach (var item in animals)
            //{
            //    item.Eat();
            //}

            #endregion

            #region Downcaasting
            //int n = 435;
            //byte m = (byte)n;
            //Console.WriteLine(n);
            //Shark shark1 = new Shark();

            //Animal shark2 = new Shark();

            //Shark shark3 = (Shark)shark2;

            //object[] objects = { 2, 5, "Salam", shark2 };

            //foreach (var item in objects)
            //{
            //    if (item is Shark)
            //    {
            //        ((Shark)item).Weight = 500;
            //        Console.WriteLine(((Shark)item).Weight);
            //    }

            //}
            #endregion

            #region Upcasting Boss
            //Boss boss1 = new Boss();

            //Ceo boss2 = boss1;

            //Boss boss3 = new Boss();

            //Employers employer1 = new Employers();

            //Ceo employer2 = new Employers();

            //Employers employer3 = new Employers();

            //Ceo[] ceo = { boss1, boss2, boss3, employer1, employer2, employer3 };

            //foreach (var item in ceo)
            //{
            //    item.Money();
            //}
            #endregion


            #region downcasting Employers

            Employers employer1 = new Employers();

            Ceo employer2 = new Employers();

            Employers employer3 = (Employers)employer2;


            object[] objects = { 1, 2, "Hello World", employer3 };

            foreach (var item in objects)
            {
                if (item is Employers)
                {
                    ((Employers)item).tired = 0;
                    Console.WriteLine(((Employers)item).tired);
                }

            }
            #endregion











        }



        #region Params
        //public static void Getelements(params int[] nums)
        //{
        //    foreach (var item in nums)
        //    {
        //        Console.WriteLine(item);
        //    }





        //}

        #endregion

        #region Enum
        //static void CheckRole(int RoleId) 
        //{

        //    switch (RoleId)
        //    {
        //        case (int)Roles.SuperAdmin:
        //            Console.WriteLine("SuperAdmin");
        //            break;
        //        case (int)Roles.Admin:
        //            Console.WriteLine("Admin");
        //            break;
        //        case (int)Roles.Member:
        //            Console.WriteLine("Member");
        //            break;

        //        default:
        //            Console.WriteLine("Not found Role Id");
        //            break;


        //    }

        #endregion

    }

    #region Stuct
    // struct Test1:ITest
    // {
    //     public int Num { get; set; }
    //     public Test1(string name) 
    //     {
    //         Num = 101;
    //         Console.WriteLine(Num);
    //     }
    // }

    // class Test2 
    // {
    //     public int MyProperty { get; set; } = 101;

    //     public Test2 () 
    //     {
    //         Console.WriteLine("Bosh");
    //     }
    //     public Test2(int a) 
    //     {
    //         Console.WriteLine("Doludur");
    //     }
    // }

    // struct Test3 
    // { 

    // }

    //interface ITest 
    //{ 

    //}
    #endregion 




    #region Nullable

    //class Test 
    //{
    //    public int Number { get; set; }
    // public string Word { get; set; }




    // }
    #endregion

    #region Enum
    //public enum Roles
    //{
    //    SuperAdmin = 101,
    //    Admin,
    //    Member
    //}

    #endregion








}
