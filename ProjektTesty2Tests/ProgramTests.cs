using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjektTesty2;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektTesty2.Tests
{
    [TestClass]
    public class ProgramTests
    {
        List<Details> li;

        [TestMethod]
        public void LoginTest()
        {
            Program pobj = new Program();
            li = pobj.AllUsers();
            foreach (var x in li)
            {
                Assert.IsNotNull(x.id);
                Assert.IsNotNull(x.Name);
                Assert.IsNotNull(x.salary);
                Assert.IsNotNull(x.Geneder);
                Assert.IsNotNull(x.Age);
            }
        }

       [TestMethod]
        public void UsersTestInCorrectLogin()
        {
            Program pobj = new Program();
            string x = pobj.Login("Anita", "1234");
            Assert.AreEqual("Incorrect UserId or Password.", x);
        }
        [TestMethod]
        public void UsersTestNullFields()
        {
            Program pobj = new Program();
            string y = pobj.Login("", "");
            Assert.AreEqual("Pls fill both fields", y);
        }
        [TestMethod]
        public void UsersTestAdminLogin()
        {
            Program pobj = new Program();
            string z = pobj.Login("Admin", "Admin");
            Assert.AreEqual("Welcome Admin.", z);
        }
        
        [TestMethod]
        public void getNameAndId()
        {
            Program pobj = new Program();
            var p = pobj.getDetails(1);
            foreach (var x in p)
            {
                Assert.AreEqual(x.id, 1);
                Assert.AreEqual(x.Name, "Adam");
            }
        }
        [TestMethod]
        public void getSalary()
        {
            Program pobj = new Program();
            var p = pobj.getDetails(5);
            foreach (var x in p)
            {
                Assert.AreEqual(x.salary, 80000);
            }
        }
        [TestMethod]
        public void getGenderMale()
        {
            Program pobj = new Program();
            var p = pobj.getDetails(4);
            foreach (var x in p)
            {
                Assert.AreEqual(x.Geneder, "male");
            }
        }
        [TestMethod]
        public void getGenderFemale()
        {
            Program pobj = new Program();
            var p = pobj.getDetails(5);
            foreach (var x in p)
            {
                Assert.AreEqual(x.Geneder, "Female");
            }
        }


    }
}