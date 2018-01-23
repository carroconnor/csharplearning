using System;

namespace _0._20_GettersSetters
{
    class Employee
    {
        private int _id;
        private string _name;

        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                if (value < 0)
                    throw new Exception("The employee ID is invalid");
                _id = value;
            }
        }



        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Invalid Employee Name");
                _name = value.Trim();
            }
        }
    }
}
