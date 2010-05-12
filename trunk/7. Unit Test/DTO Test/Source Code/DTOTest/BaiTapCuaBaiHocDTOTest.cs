using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Dto;

namespace UnitTestGroup14
{
    [TestFixture]
    public class BaiTapCuaBaiHocDTOTest
    {
        /// <summary>
        /// Creates a new <see cref="BaiTapCuaBaiHocDTO"/> instance.
        /// </summary>	
        public BaiTapCuaBaiHocDTOTest()
        {
            //Add your init for this class
        }

        //Object for test
        private BaiTapCuaBaiHocDTO obj;

        /// <summary>
        /// This method is used to construct the test environment prior to running the tests.
        /// </summary>        
        [TestFixtureSetUp]
        public void Init()
        {
            obj = new BaiTapCuaBaiHocDTO();

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
    }			
}
