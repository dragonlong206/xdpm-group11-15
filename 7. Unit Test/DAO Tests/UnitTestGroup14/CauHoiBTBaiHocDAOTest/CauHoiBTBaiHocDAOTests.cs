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
            Assert.That(CauHoiBTBaiHocDAOTestRewrite.insertCauHoiBTBaiHoc(new CauHoiBTBaiHocDTO()), Is.True);

        }

        [Test]
        public void deleteCauHoiBTBaiHocTest()
        {
            //TODO Write this test
            Assert.That(CauHoiBTBaiHocDAOTestRewrite.deleteCauHoiBTBaiHoc("IDCauHoiBTBaiHoc"), Is.True);

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
            Assert.That(CauHoiBTBaiHocDAOTestRewrite.updateCauHoiBTBaiHoc(new CauHoiBTBaiHocDTO()), Is.True);

        }

        [Test]
        public void selectAllCauHoiBTBaiHocTest()
        {
            //TODO Write this test
            Assert.That(CauHoiBTBaiHocDAOTestRewrite.selectAllCauHoiBTBaiHoc(), Is.True);

        }

        [Test]
        public void selectCauHoiBTBaiHocByIDCauHoiTest()
        {
            //TODO Write this test
            CauHoiBTBaiHocDTO obj = new CauHoiBTBaiHocDTO();
            obj.IDCauHoi = 1;
            Assert.That(CauHoiBTBaiHocDAOTestRewrite.selectCauHoiBTBaiHocByIDCauHoi(obj.IDCauHoi), Is.True);

        }

        [Test]
        public void selectCauHoiBTBaiHocByIDBaiTapTest()
        {
            //TODO Write this test
            CauHoiBTBaiHocDTO obj = new CauHoiBTBaiHocDTO();
            obj.IDCauHoi = 1;
            Assert.That(CauHoiBTBaiHocDAOTestRewrite.selectCauHoiBTBaiHocByIDBaiHoc(obj.IDCauHoi), Is.True);

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
