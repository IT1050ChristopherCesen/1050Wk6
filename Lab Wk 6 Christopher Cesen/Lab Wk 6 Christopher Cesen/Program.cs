using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Wk_6_Christopher_Cesen
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Question 1:  Both if single statments and while reptition statements diplay an output  that is dependant on whether or not certain conditons
             * are met.  Single staments perform and output only when a certain condition is met.  While statements work under condition that might 
             * have different values.  For example; a single statement would only work if the varible it 10.  A while statement could work if the 
             * variable is less then 10 or even greater.  
             * */


            //Question 2
            /*
           int speedLimit;
           int speed;

           speedLimit = 35;
           speed = 32;

           if (speed > speedLimit)

           {
               Console.WriteLine("SLOW DOWN!");
           }
           */

            /*int i;

            i = 30;
            while (i >= 10)
            {
                Console.WriteLine(i);
                i = i - 2;
            }
            */

            /*
            bool isTrue =true;
            //bool isTrue =false;

            isTrue = true;
            if (isTrue)
            {
                Console.WriteLine("It is True");
            }
            else
            {
                Console.WriteLine("It is False");

            }
            
    */
            /*
                      int i;
                      i = 30;
                      while (i >= 10)
                      {
                          Console.WriteLine(i);
                          i = i - 2;
                      }

                    /*
                                 int numValue;
                                 int exponentValue;
                                 int resultValue;
                                 int i;
                                 i = 34; 

                                  Console.WriteLine("Enter First Number Value:  ");
                                  numValue = int.Parse(Console.ReadLine());

                                  Console.WriteLine("Enter First Exponent Value:  ");
                                  exponentValue = int.Parse(Console.ReadLine());

                                  i = 1;
                                  resultValue = numValue;
                                  while (i < exponentValue)
                                  {
                                      resultValue = resultValue * numValue;
                                      i = i + 1;

                                  }
                                  Console.WriteLine("The result is {0}", resultValue);
                              }


                                /*
                                            double fahrenheit =
                                            Convert.ToDouble(Console.ReadLine());

                                            celcsius =
                                    } 

                                    fahrenheit -32) * 5d/9d;
                                    */

            /* int i = 1;
             int OutPut;
             while (i <= 10)
             {

                 Console.WriteLine("Output Value" ,OutPut);
                 i = i + 1;
             }
             */

            {
                int i = 0;
                while (i <= 10)
                {
                    Console.WriteLine("Output Value",i);

                    i = i + 1;

                }

                /*{
                    int r = 60;
                    while (r >=20)
                    {
                        Console.WriteLine("Output Value", r);
                        r = r - 1;
                            
                            }

                    {
                        int w = 10;
                        while (w >=20)
                        {
                            Console.WriteLine(Output Value, w);
                            w =w+1;
                        }

                    }
                    */
            }
        
    }
}
