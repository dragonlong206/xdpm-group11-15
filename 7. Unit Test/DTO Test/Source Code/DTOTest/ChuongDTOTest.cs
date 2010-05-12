using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Dto;

namespace UnitTestGroup14
{
    [TestFixture]
    public class ChuongDTOTest
    {
        /// <summary>
        /// Creates a new <see cref="ChuongDTO"/> instance.
        /// </summary>	
        public ChuongDTOTest()
        {
            //Add your init for this class
        }

        //Object for test
        private ChuongDTO obj;

        /// <summary>
        /// This method is used to construct the test environment prior to running the tests.
        /// </summary>        
        [TestFixtureSetUp]
        public void Init()
        {
            obj = new ChuongDTO();

            //Add your initialization for test enviroment here
        }

        [TestFixtureTearDown]
        public void Dispose()
        {
            //Add your clean up here
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

        [Test]
        public void set_TenChuongTest()
        {
            //TODO Write this test
            obj.TenChuong = "abc";
            Assert.That(Is.Equals(obj.TenChuong, "abc"));
        }

        [Test]
        public void get_TenChuongTest()
        {
            //TODO Write this test
            obj.TenChuong = "abc";
            Assert.That(Is.Equals(obj.TenChuong, "abc"));
        }			
    }			
}
