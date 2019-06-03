// Made by Jurek Baumann, 2019
using System;
using System.Collections.Generic;

namespace Login
{
    /// <summary>
    /// This object holds all information of a single restaurant order.
    /// Datetime objects are exposed as ui ready strings.
    /// Parameters are:
    /// Datetime startTime
    /// Datetime endTime
    /// int TableNumber
    /// string[] menus
    /// Dictionary staff
    /// int satisfaction
    /// string feedback
    /// string CustomerName
    /// </summary>
    class Order
    {
        public Order(DateTime startTime, DateTime endTime, int tableNumber, string[] menus, Dictionary<string, string> staff, int satisfaction, string feedback = "", string customerName = "Anonymous")
        {
            this.startTime = startTime;
            this.endTime = endTime;
            TableNumber = tableNumber;

            Feedback = feedback;
            Menus = menus;
            Staff = staff;
            Satisfaction = satisfaction;
            Customer = customerName;
            
        }

        private DateTime startTime;
        private DateTime endTime;

        public readonly int TableNumber;
        public readonly int Satisfaction;

        public string[] Menus;
        public Dictionary<string, string> Staff;

        public string Feedback;

        public string Customer;

        public string Start
        {
            get
            {
                return startTime.ToString("HH:mm");
            }
        }


        public string End
        {
            get
            {
                return endTime.ToString("HH:mm");
            }
        }


        public string Date
        {
            get
            {
                return startTime.ToString("MMMM dd, yyyy");
            }
        }

        public string Table
        {
            get
            {
                return string.Format("Table {0}", TableNumber);
            }
        }


        /// <summary>
        /// Return a string of information regarding the order
        /// This is used for debugging purposes only.
        /// </summary>
        /// <returns></returns>
        override public string ToString()
        {
            string orderInfo = string.Format("Order start: {0}, end: {1}, date: {2}, table: {3}, feedback: {4}, satisfaction: {5}", Start, End, Date, Table, Feedback, Satisfaction);
            orderInfo += "\nMenus:\n";
            foreach (string menu in Menus)
            {
                orderInfo += menu + "\n";
            }
            return orderInfo;
        }
       
    }
}
