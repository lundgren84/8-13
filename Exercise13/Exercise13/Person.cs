using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13
{
   public class Person
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public DateTime DateOfBirth { get; set; }

       public Person(string FName,string LName,DateTime DateOfBirth)
        {
            this.FName = FName;
            this.LName = LName;
            this.DateOfBirth = DateOfBirth;
        }
       public Person()
        { }
        public int GetAge(int a)
        {
            
            int b = DateTime.Now.Year;
           
            while (a < b)
            {
                a++;
            }
            //if (DateOfBirth.Month == DateTime.Now.Month)
            //{
            //    if (DateOfBirth.Day < DateTime.Now.Day) { a++; }
            //}
         
            return a;
        }
      
    }
}
