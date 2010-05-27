using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using NUnit.Framework;
using NUnit.Mocks;
using Dto;

namespace UnitTestGroup14
{
    [TestFixture]
    public class CommentBaiTapBaiHocDAOTests
    {
        CommentBaiTapBaiHocDAO _CommentBaiTapBaiHocDAO;
        ISqlDataAccessHelper _sqlDataAccessHelper;
        DynamicMock _controller;


        [Test]
        public void insertCommentBaiTapBaiHocTest()
        {
            _controller = new DynamicMock(typeof(ISqlDataAccessHelper));
            _sqlDataAccessHelper = _controller.MockInstance as ISqlDataAccessHelper;
            _CommentBaiTapBaiHocDAO = new CommentBaiTapBaiHocDAO(_sqlDataAccessHelper);
            //TODO Write this test


            _controller.ExpectAndReturn("ExecuteNonQuery",1,string.Empty,new List<SqlParameter>());
            Assert.That(_CommentBaiTapBaiHocDAO.insertCommentBaiTapBaiHoc(new CommentBaiTapBaiHocDTO()),Is.True);
        }

        [Test]
        public void deleteCommentBaiTapBaiHocTest()
        {
            _controller = new DynamicMock(typeof(ISqlDataAccessHelper));
            _sqlDataAccessHelper = _controller.MockInstance as ISqlDataAccessHelper;
            _CommentBaiTapBaiHocDAO = new CommentBaiTapBaiHocDAO(_sqlDataAccessHelper);
            //TODO Write this test


            _controller.ExpectAndReturn("ExecuteNonQuery",0,string.Empty,new List<SqlParameter>());
            Assert.That(_CommentBaiTapBaiHocDAO.deleteCommentBaiTapBaiHoc(0),Is.False);
        }

        [Test]
        public void updateCommentBaiTapBaiHocTest()
        {
            _controller = new DynamicMock(typeof(ISqlDataAccessHelper));
            _sqlDataAccessHelper = _controller.MockInstance as ISqlDataAccessHelper;
            _CommentBaiTapBaiHocDAO = new CommentBaiTapBaiHocDAO(_sqlDataAccessHelper);
            //TODO Write this test


            _controller.ExpectAndReturn("ExecuteNonQuery",0,string.Empty,new List<SqlParameter>());
            Assert.That(_CommentBaiTapBaiHocDAO.updateCommentBaiTapBaiHoc(new CommentBaiTapBaiHocDTO()),Is.False);
        }

        [Test]
        public void selectAllCommentBaiTapBaiHocTest()
        {
            _controller = new DynamicMock(typeof(ISqlDataAccessHelper));
            _sqlDataAccessHelper = _controller.MockInstance as ISqlDataAccessHelper;
            _CommentBaiTapBaiHocDAO = new CommentBaiTapBaiHocDAO(_sqlDataAccessHelper);
            //TODO Write this test


            _controller.ExpectAndReturn("ExecuteQuery",null,string.Empty);
            Assert.That(_CommentBaiTapBaiHocDAO.selectAllCommentBaiTapBaiHoc(),Is.Null);
        }

        [Test]
        public void selectCommentBaiTapBaiHocByIDCommentTest()
        {
            _controller = new DynamicMock(typeof(ISqlDataAccessHelper));
            _sqlDataAccessHelper = _controller.MockInstance as ISqlDataAccessHelper;
            _CommentBaiTapBaiHocDAO = new CommentBaiTapBaiHocDAO(_sqlDataAccessHelper);
            //TODO Write this test


            _controller.ExpectAndReturn("ExecuteQuery",null,string.Empty,new List<SqlParameter>());
            Assert.That(_CommentBaiTapBaiHocDAO.selectCommentBaiTapBaiHocByIDComment(0),Is.Null);
        }

        [Test]
        public void selectCommentBaiTapBaiHocByIDBTBaiHocTest()
        {
            _controller = new DynamicMock(typeof(ISqlDataAccessHelper));
            _sqlDataAccessHelper = _controller.MockInstance as ISqlDataAccessHelper;
            _CommentBaiTapBaiHocDAO = new CommentBaiTapBaiHocDAO(_sqlDataAccessHelper);
            //TODO Write this test


            _controller.ExpectAndReturn("ExecuteQuery",null,string.Empty,new List<SqlParameter>());
            Assert.That(_CommentBaiTapBaiHocDAO.selectCommentBaiTapBaiHocByIDBTBaiHoc(0),Is.Null);
        }	
    }
}
