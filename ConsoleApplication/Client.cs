using ConsoleApplication.factory;

namespace ConsoleApplication{
    public class Client{
        private Candy _candy;

        public Client(AbstractFactory abstractFactory){
            _candy = abstractFactory.CreateCandy();
        }
       
        public void Eat() {
            System.Console.Write(_candy.GetType());
        }
    }
}