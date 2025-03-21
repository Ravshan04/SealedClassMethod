using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationLessonTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(45, 5);
            car.CarAction();
            car.FuelFill(5);
            Console.ReadKey();
        }
    }
}
