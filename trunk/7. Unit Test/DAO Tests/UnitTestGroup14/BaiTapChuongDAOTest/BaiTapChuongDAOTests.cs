using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using NUnit.Framework;
using Dto;


namespace UnitTestGroup14
{
    [TestFixture]
    public class BaiTapChuongDAOTests
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
        public void insertBaiTapChuongTest()
        {
            //TODO Write this test
           // Assert.That(BaiTapChuongDAOTestRewrite.insertBaiTapChuong(new BaiTapChuongDTO()), Is.True);
        }

        [Test]
        public void deleteBaiTapChuongTest()
        {
            //TODO Write this test
            BaiTapChuongDTO obj = new BaiTapChuongDTO();
            obj.IDBaiTap = 1;
            Assert.That(BaiTapChuongDAOTestRewrite.deleteBaiTapChuong(obj.IDBaiTap), Is.True);
        }
        
        [Test]
        public void updateBaiTapChuongTest()
        {
            //TODO Write this test

        }

        [Test]
        public void selectAllBaiTapChuongTest()
        {
            //TODO Write this test

        }

        [Test]
        public void selectBaiTapChuongByIDChuongTest()
        {
            //TODO Write this test

        }

        [Test]
        public void selectBaiTapChuongByIDTest()
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
