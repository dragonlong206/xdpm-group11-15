using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Dto;

namespace UnitTestGroup14
{
    [TestFixture]
    public class AccountDTOTest
    {
        /// <summary>
        /// Creates a new <see cref="AccountDTO"/> instance.
        /// </summary>	
        public AccountDTOTest()
        {
            //Add your init for this class
        }

        //Object for test
        private AccountDTO obj;

        /// <summary>
        /// This method is used to construct the test environment prior to running the tests.
        /// </summary>        
        [TestFixtureSetUp]
        public void Init()
        {
            obj = new AccountDTO();

            //Add your initialization for test enviroment here
        }

        [TestFixtureTearDown]
        public void Dispose()
        {
            //Add your clean up here
        }

        [Test]
        public void set_IDAccTest()
        {
            //TODO Write this test
            obj.IDAcc = "1";
            Assert.That(Is.Equals(obj.IDAcc, "1"));
        }

        [Test]
        public void get_IDAccTest()
        {
            //TODO Write this test
            obj.IDAcc = "1";
            Assert.That(Is.Equals(obj.IDAcc, "1"));
        }

        [Test]
        public void set_PassTest()
        {
            //TODO Write this test
            obj.Pass = "abc";
            Assert.That(Is.Equals(obj.Pass, "abc"));
        }

        [Test]
        public void get_PassTest()
        {
            //TODO Write this test
            obj.Pass = "abc";
            Assert.That(Is.Equals(obj.Pass, "abc"));
        }

        [Test]
        public void set_IDLoaiAccTest()
        {
            //TODO Write this test
            obj.IDLoaiAcc = 1;
            Assert.That(Is.Equals(obj.IDLoaiAcc, 1));
        }

        [Test]
        public void get_IDLoaiAccTest()
        {
            //TODO Write this test
            obj.IDLoaiAcc = 1;
            Assert.That(Is.Equals(obj.IDLoaiAcc, 1));
        }

        [Test]
        public void set_TrangThaiTest()
        {
            //TODO Write this test
            obj.TrangThai = true;
            Assert.That(Is.Equals(obj.TrangThai, true));
        }

        [Test]
        public void get_TrangThaiTest()
        {
            //TODO Write this test
            obj.TrangThai = true;
            Assert.That(Is.Equals(obj.TrangThai,true));
        }				
    }			
}
