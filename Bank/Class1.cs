using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    //
    class person
    {
        private int _acc;
        private string _name;
        private int _amount;
        private string _email;
        public int acc
        {
            set
            {
                _acc = value;
            }
            get
            { 
                return _acc; 
            }
        }
        public String email
        {
            set
            {
                _email = value;
            }
            get
            {
                return _email;
            }
        }
        public string name
        {
            set
            {
                _name = value;
            }
            get
            {
                return _name;
            }
        }
        public int amount
        {
            set
            {
                _amount = value;
            }
            get
            {
                return _amount;
            }
        }

    }
}
