using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using NUnit.Framework;

namespace BaiHocDAOTest
{
    [TestFixture]
    public class BaiHocDAOTests
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
        public void insertBaiHocTest()
        {
            //TODO Write this test

        }

        [Test]
        public void insertBaiHocAutoIncreaseTest()
        {
            //TODO Write this test

        }

        [Test]
        public void deleteBaiHocTest()
        {
            //TODO Write this test

        }

        [Test]
        public void updateBaiHocTest()
        {
            //TODO Write this test

        }

        [Test]
        public void selectAllBaiHocTest()
        {
            //TODO Write this test

        }

        [Test]
        public void selectBaiHocByIDBaiHocTest()
        {
            //TODO Write this test

        }

        [Test]
        public void selectBaiHocByIDChuongTest()
        {
            //TODO Write this test

        }

        [Test]
        public void selectIDvaTenBaiHocByIDChuongTest()
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
