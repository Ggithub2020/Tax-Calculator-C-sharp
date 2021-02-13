using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculationHahuCampus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter your Full Name");
            string fullname = Console.ReadLine();
            Console.WriteLine("please Enter your Filing status: Enter 'M' for  married and 'S' for Single");
            string filingstatus = Console.ReadLine();
            Console.WriteLine("please Enter your gross income");
            double grossincome = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("please enter the number of childern you have");
            int numberofchildern = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter your donation amount if any");
            double donations = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("please enter the amount of tax you paid for the year from W2/1099 Form:");
            double taxpaid = Convert.ToDouble(Console.ReadLine());
            double childcreditstatus = numberofchildern * 2000;
            double statuscredit = 0.0;
            if (filingstatus == "M")
            {
                statuscredit = 240000.00;
            }
            else
            {
                statuscredit = 12000.00;
            }
             
            double taxableincome = grossincome - (childcreditstatus + statuscredit + donations);

            double calculatedTax = taxableincome * gettaxrate(taxableincome);

            double taxReturn = taxpaid - calculatedTax;
            Console.WriteLine("Thank you for using this service" + "your tax return for this year is {0}", taxReturn.ToString());
            Console.ReadKey();

        }
        
        public static double gettaxrate(double taxableincome )
        {

            double taxRate = 0.0;
            if (taxableincome <= 20000 )
            {
                taxRate = 0.0; 
            }
            else if(taxableincome>20000&& taxableincome<=500000.00)

            {
                taxRate = 0.1;
                }
            else if(taxableincome>50000.00&& taxableincome <= 100000.00)
            {
                taxRate = 0.2;
                
            }
            else if (taxableincome > 100000.00 && taxableincome <= 400000.00)
            {
             taxRate = 0.25;

           }
            return taxRate;

        }

  
            
             
        }
    }


        
