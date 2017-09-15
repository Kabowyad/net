using System;

namespace ConsoleApplication.factory{
    public class AbstractFactoryProduction{
        public static AbstractFactory GetFactory(String name){
            AbstractFactory abstractFactory = null;
            
            if (name.ToLower().Equals("caramelfactory")){
                abstractFactory=new CaramelFactory();
            }
            else if (name.ToLower().Equals("saltfactory")){
                abstractFactory = new SaltFactory();
            }
            else if (name.ToLower().Equals("chocolatefactory")){
                abstractFactory = new ChocolateFactory();
            }
            return abstractFactory;
        }
    }
}