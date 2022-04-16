using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructsAndEnums
{
    class Accauntant
    {

        public bool AskForBonus(Possitions pos, int hours)
        {
            switch (pos)
            {
                case Possitions.boss:
                    if((Possitions)hours > Possitions.boss)
                        Console.WriteLine("There is your bonuses!");
                    else
                    {
                        Console.WriteLine("Too little of working hours!");
                    }
                    break;

                case Possitions.deputy:
                    if((Possitions)hours > Possitions.deputy)
                        Console.WriteLine("There is your bonuses!");
                    else
                    {
                        Console.WriteLine("Too little of working hours!");
                    }
                    break;

                case Possitions.cleaner:
                    if ((Possitions)hours > Possitions.cleaner)
                        Console.WriteLine("There is your bonuses!");
                    else
                    {
                        Console.WriteLine("Too little of working hours!");
                    }
                    break;

                case Possitions.cashier:
                    if ((Possitions)hours > Possitions.cashier)
                        Console.WriteLine("There is your bonuses!");
                    else
                    {
                        Console.WriteLine("Too little of working hours!");
                    }
                    break;

                case Possitions.theRightHand:
                    if ((Possitions)hours > Possitions.theRightHand)
                        Console.WriteLine("There is your bonuses!");
                    else
                    {
                        Console.WriteLine("Too little of working hours!");
                    }
                    break;

                default:
                    {
                        return false;
                    }
            }
            return true;
        } 
    }
}
