using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Data.SqlClient;

namespace UnitTestGroup14
{
    [TestFixture]
    public class BaiTapCuaBaiHocDAOTests
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
        public void insertBaiTapCuaBaiHocTest()
        {
            //TODO Write this test

        }

        [Test]
        public void deleteBaiTapCuaBaiHocTest()
        {
            //TODO Write this test

        }

        [Test]
        public void updateBaiTapCuaBaiHocTest()
        {
            //TODO Write this test

        }

        [Test]
        public void selectAllBaiTapCuaBaiHocTest()
        {
            //TODO Write this test

        }

        [Test]
        public void selectBaiTapCuaBaiHocByIDTest()
        {
            //TODO Write this test

        }

        [Test]
        public void selectBaiTapCuaBaiHocByIDBaiHocTest()
        {
            //TODO Write this test

        }

        [Test]
        public void selectBaiTapCuaBaiHocByIDBaiHoc2Test()
        {
            //TODO Write this test

        }

        [Test]
        public void selectAllBaiTapCuaBaiHocByIDBaiHocTest()
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
