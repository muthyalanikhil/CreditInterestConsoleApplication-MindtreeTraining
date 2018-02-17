using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreditInterest
{
    class Calculation
    {
        public void logic()
        {
            try
            {
                float p, SI, instalment, sum = 0, temp = 0;
                int rate, i = 1, time = 0;

                Console.WriteLine("amount to pay: ");
                p = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("rate: ");
                rate = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("amount you pay for a month,installment: ");
                instalment = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("enter the date in yyyy/mm/dd format: ");
                DateTime a = Convert.ToDateTime(Console.ReadLine());
                temp = p;
                while (p >= 0)
                {

                    SI = (p * rate*1)/100;
                    p = p - instalment + SI;
                    sum = sum + SI;

                    Console.WriteLine("Balance Amount:{0} ,Interest for {1} month: {2} ", p, i, SI);
                    i++;
                    time++;
                }
                temp = temp + sum;
                Console.WriteLine("\nThe total months to be paid is: {0}\n", time);
                Console.WriteLine("\nThe total amount to be paid including interest is: {0}\n", temp);


                DateTime result = a.AddMonths(time);
                Console.WriteLine("The dates at which the amount is to be paid:{0}", result);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }

        }
    }
}
