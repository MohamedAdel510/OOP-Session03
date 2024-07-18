using Demo.Binding;
using Demo.Interface;
using Demo.Interface.Example03;
using Demo.Built_In_Interface;
using System.Numerics;

namespace Demo
{
    internal class Program
    {
        #region Binding
        public static void ProcessEmployee (Employee e)
        {
            if(e is not null)
            {
                e.MyFun01(); // static bindaing 
                e.MyFun02();
            }
        }

        //public static void ProcessEmployee(PartTimeEmployee partTimeEmployee)
        //{
        //    partTimeEmployee.MyFun01();
        //    partTimeEmployee.MyFun02();
        //}
        #endregion

        #region Series interface Example
        public static void Print10NumbersFromSeries(ISeries seriesByTwo)
        {
            if(seriesByTwo is not null)
            {
                for(int i = 0; i < 10; i++)
                {
                    Console.WriteLine(seriesByTwo.Current);
                    seriesByTwo.GetNext();
                }
                seriesByTwo.Reset();
                Console.WriteLine();
            }
        }
        //public static void Print10NumbersFromSeries(SeriesByThree seriesByThree)
        //{
        //    if (seriesByThree is not null)
        //    {
        //        for (int i = 0; i < 10; i++)
        //        {
        //            Console.WriteLine(seriesByThree.Current);
        //            seriesByThree.GetNext();
        //        }
        //        seriesByThree.Reset();
        //        Console.WriteLine();
        //    }
        //}

