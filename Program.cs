using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace StructsAndEnums
{
    public enum Possitions
    {
        boss = 250,
        deputy = 180,
        cleaner = 380,
        cashier = 260,
        theRightHand = 320
    }

    class ClassEnum
    {
        private DateTime dateTime1;
        private DateTime dateTime2;
        //--------------------

        public ClassEnum() { }

        public ClassEnum(DateTime dateTime1, DateTime dateTime2)
        {
            this.dateTime1 = dateTime1;
            this.dateTime2 = dateTime2;
        }

        public TimeSpan AmoungOfDaysToBirthday(DateTime ob1, DateTime ob2)
        {
            TimeSpan time = ob1 - ob2;
            Console.WriteLine($"The days up to bithday!\t{time}");

            return time;
        }
        //------------------------------------------------------------------
    }

    class Program
    {
        static void Main(string[] args)
        {
            //DateTime date1 = new DateTime(2014, 04, 15);
            //DateTime date2 = new DateTime(2015, 04, 15);

            //ClassEnum someClass = new ClassEnum();
            //someClass.AmoungOfDaysToBirthday(date1, date2);


            // Task 2

            //string str = "I wanna fuc* you baby)";
            //StaticPrint.Print(str, StaticPrint.Colors.green);


            // Task 3

            Accauntant ac = new Accauntant();
            ac.AskForBonus(Possitions.boss, 246);



        }
    }
}
