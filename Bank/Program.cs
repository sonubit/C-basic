using System;

namespace Bank
{
    public interface A
    {
        void method1();
        void method2();
    }
    interface B : A
    {
        void method3();
    }
    class MyClass : B
    {
        public void method1()
        {
            Console.WriteLine("implement method1");
        }
        public void method2()
        {
            Console.WriteLine("implement method2");
        }
        public void method3()
        {
            Console.WriteLine("implement method3");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "week 1 | 4 day";
            StaticClass s = new StaticClass(5);
            //The interface is a fully un-implemented class used for declaring a set of operations of an object.
            //an interface as a pure abstract class which allows us to define only abstract methods.
            //Abstract method means a method without body or implementation.
            MyClass m = new MyClass();
            m.method1();
            m.method2();
            m.method3();
            //accessor is nothing but special type of method which are used to set and get the value
            person p = new person();
            p.name = "sonu";
            p.email="sonu@gamil.com";
            p.acc = 159962;
            p.amount = 2000;

            //overriding methods
            OverringChild o = new OverringChild();
            o.show();//o/p 
            //overloading methods
            MethodOverloading m1 = new MethodOverloading();
            m1.add(1, 2);
            m1.add(1.3f, 25.5f);
            m1.add(12, 15.0f);
        }
    }
}
