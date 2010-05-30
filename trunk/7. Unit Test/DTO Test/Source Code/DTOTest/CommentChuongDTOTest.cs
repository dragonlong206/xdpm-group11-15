﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Dto;

namespace UnitTestGroup14
{

    [TestFixture]
    public class CommentChuongDTOTest
    {
        /// <summary>
        /// Creates a new <see cref="CommentChuongDTO"/> instance.
        /// </summary>	
        public CommentChuongDTOTest()
        {
            //Add your init for this class
        }

        //Object for test
        private CommentChuongDTO obj;

        /// <summary>
        /// This method is used to construct the test environment prior to running the tests.
        /// </summary>        
        [TestFixtureSetUp]
        public void Init()
        {
            obj = new CommentChuongDTO();

            //Add your initialization for test enviroment here
        }

        [TestFixtureTearDown]
        public void Dispose()
        {
            //Add your clean up here
        }

        [Test]
        public void set_IDCommentTest()
        {
            //TODO Write this test
            obj.IDComment = 1;
            Assert.That(Is.Equals(obj.IDComment, 1));
        }

        [Test]
        public void get_IDCommentTest()
        {
            //TODO Write this test
            obj.IDComment = 1;
            Assert.That(Is.Equals(obj.IDComment, 1));
        }

        [Test]
        public void set_IDAccTest()
        {
            //TODO Write this test
            obj.IDAcc = "1";
            Assert.That(Is.Equals(obj.IDAcc, "1"));
        }

        [Test]
        public void get_IDAccTest()
        {
            //TODO Write this test
            obj.IDAcc = "1";
            Assert.That(Is.Equals(obj.IDAcc, "1"));
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
        public void set_NoiDungTest()
        {
            //TODO Write this test
            obj.NoiDung = "abc";
            Assert.That(Is.Equals(obj.NoiDung, "abc"));
        }

        [Test]
        public void get_NoiDungTest()
        {
            //TODO Write this test
            obj.NoiDung = "abc";
            Assert.That(Is.Equals(obj.NoiDung, "abc"));
        }

        [Test]
        public void set_NgayGioTest()
        {
            //TODO Write this test
            DateTime dt = DateTime.Now;
            obj.NgayGio = dt;
            Assert.That(Is.Equals(obj.NgayGio, dt));
        }

        [Test]
        public void get_NgayGioTest()
        {
            //TODO Write this test
            DateTime dt = DateTime.Now;
            obj.NgayGio = dt;
            Assert.That(Is.Equals(obj.NgayGio, dt));
        }			
    }			
}