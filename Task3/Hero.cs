using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Task3
{
    internal class Hero
    {
        private int _id;
        private string _name;
        private decimal _price;
        public virtual int Id 
        {
            get 
            {
                return _id;
            } 
            set 
            {
                _id = value;
            } 
        }
        public virtual string Name
        {
            get
            {
                return _name;
            } 
            set { _name = value; }
        }
        public virtual decimal Price
        {
            get
            {
                return _price;
            }
        }
        public Hero(int id,decimal price)
        {
            _id = id;
            _price = price;
        }
    }
}
