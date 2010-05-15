using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using NUnit.Mocks;
using NUnit.Framework;

namespace UnitTestGroup14
{
    [TestFixture]
    public class CauHoiBTChuongDAOTests
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
        public void insertCauHoiBTChuongTest()
        {
            //TODO Write this test

        }

        [Test]
        public void deleteCauHoiBTChuongTest()
        {
            //TODO Write this test

        }

        [Test]
        public void deleteCauHoiBTChuongByIDBaiTapTest()
        {
            //TODO Write this test

        }

        [Test]
        public void updateCauHoiBTChuongTest()
        {
            //TODO Write this test

        }

        [Test]
        public void selectAllCauHoiBTChuongTest()
        {
            //TODO Write this test

        }

        [Test]
        public void selectCauHoiBTChuongByIDCauHoiTest()
        {
            //TODO Write this test

        }

        [Test]
        public void selectCauHoiBTChuongByIDChuongTest()
        {
            //TODO Write this test

        }

        [Test]
        public void selectCauHoiBTChuongByIDBaiTapTest()
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
