using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Dto;

namespace UnitTestGroup14
{
    [TestFixture]
    public class CauHoiBTBaiHocDTOTest
    {
        /// <summary>
        /// Creates a new <see cref="CauHoiBTBaiHocDTO"/> instance.
        /// </summary>	
        public CauHoiBTBaiHocDTOTest()
        {
            //Add your init for this class
        }

        //Object for test
        private CauHoiBTBaiHocDTO obj;

        /// <summary>
        /// This method is used to construct the test environment prior to running the tests.
        /// </summary>        
        [TestFixtureSetUp]
        public void Init()
        {
            obj = new CauHoiBTBaiHocDTO();

            //Add your initialization for test enviroment here
        }

        [TestFixtureTearDown]
        public void Dispose()
        {
            //Add your clean up here
        }

        [Test]
        public void set_IDCauHoiTest()
        {
            //TODO Write this test
            obj.IDCauHoi = 1;
            Assert.That(Is.Equals(obj.IDCauHoi, 1));
        }

        [Test]
        public void get_IDCauHoiTest()
        {
            //TODO Write this test
            obj.IDCauHoi = 1;
            Assert.That(Is.Equals(obj.IDCauHoi, 1));
        }

        [Test]
        public void set_CauHoiATest()
        {
            //TODO Write this test
            obj.CauHoiA = "abc";
            Assert.That(Is.Equals(obj.CauHoiA, "abc"));
        }

        [Test]
        public void get_CauHoiATest()
        {
            //TODO Write this test
            obj.CauHoiA = "abc";
            Assert.That(Is.Equals(obj.CauHoiA, "abc"));
        }

        [Test]
        public void set_CauHoiBTest()
        {
            //TODO Write this test
            obj.CauHoiB = "abc";
            Assert.That(Is.Equals(obj.CauHoiB, "abc"));
        }

        [Test]
        public void get_CauHoiBTest()
        {
            //TODO Write this test
            obj.CauHoiB = "abc";
            Assert.That(Is.Equals(obj.CauHoiB, "abc"));
        }

        [Test]
        public void set_CauHoiCTest()
        {
            //TODO Write this test
            obj.CauHoiC = "abc";
            Assert.That(Is.Equals(obj.CauHoiC, "abc"));
        }

        [Test]
        public void get_CauHoiCTest()
        {
            //TODO Write this test
            obj.CauHoiC = "abc";
            Assert.That(Is.Equals(obj.CauHoiC, "abc"));
        }

        [Test]
        public void set_CauHoiDTest()
        {
            //TODO Write this test
            obj.CauHoiD = "abc";
            Assert.That(Is.Equals(obj.CauHoiD, "abc"));
        }

        [Test]
        public void get_CauHoiDTest()
        {
            //TODO Write this test
            obj.CauHoiD = "abc";
            Assert.That(Is.Equals(obj.CauHoiD, "abc"));
        }

        [Test]
        public void set_CauTraLoiTest()
        {
            //TODO Write this test
            obj.CauTraLoi = 'a';
            Assert.That(Is.Equals(obj.CauTraLoi, 'a'));
        }

        [Test]
        public void get_CauTraLoiTest()
        {
            //TODO Write this test
            obj.CauTraLoi = 'a';
            Assert.That(Is.Equals(obj.CauTraLoi, 'a'));
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
    }			
}
