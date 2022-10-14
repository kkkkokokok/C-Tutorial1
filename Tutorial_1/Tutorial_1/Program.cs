using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try 
            {
                String operation;
                int num1 = 0, num2 = 0, result = 0;
                if (args.Length != 3)
                {
                    Console.WriteLine("Please enter correct format.\n Eg.Number1 Operator Number2.");
                    Console.ReadKey();
                    return;
                }

                num1 = Convert.ToInt32(args[0]);
                operation = args[1];
                num2 = Convert.ToInt32(args[2]);


                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        break;

                    case "-":
                        result = num1 - num2;
                        break;

                    case "*":
                        result = num1 * num2;
                        break;

                    case "/":
                        if (num2 == 0)
                        {
                            throw new Exception("Divicer should not 0.");
                        }
                        result = num1 / num2;

                        break;

                    case "%":
                        result = num1 % num2;
                        break;

                    default:
                        throw new Exception("Invaliad operator.");
                        

                }
                                
                Console.WriteLine("Result= " + result);
                
                Console.ReadKey();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }




        }
    }
}