        //public static void Print10NumbersFromSeries(SeriesByFour seriesByFour)
        //{
        //    if (seriesByFour is not null)
        //    {
        //        for (int i = 0; i < 10; i++)
        //        {
        //            Console.WriteLine(seriesByFour.Current);
        //            seriesByFour.GetNext();
        //        }
        //        seriesByFour.Reset();
        //        Console.WriteLine();
        //    }
        //}
        #endregion
        static void Main(string[] args)
        {

            #region Binding
            //TypeA RefBase = new TypeB(1, 2);
            ////is a reference from parent will take the form of the child in virtual function only.

            //RefBase.A = 10;
            //// RefBase.B = 20 is not valid 
            //RefBase.MyFun01();
            //RefBase.MyFun02();
            #endregion

            #region Binding is a behaviour
            //Employee fullTimeEmployee = new FullTimeEmployee()
            //{
            //    Id = 1, Name = "Ahmed", Age = 23, Salary = 15000
            //};
            //Employee partTimeEmployee = new PartTimeEmployee() { Id = 2, Name = "Maohamed", Age = 23, HourRate = 60 };

            //ProcessEmployee(fullTimeEmployee);
            //Console.WriteLine();
            //ProcessEmployee(partTimeEmployee);
            #endregion

            #region Binding Ex02
            //TypeA typeA = new TypeC() { A = 1, B = 2, C = 3 };
            //typeA.MyFun01();
            //typeA.MyFun02();

            //Console.WriteLine();
            //TypeB typeB = new TypeC() { A = 4, B = 5, C = 6 };
            //typeB.MyFun01();
            //typeB.MyFun02();

            //Console.WriteLine();
            //TypeC typeC = new TypeD() { A = 7, B = 8, C = 9, D = 10 };
            //typeC.MyFun01();
            //typeC.MyFun02();

            //Console.WriteLine();
            //TypeD typeD = new TypeE() { A = 11, B = 12, C = 13, D = 14, E = 15 };
            //typeD.MyFun01();
            //typeD.MyFun02();// new chain of MyFun02()
            #endregion

            #region Interface
            //// myType = new IMyType(); // not valid can not create object from the interface only reference

            //// object from implementation class
            //MyType myType = new MyType();
            //myType.Salary = 10000;
            //myType.MyFun();

            ////Reference from the interface refaring to the implementation class
            //IMyType myType1 = new MyType();
            //myType1.Salary = 15000;
            //myType1.MyFun();
            //myType1.Print();
            #endregion

            #region Interface Ex 02
            //SeriesByTwo seriesByTwo = new SeriesByTwo();
            //Print10NumbersFromSeries(seriesByTwo);
            //Console.WriteLine();    
            //SeriesByThree seriesByThree = new SeriesByThree();
            //Print10NumbersFromSeries(seriesByThree);
            //Console.WriteLine();
            //SeriesByFour seriesByFour = new SeriesByFour();
            //Print10NumbersFromSeries(seriesByFour);
            #endregion

            #region Interface Ex 03
            //Car car = new Car();
            //Imovable car1 = new Car();
            //car.Forword();
            //car.Right();
            //car.Left();
            //car.Backword();

            //// or using reference from interface Imovable refaring to object from car.
            //Console.WriteLine();

            //car1.Forword(); 
            //car1.Right();
            //car1.Left();
            //car1.Backword();

            //// object from Airplan that implement IMovable and IFlyable interfaces explicitly
            //// only can access the Speed property can not acess the implemented methods
            //// reference from interface refaring to object from the implemntation class can
            //// acess properties and it's implemented methods
            //AirPlan plan = new AirPlan();
            //plan.Speed = 1000;

            //Console.WriteLine();
            //Imovable plan2 = new AirPlan();
            //plan2.Backword();
            //plan2.Forword();
            //plan2.Right();
            //plan2.Left();

            //Console.WriteLine();

            //IFlyable plan3 = new AirPlan();
            //plan3.Backword();
            //plan3.Forword();
            //plan3.Right();
            //plan3.Left();
            #endregion

            #region Shallow Copy and Deep Copy
            //int[] Arr01 = { 1, 2, 3, };
            //int[] Arr02 = { 4, 5, 6, };
            //// Shallow Copy
            //Console.WriteLine(Arr01.GetHashCode());
            //Console.WriteLine(Arr02.GetHashCode());

            //Arr02 = Arr01;   // Shallow Copy

            //Console.WriteLine("After Shallow Copy");
            //Console.WriteLine(Arr01.GetHashCode());
            //Console.WriteLine(Arr02.GetHashCode());

            //Arr01[0] = 100;
            //Console.WriteLine(Arr01[0]);
            //Console.WriteLine(Arr02[0]);

            ////Deep Copy
            //Console.WriteLine(Arr01.GetHashCode());
            //Console.WriteLine(Arr02.GetHashCode());

            //Arr02 = (int[]) Arr01.Clone();

            //Console.WriteLine("After Deep Copy");
            //Console.WriteLine(Arr01.GetHashCode());
            //Console.WriteLine(Arr02.GetHashCode());

            //Arr01[0] = 100;
            //Console.WriteLine(Arr01[0]);
            //Console.WriteLine(Arr02[0]);
            #endregion

            #region IClonable
            //Employee02 employee1 = new Employee02() { Id = 1, Name = "A", Salary = 10000};
            //Employee02 employee2 = new Employee02() { Id = 2, Name = "B", Salary = 15000 };

            //Console.WriteLine(employee1.GetHashCode());
            //Console.WriteLine(employee2.GetHashCode());
            //Console.WriteLine(employee1);
            //Console.WriteLine(employee2);

            //Console.WriteLine("After Deep Copy");
            //employee2 = (Employee02)employee1.Clone();

            //Console.WriteLine(employee1.GetHashCode());
            //Console.WriteLine(employee2.GetHashCode());
            //Console.WriteLine(employee1);
            //Console.WriteLine(employee2);

            //Console.WriteLine();
            //Employee02 employee3 = new Employee02(employee2); // using Copy Constructor
            //Console.WriteLine(employee3);
            #endregion

            #region ICombarable
            //Employee02[] employees =
            //{
            //    new Employee02(){ Id = 1, Name = "C", Salary = 3000},
            //    new Employee02(){ Id = 2, Name = "D", Salary = 5000},
            //    new Employee02(){ Id = 3, Name = "E", Salary = 2000},
            //    new Employee02(){ Id = 4, Name = "F", Salary = 8000},
            //};

            //// Array.Sort(employees);
            //Console.WriteLine(employees[0].CompareTo(employees[1]));
            #endregion
        }
    }
}
