using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleGiveNumber
{
    class Program
    {
        protected static int numberHandle = 0;
        protected static int numberHandle2 = 0;
        static void Main(string[] args)
        {
             loadTypeNumber();
        }

        protected static void loadTypeNumber() {
            numberHandle = 0;
            Console.WriteLine("Type 1 or 2: ");
            numberHandle2 = Convert.ToInt32(Console.ReadLine());
            if (numberHandle2 == 1)
            {
                Console.WriteLine("Type a number between 2 and 9: ");
                numberHandle = Convert.ToInt32(Console.ReadLine());
                if (numberHandle <= 9)
                {
                    if (numberHandle > 1)
                    {
                        loadNumber(numberHandle);
                    }
                    else
                    {
                        loadTypeNumber();
                    }
                }
                else {
                    loadTypeNumber();
                }

            }
            else if (numberHandle2 == 2)
            {
                Console.WriteLine("Type a number between 2 and 9: ");
                numberHandle = Convert.ToInt32(Console.ReadLine());
                if (numberHandle <= 9)
                {
                    if (numberHandle > 1)
                    {
                        loadNumber2(numberHandle);
                    }
                    else {
                        loadTypeNumber();
                    }
                }
                else {
                    loadTypeNumber();
                }
            }
            else {
                loadTypeNumber();
            }
            Console.ReadLine();
        }





        //2.......................................
        protected static void loadNumber2(int number2) {
            int count3To2 = number2;
            int count7To2 = number2;
            int count5To2 = 0;
            for (int count1 = 1;count1 <= ((number2*2)-1); count1++) {
                string handle = "";
                int count4To2 = number2;
                int count6To2 = count3To2;
                for (int count2 = 1;count2 <= ((number2 * 2) - 1); count2++) {
                    if (count3To2 == number2)
                    {
                        handle += number2.ToString();
                    }
                    else {
                        if (count4To2 == number2)
                        {
                            handle += count4To2.ToString();
                            count4To2--;
                        }
                        else if (count4To2 == count3To2)
                        {
                            if (count2 <= ((number2 * 2) - 1) - count5To2)
                            {
                                handle += count4To2.ToString();
                            }
                            else {
                                count6To2++;
                                handle += count6To2.ToString();
                            }
                        }
                        else {
                            handle += count4To2.ToString();
                            count4To2--;
                        }
                    }

                    if (count2 >= ((number2 * 2) - 1)) {
                        if (count7To2 >= 2)
                        {
                            count3To2--;
                            count5To2++;
                            count7To2--;
                        }
                        else {
                            count3To2++;
                            count5To2--;
                        }
                        Console.WriteLine(handle);
                        handle = "";
                    }
                }
            }
            loadTypeNumber();
        }











        //1.....................................
        protected static void loadNumber(int numberHandles) {
            int numberCountFirst = 1;
            int numberTimeType = numberHandles * 2;
            int realNumberr = numberHandles;
            int max = 1;
            while (numberCountFirst <= numberTimeType) {
                int count2 = 1;
                string handleNumbers = "";
                int count3 = numberHandles;
                int max2 = 0;
                while (count2 <= numberTimeType) {

                    if (realNumberr == numberHandles)
                    {
                        handleNumbers += realNumberr.ToString();
                    }
                    else {

                        if (count3 == numberHandles)
                        {
                            handleNumbers += count3.ToString();
                            count3--;
                        }
                        else {
                            if (count3 != realNumberr)
                            {
                                handleNumbers += count3.ToString();
                                count3--;
                            }
                            else {

                                int rescan = numberTimeType - max+1;
                             
                                if (rescan >= count2)
                                {
                                    handleNumbers += count3.ToString();
                                }
                                else
                                {
                                    max2++;
                                    handleNumbers += count3 + max2;
                                }
                            }
                        }
                    }

                    if (count2 == numberTimeType) {
                        if (numberCountFirst < (numberTimeType / 2))
                        {
                            realNumberr -= 1;
                            max++;
                        }
                        else if(numberCountFirst > (numberTimeType / 2)){
                            realNumberr += 1;
                            max--;
                        }

                        Console.WriteLine(handleNumbers);
                        handleNumbers = "";
                    }

                    count2++;
                }
                numberCountFirst++;
            }
            loadTypeNumber();
        }
    }
}
