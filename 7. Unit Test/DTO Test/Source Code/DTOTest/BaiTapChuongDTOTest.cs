using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Dto;

namespace UnitTestGroup14
{
    [TestFixture]
    public class BaiTapChuongDTOTest
    {
        /// <summary>
        /// Creates a new <see cref="BaiTapChuongDTO"/> instance.
        /// </summary>	
        public BaiTapChuongDTOTest()
        {
            //Add your init for this class
        }

        //Object for test
        private BaiTapChuongDTO obj;

        /// <summary>
        /// This method is used to construct the test environment prior to running the tests.
        /// </summary>        
        [TestFixtureSetUp]
        public void Init()
        {
            obj = new BaiTapChuongDTO();

            //Add your initialization for test enviroment here
        }

        [TestFixtureTearDown]
        public void Dispose()
        {
            //Add your clean up here
        }

        [Test]
        public void set_IDBaiTapTest()
        {
            //TODO Write this test
            obj.IDBaiTap = 1;
            Assert.That(Is.Equals(obj.IDBaiTap, 1));
        }

        [Test]
        public void get_IDBaiTapTest()
        {
            //TODO Write this test
            obj.IDBaiTap = 1;
            Assert.That(Is.Equals(obj.IDBaiTap, 1));
        }

        [Test]
        public void set_TenBaiTapTest()
        {
            //TODO Write this test
            obj.TenBaiTap = "abc";
            Assert.That(Is.Equals(obj.TenBaiTap, "abc"));
        }

        [Test]
        public void get_TenBaiTapTest()
        {
            //TODO Write this test
            obj.TenBaiTap = "abc";
            Assert.That(Is.Equals(obj.TenBaiTap, "abc"));
        }

        
        [Test]
        public void set_IDChuongTest()
        {
            //TODO Write this test
            obj.IDChuong = 1;
            Assert.That(Is.Equals(obj.IDChuong, 1));
        }

        [Test]
        public void get_IDChuongTest()
        {
            //TODO Write this test
            obj.IDChuong = 1;
            Assert.That(Is.Equals(obj.IDChuong, 1));
        }			
    }
}
