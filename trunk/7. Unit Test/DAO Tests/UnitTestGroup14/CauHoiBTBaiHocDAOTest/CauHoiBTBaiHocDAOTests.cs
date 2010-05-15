using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using NUnit.Framework;
using NUnit.Mocks;

namespace UnitTestGroup14
{
    [TestFixture]
    public class CauHoiBTBaiHocDAOTests
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
        public void insertCauHoiBTBaiHocTest()
        {
            //TODO Write this test

        }

        [Test]
        public void deleteCauHoiBTBaiHocTest()
        {
            //TODO Write this test

        }

        [Test]
        public void deleteCauHoiBTBaiHocByIDBaiTapTest()
        {
            //TODO Write this test

        }

        [Test]
        public void updateCauHoiBTBaiHocTest()
        {
            //TODO Write this test

        }

        [Test]
        public void selectAllCauHoiBTBaiHocTest()
        {
            //TODO Write this test

        }

        [Test]
        public void selectCauHoiBTBaiHocByIDCauHoiTest()
        {
            //TODO Write this test

        }

        [Test]
        public void selectCauHoiBTBaiHocByIDBaiTapTest()
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
