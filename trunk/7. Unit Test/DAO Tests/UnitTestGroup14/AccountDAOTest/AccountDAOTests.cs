using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Data.SqlClient;
using Dto;

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
                Assert.That(AccountDAOTestRewrite.insertAccount(new AccountDTO()), Is.True);

            }

            [Test]
            public void deleteAccountTest()
            {
                //TODO Write this test
                AccountDTO obj = new AccountDTO();
                obj.IDAcc = "obj";
                Assert.That(AccountDAOTestRewrite.deleteAccount(obj.IDAcc),Is.True);

            }

            [Test]
            public void updateAccountTest()
            {
                //TODO Write this test
                Assert.That(AccountDAOTestRewrite.updateAccount(new AccountDTO()), Is.True);

            }

            [Test]
            public void selectAllAccountTest()
            {
                //TODO Write this test
                Assert.That(AccountDAOTestRewrite.selectAllAccount(), Is.True);

            }

            [Test]
            public void selectAccountByLACTest()
            {
                //TODO Write this test
                AccountDTO obj = new AccountDTO();
                obj.IDLoaiAcc = 1 ;
                Assert.That(AccountDAOTestRewrite.selectAccountByLAC(obj.IDLoaiAcc), Is.True);

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
