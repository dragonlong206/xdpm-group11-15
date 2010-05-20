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
            Assert.That(ChuongDAOTestRewrite.insertChuong(new ChuongDTO()), Is.True);

        }

        [Test]
        public void deleteChuongTest()
        {
            //TODO Write this test
            Assert.That(ChuongDAOTestRewrite.deleteChuong("IDChuong"), Is.True);

        }

        [Test]
        public void updateChuongTest()
        {
            //TODO Write this test
            Assert.That(ChuongDAOTestRewrite.updateChuong(new ChuongDTO()), Is.True);

        }

        [Test]
        public void selectAllChuongTest()
        {
            //TODO Write this test
            Assert.That(ChuongDAOTestRewrite.selectAllChuong(), Is.True);

        }

        [Test]
        public void selectChuongByIDChuongTest()
        {
            //TODO Write this test
            ChuongDTO obj = new ChuongDTO();
            obj.IDChuong = 1;
            Assert.That(ChuongDAOTestRewrite.selectChuongByIDChuong(obj.IDChuong), Is.True);

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
