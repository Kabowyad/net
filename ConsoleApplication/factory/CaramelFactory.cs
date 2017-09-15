﻿namespace ConsoleApplication.factory{

    class CaramelFactory: AbstractFactory{
        
        public override ICandy GetCaramelCandy(){
            ICandy iCandy = new CaramelCandy();
            return iCandy;
        }

        public override ICandy GetSaltCandy(){
            return null;
        }

        public override ICandy GetChocolateCandy(){
            return null;
        }
    }
}