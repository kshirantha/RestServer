using Microsoft.Ajax.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestServer.Models
{
    // his should be writtent o a file but adding it here for the time being
    public static class Store
    {
         public static SortedList<String, Customer> SORTED_LIST = new SortedList<String, Customer>();

        public static void StoreCustomer(List<Customer> customers)
        {
            for(int i = 0; i < customers.Count; i++)
            {
                if (customers[i].isValid())
                {
                    SORTED_LIST.Add(customers[i].lastName + "~" + customers[i].firstName, customers[i]);
                }
            }
        }

    }

    public class Customer
    {
        public String firstName { get; set; }
        public String lastName { get; set; }
        public int age { get; set; }
        public int id { get; set; }

        public bool isValid()
        {
            if (this.firstName != "" && this.lastName != "" && this.age > 0 && this.id > 18)
            {
                foreach (Customer entry in Store.SORTED_LIST.Values)
                {
                    if (entry.id == this.id)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}