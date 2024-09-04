using System;
using System.Collections.Generic;
using System.Globalization;
using PrimeiroProjeto.Entities;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.00);

            //UPCASTING 

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Joao", 0.0, 200.0); 
            Account acc3 = new SavingsAccount(1004, "Ana", 0.0, 0.01);

            //DOWNCASTING - SOMENTE QUANDO NECESSÁRIO

            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.00);
            // acc2.Loan(100.00); //PRIMEIRO O DOWNCASTING E DEPOIS CONSIGO CHAMAR A FUNÇÃO


            // BusinessAccount acc5 = (BusinessAccount)acc3; //AQUI TEMOS UM ERRO DE EXCEPTION

            if (acc3 is BusinessAccount)
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200);
                Console.WriteLine("Loan!");
            }
            if (acc3 is SavingsAccount)
            {
                //SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("UPDATE!");

            }
        }

    }
}

