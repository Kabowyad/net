using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace ConsoleApplication.Tests{
    [TestFixture]
    public class Class1{
        [Test]
        public void Test(){
            ICandy[] candies = new SaltCandy[10]; // Ковариантность
            
            Account account = new Account();
            IBank<Account> ordinaryBank = new Bank<Account>();
            IBank<DepositAccount> depositBank = ordinaryBank; // контравариантность
        }
    }
    
    class Account
    {
        static Random rnd = new Random();
 
        public void DoTransfer()
        {
            int sum = rnd.Next(10, 120);
            Console.WriteLine("Клиент положил на счет {0} долларов", sum);
        }
    }
    class DepositAccount : Account
    {
    }
 
    interface IBank<in T>  where T : Account
    {
        void DoOperation(T account);
    }
 
    class Bank<T>: IBank<T> where T : Account
    {
        public void DoOperation(T account)
        {
            account.DoTransfer();
        }
    }

}