using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Data.SqlClient;

namespace UnitTestGroup14
{
    [TestFixture]
    public class AccountDAOTests
    {
        SqlConnection cn;

        [SetUp]
        public void iNit()
        {
            cn = new SqlConnection();
            cn.Open();
        }
        [TearDown]
        public void cleanup()
        {
            cn.Close();
        }

        [Test]
        public void insertAccountTest()
        {
            //TODO Write this test

        }

        [Test]
        public void deleteAccountTest()
        {
            //TODO Write this test

        }

        [Test]
        public void updateAccountTest()
        {
            //TODO Write this test

        }

        [Test]
        public void selectAllAccountTest()
        {
            //TODO Write this test

        }

        [Test]
        public void selectAccountByLACTest()
        {
            //TODO Write this test

        }

        [Test]
        public void selectAccountByIDACTest()
        {
            //TODO Write this test

        }

        [Test]
        public void selectAccountByEmailTest()
        {
            //TODO Write this test

        }

        [Test]
        public void ToStringTest()
        {
            //TODO Write this test

        }

        [Test]
        public void EqualsTest()
        {
            //TODO Write this test

        }

        [Test]
        public void GetHashCodeTest()
        {
            //TODO Write this test

        }

        [Test]
        public void GetTypeTest()
        {
            //TODO Write this test

        }
    }
}
