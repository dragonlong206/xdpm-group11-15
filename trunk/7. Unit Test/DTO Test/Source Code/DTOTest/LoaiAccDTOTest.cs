using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Dto;

namespace UnitTestGroup14
{
    [TestFixture]
    public class LoaiAccDTOTest
    {
        /// <summary>
        /// Creates a new <see cref="LoaiAccDTO"/> instance.
        /// </summary>	
        public LoaiAccDTOTest()
        {
            //Add your init for this class
        }

        //Object for test
        private LoaiAccDTO obj;

        /// <summary>
        /// This method is used to construct the test environment prior to running the tests.
        /// </summary>        
        [TestFixtureSetUp]
        public void Init()
        {
            obj = new LoaiAccDTO();

            //Add your initialization for test enviroment here
        }

        [TestFixtureTearDown]
        public void Dispose()
        {
            //Add your clean up here
        }

        [Test]
        public void set_IDLoaiAccTest()
        {
            //TODO Write this test
            obj.IDLoaiAcc = 1;
            Assert.That(Is.Equals(obj.IDLoaiAcc, 1));
        }

        [Test]
        public void get_IDLoaiAccTest()
        {
            //TODO Write this test
            obj.IDLoaiAcc = 1;
            Assert.That(Is.Equals(obj.IDLoaiAcc, 1));
        }

        [Test]
        public void set_TenLoaiAccTest()
        {
            //TODO Write this test
            obj.TenLoaiAcc = "abc";
            Assert.That(Is.Equals(obj.TenLoaiAcc, "abc"));
        }

        [Test]
        public void get_TenLoaiAccTest()
        {
            //TODO Write this test
            obj.TenLoaiAcc = "abc";
            Assert.That(Is.Equals(obj.TenLoaiAcc, "abc"));
        }			
    }
}
