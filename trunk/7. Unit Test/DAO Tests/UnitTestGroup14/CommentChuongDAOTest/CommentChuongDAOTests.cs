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
    public class CommentChuongDAOTests
    {
        CommentChuongDAO _CommentChuongDAO;
        ISqlDataAccessHelper _sqlDataAccessHelper;
        DynamicMock _controller;


        [Test]
        public void insertCommentChuongTest()
        {
            _controller = new DynamicMock(typeof(ISqlDataAccessHelper));
            _sqlDataAccessHelper = _controller.MockInstance as ISqlDataAccessHelper;
            _CommentChuongDAO = new CommentChuongDAO(_sqlDataAccessHelper);
            //TODO Write this test


            _controller.ExpectAndReturn("ExecuteNonQuery",1,string.Empty,new List<SqlParameter>());
            Assert.That(_CommentChuongDAO.insertCommentChuong(new Dto.CommentChuongDTO()),Is.True);
        }

        [Test]
        public void deleteCommentChuongTest()
        {
            _controller = new DynamicMock(typeof(ISqlDataAccessHelper));
            _sqlDataAccessHelper = _controller.MockInstance as ISqlDataAccessHelper;
            _CommentChuongDAO = new CommentChuongDAO(_sqlDataAccessHelper);
            //TODO Write this test


            _controller.ExpectAndReturn("ExecuteNonQuery",0,string.Empty,new List<SqlParameter>());
            Assert.That(_CommentChuongDAO.deleteCommentChuong( 0),Is.False);
        }

        [Test]
        public void updateCommentChuongTest()
        {
            _controller = new DynamicMock(typeof(ISqlDataAccessHelper));
            _sqlDataAccessHelper = _controller.MockInstance as ISqlDataAccessHelper;
            _CommentChuongDAO = new CommentChuongDAO(_sqlDataAccessHelper);
            //TODO Write this test


            _controller.ExpectAndReturn("ExecuteNonQuery",1,string.Empty,new List<SqlParameter>());
            Assert.That(_CommentChuongDAO.updateCommentChuong(new Dto.CommentChuongDTO()),Is.True);
        }

        [Test]
        public void selectAllCommentChuongTest()
        {
            _controller = new DynamicMock(typeof(ISqlDataAccessHelper));
            _sqlDataAccessHelper = _controller.MockInstance as ISqlDataAccessHelper;
            _CommentChuongDAO = new CommentChuongDAO(_sqlDataAccessHelper);
            //TODO Write this test


            _controller.ExpectAndReturn("ExecuteQuery",null,string.Empty);
            Assert.That(_CommentChuongDAO.selectAllCommentChuong(),Is.Null);
        }

        [Test]
        public void selectCommentChuongByIDCommentTest()
        {
            _controller = new DynamicMock(typeof(ISqlDataAccessHelper));
            _sqlDataAccessHelper = _controller.MockInstance as ISqlDataAccessHelper;
            _CommentChuongDAO = new CommentChuongDAO(_sqlDataAccessHelper);
            //TODO Write this test


            _controller.ExpectAndReturn("ExecuteQuery",null,string.Empty,new List<SqlParameter>());
            Assert.That(_CommentChuongDAO.selectCommentChuongByIDComment(0),Is.Null);
        }

        [Test]
        public void selectCommentChuongByIDChuongTest()
        {
            _controller = new DynamicMock(typeof(ISqlDataAccessHelper));
            _sqlDataAccessHelper = _controller.MockInstance as ISqlDataAccessHelper;
            _CommentChuongDAO = new CommentChuongDAO(_sqlDataAccessHelper);
            //TODO Write this test


            _controller.ExpectAndReturn("ExecuteQuery",null,string.Empty,new List<SqlParameter>());
            Assert.That(_CommentChuongDAO.selectCommentChuongByIDChuong(0),Is.Null);
        }						
    }		
}
