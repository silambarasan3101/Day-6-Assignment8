using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignment_1
{
    public class Calc
    {
        public static int CalcSalary(int eType, int eWorkingHours, int eWorkingDays, int eProjectHandles, int eExtras)
        {
            int salary = 0;

            switch (eType)
            {
                case 1:
                    salary = eWorkingHours * eWorkingDays * 100;
                    break;
                case 2:
                    salary = (eWorkingHours * eWorkingDays * 100) + (eProjectHandles * 3000);
                    break;
                case 3:
                    salary = (eWorkingHours * eWorkingDays * 100) + (eProjectHandles * 3000) + (eExtras * 2000);
                    break;
                default:
                    Console.WriteLine("Invalid employee Type!!!");
                    break;
            }
            return salary;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose Employee type:");
            Console.WriteLine("1.HR");
            Console.WriteLine("2.Admin");
            Console.WriteLine("3.Software Developer");
            int eType = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter working hours");
            int eWorkingHours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter no of working days");
            int eWorkingDays = Convert.ToInt32(Console.ReadLine());

            int eProjectHandels = 0;
            int eExtras = 0;
            if (eType == 2 || eType == 3)
            {
                Console.WriteLine("enter project handels");
                eProjectHandels = Convert.ToInt32(Console.ReadLine());

            }
            if (eType == 3)
            {
                Console.WriteLine("enter extras");
                eExtras = Convert.ToInt32(Console.ReadLine());
            }

            int salary = Calc.CalcSalary(eType, eWorkingHours, eWorkingDays, eProjectHandels, eExtras);
            Console.WriteLine("mothly salary:$" + salary);
            Console.ReadKey();
        }
    }
}