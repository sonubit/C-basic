using System;
namespace W1Web
{
    //inheritance
    class Person
    {
        private string name;
        private string email;
        private int phone;
        public void setName(String name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }
        public void setPhone(int phone)
        {
            this.phone = phone;
        }
        public int getPhone()
        {
            return phone;
        }
        public void setEmail(String email)
        {
            this.email = email;
        }
        public string getEmail()
        {
            return email;
        }
    }
    class Student : Person
    {
        private string course;
        private int marks;
        public void setCourse(String course)
        {
            this.course = course;
        }
        public string getCourse()
        {
            return course;
        }
        public void setMarks(int marks)
        {
            this.marks = marks;
        }
        public int getMarks()
        {
            return marks;
        }
    }
    class Staf : Person
    {
        private int salary;
        private string post;
        public void setPost(String post)
        {
            this.post = post;
        }
        public string getPost()
        {
            return post;
        }
        public void setSalary(int salary)
        {
            this.salary = salary;
        }
        public int getSalary()
        {
            return salary;
        }
    }

}
