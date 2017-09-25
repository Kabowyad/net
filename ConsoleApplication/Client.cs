using System;
using ConsoleApplication.exception;
using ConsoleApplication.factory;

namespace ConsoleApplication{
    public class Client{
        ICandy candy;

        public Client(AbstractFactory abstractFactory){
            candy = abstractFactory.GetCaramelCandy();
        }
       
        public void Eat(String candyType) {
            if (candyType != "candy")
                throw new CandyException("not a candy");
            System.Console.Write(candy.GetCandyType());
        }
    }
}