using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dto;
using NUnit.Framework;
using NUnit.Mocks;
using System.Collections;
using System.Data.SqlClient;

namespace UnitTestGroup14
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
            Assert.That(BaiHocDAOTestRewrite.insertBaiHoc(new BaiHocDTO()), Is.True);
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
            BaiHocDTO obj = new BaiHocDTO();
            obj.IDBaiHoc = 1;
            Assert.That(BaiHocDAOTestRewrite.deleteBaiHoc(obj.IDBaiHoc));
        }

        [Test]
        public void updateBaiHocTest()
        {
            //TODO Write this test
            Assert.That(BaiHocDAOTestRewrite.updateBaiHoc(new BaiHocDTO()));
        }

        [Test]
        public void selectAllBaiHocTest()
        {
            //TODO Write this test
            Assert.That(BaiHocDAOTestRewrite.selectAllBaiHoc(),Is.True);
        }

        [Test]
        public void selectBaiHocByIDBaiHocTest()
        {
            //TODO Write this test
            BaiHocDTO obj = new BaiHocDTO();
            obj.IDBaiHoc = 1;
            Assert.That(BaiHocDAOTestRewrite.selectBaiHocByIDBaiHoc(obj.IDBaiHoc),Is.True);
     
        }

        [Test]
        public void selectBaiHocByIDChuongTest()
        {
            //TODO Write this test
            BaiHocDTO obj = new BaiHocDTO();
            obj.IDChuong = 1;
            Assert.That(BaiHocDAOTestRewrite.selectBaiHocByIDChuong(obj.IDChuong), Is.True);
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
