using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using NUnit.Mocks;
using NUnit.Framework;

namespace ChuongDAOTest
{
    [TestFixture]
    public class ChuongDAOTests
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
        public void insertChuongTest()
        {
            //TODO Write this test

        }

        [Test]
        public void deleteChuongTest()
        {
            //TODO Write this test

        }

        [Test]
        public void updateChuongTest()
        {
            //TODO Write this test

        }

        [Test]
        public void selectAllChuongTest()
        {
            //TODO Write this test

        }

        [Test]
        public void selectChuongByIDChuongTest()
        {
            //TODO Write this test

        }

        [Test]
        public void selectChuongByIDMonHocTest()
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
