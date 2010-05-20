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
            Assert.That(CauHoiBTChuongDAOTestRewrite.insertCauHoiBTChuong( new CauHoiBTChuongDTO()), Is.True);

        }

        [Test]
        public void deleteCauHoiBTChuongTest()
        {
            //TODO Write this test
            CauHoiBTChuongDTO obj = new CauHoiBTChuongDTO();
            obj.IDCauHoi = 1;
            Assert.That(CauHoiBTChuongDAOTestRewrite.deleteCauHoiBTChuong(obj.IDCauHoi), Is.True);

        }

        [Test]
        public void deleteCauHoiBTChuongByIDBaiTapTest()
        {
            //TODO Write this test
            //TODO Write this test
            CauHoiBTChuongDTO obj = new CauHoiBTChuongDTO();
            obj.IDBaiTap = 1;
            Assert.That(CauHoiBTChuongDAOTestRewrite.deleteCauHoiBTChuongByIDBaiTap(obj.IDBaiTap), Is.True);

        }

        [Test]
        public void updateCauHoiBTChuongTest()
        {
            //TODO Write this test
            Assert.That(CauHoiBTChuongDAOTestRewrite.updateCauHoiBTChuong(new CauHoiBTChuongDTO()), Is.True);
           
        }

        [Test]
        public void selectAllCauHoiBTChuongTest()
        {
            //TODO Write this test
            Assert.That(CauHoiBTChuongDAOTestRewrite.selectAllCauHoiBTChuong(), Is.True);

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
            CauHoiBTChuongDTO obj = new CauHoiBTChuongDTO();
            obj.IDCauHoi = 1;
            Assert.That(CauHoiBTChuongDAOTestRewrite.selectCauHoiBTChuongByIDChuong(obj.IDCauHoi), Is.True);

        }

        [Test]
        public void selectCauHoiBTChuongByIDBaiTapTest()
        {
            //TODO Write this test
            CauHoiBTChuongDTO obj = new CauHoiBTChuongDTO();
            obj.IDCauHoi = 1;
            Assert.That(CauHoiBTChuongDAOTestRewrite.selectCauHoiBTChuongByIDBaiTap(obj.IDCauHoi), Is.True);

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
