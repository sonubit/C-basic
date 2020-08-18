using System;

namespace W1Web
{
    class StaticVar
    {
        private static int num;

       public void count()
        {
            num++;
        }
        public int getNum()
        {
            return num;
        }
      public static void print()
        {
            Console.WriteLine("static method");
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("static Keywords");
            StaticVar s1 = new StaticVar();
            StaticVar s2 = new StaticVar();
            s1.count();				
            s1.count();
            s2.count();
            s2.count();
            Console.WriteLine("first variable num   "+s1.getNum());
            Console.WriteLine("second variable num  "+s2.getNum());
            StaticVar.print();
            Console.WriteLine("Encapsulation");
            Bank SBI = new Bank();
            SBI.setBalance(500);
            Console.WriteLine(SBI.getBalance());
            Console.WriteLine("abtraction");
            Car C = new Car();
            Console.WriteLine(C.CarName);
            Console.WriteLine(C.CarColur);
            C.Brakes();
            C.Gear();
            C.Steering();
            Console.WriteLine("inheritance");
            Student s = new Student();
            s.setName("sonu");
            s.setPhone(1234567890);
            s.setEmail("sonu@gmail.com");
            s.setCourse("c#");
            s.setMarks(22);
            Console.WriteLine(s.getName() + " " + s.getPhone()+" " + s.getEmail()+" "+s.getCourse()+" " + s.getMarks());
            Staf ns = new Staf();
            ns.setName("golu");
            ns.setPhone(1234567890);
            ns.setEmail("golu@gmail.com");
            ns.setPost("c# trainer");
            ns.setSalary(200000);
            Console.WriteLine(ns.getName() + " " + ns.getEmail() + " " + ns.getPhone() + " " + ns.getPost() + " " + ns.getSalary());
        }
    }
}
