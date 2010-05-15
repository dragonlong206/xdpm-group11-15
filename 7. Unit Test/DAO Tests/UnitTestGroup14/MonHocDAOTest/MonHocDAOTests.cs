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
        public class MonHoc
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
            public void insertLoaiAccTest()
            {
                //TODO Write this test
               // Assert.That(LoaiAccDAOTestRewrite.insertLoaiAcc(new LoaiAccDTO()), Is.True);

            }

            [Test]
            public void deleteLoaiAccTest()
            {
                //TODO Write this test
                //LoaiAccDTO obj = new LoaiAccDTO();
               // obj.IDAcc = "obj";
                //Assert.That(LoaiAccDAOTestRewrite.deleteLoaiAcc(obj.IDAcc),Is.True);

            }

            [Test]
            public void updateLoaiAccTest()
            {
                //TODO Write this test
              //  Assert.That(LoaiAccDAOTestRewrite.updateLoaiAcc(new LoaiAccDTO()), Is.True);

            }

            [Test]
            public void selectAllLoaiAccTest()
            {
                //TODO Write this test
                //Assert.That(LoaiAccDAOTestRewrite.selectAllLoaiAcc(), Is.True);

            }

            [Test]
            public void selectLoaiAccByLACTest()
            {
                //TODO Write this test
               // LoaiAccDTO obj = new LoaiAccDTO();
               // obj.IDLoaiAcc = 1 ;
             //   Assert.That(LoaiAccDAOTestRewrite.selectLoaiAccByLAC(obj.IDLoaiAcc), Is.True);

            }

            [Test]
            public void selectLoaiAccByIDACTest()
            {
                //TODO Write this test

            }

            [Test]
            public void selectLoaiAccByEmailTest()
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
