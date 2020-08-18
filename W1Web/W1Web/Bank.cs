using System;

namespace W1Web
{
    //Encapsulation 
    public class Bank
    {
        //hiding class data by declaring the variable as private
        private double balance;

        //creating public  getter methods
        public double getBalance()
        {
            
            return balance;
        }
        //creating public setter methods
        public void setBalance(double balance)
        {
            this.balance = balance;
        }
    }
    
}
