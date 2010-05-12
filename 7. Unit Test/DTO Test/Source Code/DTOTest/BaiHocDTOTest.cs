using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Dto;

namespace UnitTestGroup14
{
    [TestFixture]
    public class BaiHocDTOTest
    {
        /// <summary>
        /// Creates a new <see cref="BaiHocDTO"/> instance.
        /// </summary>	
        public BaiHocDTOTest()
        {
            //Add your init for this class
        }

        //Object for test
        private BaiHocDTO obj;

        /// <summary>
        /// This method is used to construct the test environment prior to running the tests.
        /// </summary>        
        [TestFixtureSetUp]
        public void Init()
        {
            obj = new BaiHocDTO();

            //Add your initialization for test enviroment here
        }

        [TestFixtureTearDown]
        public void Dispose()
        {
            //Add your clean up here
        }

        [Test]
        public void set_IDBaiHocTest()
        {
            //TODO Write this test
            obj.IDBaiHoc = 1;
            Assert.That(Is.Equals(obj.IDBaiHoc, 1));
        }

        [Test]
        public void get_IDBaiHocTest()
        {
            //TODO Write this test
            obj.IDBaiHoc = 1;
            Assert.That(Is.Equals(obj.IDBaiHoc, 1));
        }

        [Test]
        public void set_TenBaiHocTest()
        {
            //TODO Write this test
            obj.TenBaiHoc = "abc";
            Assert.That(Is.Equals(obj.TenBaiHoc, "abc"));
        }

        [Test]
        public void get_TenBaiHocTest()
        {
            //TODO Write this test
            obj.TenBaiHoc = "abc";
            Assert.That(Is.Equals(obj.TenBaiHoc, "abc"));
        }

        [Test]
        public void set_NoiDungTest()
        {
            //TODO Write this test
            obj.NoiDung = String.Empty;
            obj.NoiDung = "dksld";
            Assert.That(Is.Equals(obj.NoiDung, "dksld"));
        }

        [Test]
        public void get_NoiDungTest()
        {
            //TODO Write this test
            obj.NoiDung = String.Empty;
            Assert.That(Is.Equals(obj.NoiDung,String.Empty));
        }

        [Test]
        public void set_IDChuongTest()
        {
            //TODO Write this test
            obj.IDChuong = 2;
            Assert.That(Is.Equals(obj.IDChuong, 2));
        }

        [Test]
        public void get_IDChuongTest()
        {
            //TODO Write this test
            obj.IDChuong = 2;
            Assert.That(Is.Equals(obj.IDChuong, 2));
        }				
    }	
}
