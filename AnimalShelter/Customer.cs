using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AnimalShelter
{
    public class Customer
    {
        public string FirstName;
        public string LastName;
        public string Address;
        private bool _IsQualified;
        private DateTime _Birthday;
       // private int _Age;
        public string Description;

        public Customer(string firstName, string lastName, DateTime birthday)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this._Birthday = birthday;
           // this._Age = age;
            this._IsQualified = DateTime.Now.Year - birthday.Year >= 18;
        }

        public DateTime Birthday
        {
            get { return _Birthday; }
            set
            {
                _Birthday = value;
                _IsQualified = DateTime.Now.Year - _Birthday.Year >= 18;
            }
        }


        /*public int GetAge()
        {
            return _Age;
        }
        public void SetAge(int age)
        {
            _Age = age;
            _IsQualified = age >= 18;
        }*/

        public int Age
        {
            get { return DateTime.Now.Year - _Birthday.Year; }    
        }

       /* public bool GetIsQualified()
        {
            return _IsQualified;
        }*/

        public bool IsQualified
        {
            get
            {
                return this._IsQualified;
            }
        }

       /* public string GetFullName()
        {
            return FirstName + " " + LastName;
        }*/

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }


    }
}
