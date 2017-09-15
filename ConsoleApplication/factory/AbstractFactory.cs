using System;

namespace ConsoleApplication.factory{
    public abstract class AbstractFactory{
        public abstract ICandy GetCaramelCandy();
        public abstract ICandy GetSaltCandy();
        public abstract ICandy GetChocolateCandy();
    }
}