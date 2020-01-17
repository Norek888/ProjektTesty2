using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektTesty2
{
    public class Program
    {
        public string Login(string UserId, string Password)
        {
            if (string.IsNullOrEmpty(UserId) || string.IsNullOrEmpty(Password))
            {
                return "Pls fill both fields";
            }
            else
            {
                return UserId switch
                {
                    "Admin" when Password == "Admin" => "Welcome Admin.",
                    _ => "Incorrect UserId or Password."
                };
            }
        }
        public List<Details> AllUsers()
        {
            List<Details> li = new List<Details>();
            li.Add(new Details
            {
                id = 1,
                Name = "Adam",
                Geneder = "male",
                salary = 40000,
                Age = 23
            });
            li.Add(new Details
            {
                id = 2,
                Name = "Anita",
                Geneder = "Female",
                salary = 50000,
                Age = 26
            });
            li.Add(new Details
            {
                id = 3,
                Name = "Kieran",
                Geneder = "male",
                salary = 40000,
                Age = 32
            });
            li.Add(new Details
            {
                id = 4,
                Name = "Dominik",
                Geneder = "male",
                salary = 23000,
                Age = 74
            });
            li.Add(new Details
            {
                id = 5,
                Name = "Ania",
                Geneder = "Female",
                salary = 80000,
                Age = 54
            });
            li.Add(new Details
            {
                id = 6,
                Name = "Sam",
                Geneder = "male",
                salary = 670000,
                Age = 42
            });
            return li;
        }
        public List<Details> getDetails(int id)
        {
            List<Details> li1 = new List<Details>();
            Program p = new Program();
            var li = p.AllUsers();
            foreach (var x in li)
            {
                if (x.id == id)
                {
                    li1.Add(x);
                }
            }
            return li1;
        }
        static void Main(string[] args) { }
    }
}
