using System;


    class InvalidAgeException : Exception
    {
        public override string Message
        {
            get
            {
                return "Sorry, Age must be greater than 18";
            }
        }
    }
    public class AgeCheck
    {
        public void validate(int age)
        {
             if (age < 18)
            {
                throw new InvalidAgeException();
            }
        }
    }


