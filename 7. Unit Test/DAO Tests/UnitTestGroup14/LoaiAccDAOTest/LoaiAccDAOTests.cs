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
    public class LoaiAccDAOTests
    {
        LoaiAccDAO _LoaiAccDAO;
        ISqlDataAccessHelper _sqlDataAccessHelper;
        DynamicMock _controller;


        [Test]
        public void insertLoaiAccTest()
        {
            _controller = new DynamicMock(typeof(ISqlDataAccessHelper));
            _sqlDataAccessHelper = _controller.MockInstance as ISqlDataAccessHelper;
            _LoaiAccDAO = new LoaiAccDAO(_sqlDataAccessHelper);
            //TODO Write this test


            _controller.ExpectAndReturn("ExecuteNonQuery",1,string.Empty,new List<SqlParameter>());
            Assert.That(_LoaiAccDAO.insertLoaiAcc(new Dto.LoaiAccDTO()),Is.True);
        }

        [Test]
        public void deleteLoaiAccTest()
        {
            _controller = new DynamicMock(typeof(ISqlDataAccessHelper));
            _sqlDataAccessHelper = _controller.MockInstance as ISqlDataAccessHelper;
            _LoaiAccDAO = new LoaiAccDAO(_sqlDataAccessHelper);
            //TODO Write this test


            _controller.ExpectAndReturn("ExecuteNonQuery",0,string.Empty,new List<SqlParameter>());
            Assert.That(_LoaiAccDAO.deleteLoaiAcc(0),Is.False);
        }

        [Test]
        public void updateLoaiAccTest()
        {
            _controller = new DynamicMock(typeof(ISqlDataAccessHelper));
            _sqlDataAccessHelper = _controller.MockInstance as ISqlDataAccessHelper;
            _LoaiAccDAO = new LoaiAccDAO(_sqlDataAccessHelper);
            //TODO Write this test


            _controller.ExpectAndReturn("ExecuteNonQuery",0,string.Empty,new List<SqlParameter>());
            Assert.That(_LoaiAccDAO.updateLoaiAcc(new Dto.LoaiAccDTO()),Is.False);
        }

        [Test]
        public void selectAllLoaiAccTest()
        {
            _controller = new DynamicMock(typeof(ISqlDataAccessHelper));
            _sqlDataAccessHelper = _controller.MockInstance as ISqlDataAccessHelper;
            _LoaiAccDAO = new LoaiAccDAO(_sqlDataAccessHelper);
            //TODO Write this test


            _controller.ExpectAndReturn("ExecuteQuery",null,string.Empty);
            Assert.That(_LoaiAccDAO.selectAllLoaiAcc(),Is.Null);
        }

        [Test]
        public void selectLoaiAccByIDLoaiAccTest()
        {
            _controller = new DynamicMock(typeof(ISqlDataAccessHelper));
            _sqlDataAccessHelper = _controller.MockInstance as ISqlDataAccessHelper;
            _LoaiAccDAO = new LoaiAccDAO(_sqlDataAccessHelper);
            //TODO Write this test


            _controller.ExpectAndReturn("ExecuteQuery",null,string.Empty,new List<SqlParameter>());
            Assert.That(_LoaiAccDAO.selectLoaiAccByIDLoaiAcc(0),Is.Null);
        }				
    }
}
