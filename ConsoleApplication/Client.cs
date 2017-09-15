using ConsoleApplication.factory;

namespace ConsoleApplication{
    public class Client{
        ICandy candy;

        public Client(AbstractFactory abstractFactory){
            candy = abstractFactory.GetCaramelCandy();
        }
       
        public void Eat() {
            System.Console.Write(candy.GetCandyType());
        }
    }
}