using System;

namespace ElevatorProject
{
    class MainTest
    {        
        static void Main(string[] args)
        {
            Console.WriteLine("Elevator Test");
            //Создаёт лифт и экземпляры юзеров
            Elevator myElevator = new Elevator(200);

            Employee Director = new Employee();
            Director.IsExecutive = true;
            Director.Weight = 100;

            Employee Secretary = new Employee();
            Secretary.Weight = 160;

            //Все сотрудники попадают в лифт
            myElevator.InUser(Director);
            Console.WriteLine(String.Format("MaxWeight 1 : {0}", myElevator.CurrentWeight));

            myElevator.InUser(Secretary);
            Console.WriteLine(String.Format("MaxWeight 2 : {0}", myElevator.CurrentWeight));

            //Проверяет - может ли лифт двигаться?
            Console.WriteLine(String.Format("Elevator reach the max weight allowed? : {0}", myElevator.CheckMaxWeightAllowedReached()));

            //Проверяет - может ли лифт двигаться?
            Console.WriteLine(String.Format("This Employee can go to Vip section? : {0}", myElevator.GoToVipSection(Director)));
            Console.WriteLine(String.Format("This Employee can go to Vip section? : {0}", myElevator.GoToVipSection(Secretary)));

            //Чтобы не вылетала консоль.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }        
    }
}

