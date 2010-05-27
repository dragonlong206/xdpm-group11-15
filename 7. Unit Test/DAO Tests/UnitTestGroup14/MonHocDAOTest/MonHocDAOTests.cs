using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NUnit.Mocks;
using System.Data;
using System.Data.SqlClient;

namespace UnitTestGroup14
{
    [TestFixture]
    public class MonHocDAOTests
    {
        MonHocDAO _MonHocDAO;
        ISqlDataAccessHelper _sqlDataAccessHelper;
        DynamicMock _controller;


        [Test]
        public void insertMonHocTest()
        {
            _controller = new DynamicMock(typeof(ISqlDataAccessHelper));
            _sqlDataAccessHelper = _controller.MockInstance as ISqlDataAccessHelper;
            _MonHocDAO = new MonHocDAO(_sqlDataAccessHelper);
            //TODO Write this test


            _controller.ExpectAndReturn("ExecuteNonQuery",1,string.Empty,new List<SqlParameter>());
            Assert.That(_MonHocDAO.insertMonHoc(new Dto.MonHocDTO()),Is.True);
        }

        [Test]
        public void deleteMonHocTest()
        {
            _controller = new DynamicMock(typeof(ISqlDataAccessHelper));
            _sqlDataAccessHelper = _controller.MockInstance as ISqlDataAccessHelper;
            _MonHocDAO = new MonHocDAO(_sqlDataAccessHelper);
            //TODO Write this test


            _controller.ExpectAndReturn("ExecuteNonQuery",0,string.Empty,new List<SqlParameter>());
            Assert.That(_MonHocDAO.deleteMonHoc(0),Is.False);
        }

        [Test]
        public void updateMonHocTest()
        {
            _controller = new DynamicMock(typeof(ISqlDataAccessHelper));
            _sqlDataAccessHelper = _controller.MockInstance as ISqlDataAccessHelper;
            _MonHocDAO = new MonHocDAO(_sqlDataAccessHelper);
            //TODO Write this test


            _controller.ExpectAndReturn("ExecuteNonQuery",0,string.Empty,new List<SqlParameter>());
            Assert.That(_MonHocDAO.updateMonHoc(new Dto.MonHocDTO()),Is.False);
        }

        [Test]
        public void selectAllMonHocTest()
        {
            _controller = new DynamicMock(typeof(ISqlDataAccessHelper));
            _sqlDataAccessHelper = _controller.MockInstance as ISqlDataAccessHelper;
            _MonHocDAO = new MonHocDAO(_sqlDataAccessHelper);
            //TODO Write this test


            _controller.ExpectAndReturn("ExecuteQuery",null,string.Empty);
            Assert.That(_MonHocDAO.selectAllMonHoc(),Is.Null);
        }

        [Test]
        public void selectMonHocByIDMonHocTest()
        {
            _controller = new DynamicMock(typeof(ISqlDataAccessHelper));
            _sqlDataAccessHelper = _controller.MockInstance as ISqlDataAccessHelper;
            _MonHocDAO = new MonHocDAO(_sqlDataAccessHelper);
            //TODO Write this test


            _controller.ExpectAndReturn("ExecuteQuery",null,string.Empty,new List<SqlParameter>());
            Assert.That(_MonHocDAO.selectMonHocByIDMonHoc(0),Is.Null);
        }				
    }
}
