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
    public class CommentBaiTapChuongDAOTests
    {
        CommentBaiTapChuongDAO _CommentBaiTapChuongDAO;
        ISqlDataAccessHelper _sqlDataAccessHelper;
        DynamicMock _controller;


        [Test]
        public void insertCommentBaiTapChuongTest()
        {
            _controller = new DynamicMock(typeof(ISqlDataAccessHelper));
            _sqlDataAccessHelper = _controller.MockInstance as ISqlDataAccessHelper;
            _CommentBaiTapChuongDAO = new CommentBaiTapChuongDAO(_sqlDataAccessHelper);
            //TODO Write this test


            _controller.ExpectAndReturn("ExecuteNonQuery",0,string.Empty,new List<SqlParameter>());
            Assert.That(_CommentBaiTapChuongDAO.insertCommentBaiTapChuong(new Dto.CommentBaiTapChuongDTO()),Is.False);
        }

        [Test]
        public void deleteCommentBaiTapChuongTest()
        {
            _controller = new DynamicMock(typeof(ISqlDataAccessHelper));
            _sqlDataAccessHelper = _controller.MockInstance as ISqlDataAccessHelper;
            _CommentBaiTapChuongDAO = new CommentBaiTapChuongDAO(_sqlDataAccessHelper);
            //TODO Write this test


            _controller.ExpectAndReturn("ExecuteNonQuery",1,string.Empty,new List<SqlParameter>());
            Assert.That(_CommentBaiTapChuongDAO.deleteCommentBaiTapChuong(0),Is.True);
        }

        [Test]
        public void updateCommentBaiTapChuongTest()
        {
            _controller = new DynamicMock(typeof(ISqlDataAccessHelper));
            _sqlDataAccessHelper = _controller.MockInstance as ISqlDataAccessHelper;
            _CommentBaiTapChuongDAO = new CommentBaiTapChuongDAO(_sqlDataAccessHelper);
            //TODO Write this test


            _controller.ExpectAndReturn("ExecuteNonQuery",1,string.Empty,new List<SqlParameter>());
            Assert.That(_CommentBaiTapChuongDAO.updateCommentBaiTapChuong(new Dto.CommentBaiTapChuongDTO()),Is.True);
        }

        [Test]
        public void selectAllCommentBaiTapChuongTest()
        {
            _controller = new DynamicMock(typeof(ISqlDataAccessHelper));
            _sqlDataAccessHelper = _controller.MockInstance as ISqlDataAccessHelper;
            _CommentBaiTapChuongDAO = new CommentBaiTapChuongDAO(_sqlDataAccessHelper);
            //TODO Write this test


            _controller.ExpectAndReturn("ExecuteQuery",null,string.Empty);
            Assert.That(_CommentBaiTapChuongDAO.selectAllCommentBaiTapChuong(),Is.Null);
        }

        [Test]
        public void selectCommentBaiTapChuongByIDCommentTest()
        {
            _controller = new DynamicMock(typeof(ISqlDataAccessHelper));
            _sqlDataAccessHelper = _controller.MockInstance as ISqlDataAccessHelper;
            _CommentBaiTapChuongDAO = new CommentBaiTapChuongDAO(_sqlDataAccessHelper);
            //TODO Write this test


            _controller.ExpectAndReturn("ExecuteQuery",null,string.Empty,new List<SqlParameter>());
            Assert.That(_CommentBaiTapChuongDAO.selectCommentBaiTapChuongByIDComment(0),Is.Null);
        }

        [Test]
        public void selectCommentBaiTapChuongByIDBTChuongTest()
        {
            _controller = new DynamicMock(typeof(ISqlDataAccessHelper));
            _sqlDataAccessHelper = _controller.MockInstance as ISqlDataAccessHelper;
            _CommentBaiTapChuongDAO = new CommentBaiTapChuongDAO(_sqlDataAccessHelper);
            //TODO Write this test


            _controller.ExpectAndReturn("ExecuteQuery",null,string.Empty,new List<SqlParameter>());
            Assert.That(_CommentBaiTapChuongDAO.selectCommentBaiTapChuongByIDBTChuong(0),Is.Null);
        }
    }		
}
