using System;
using ConsoleApplication.factory;

namespace ConsoleApplication
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            AbstractFactory caramelFactory = new CaramelFactory();
            Client client = new Client(caramelFactory);
            client.Eat();
        }
    }
}