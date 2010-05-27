using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using NUnit.Framework;
using NUnit.Mocks;

namespace UnitTestGroup14
{
    [TestFixture]
    public class CommentBaiHocDAOTests
    {
        CommentBaiHocDAO _commentBaiHocDAO;
        ISqlDataAccessHelper _sqlDataAccessHelper;
        DynamicMock _controller;

        [Test]
        public void insertCommentBaiHocTest()
        {
            //TODO Write this test
            _controller = new DynamicMock(typeof(ISqlDataAccessHelper));
            _sqlDataAccessHelper = _controller.MockInstance as ISqlDataAccessHelper;
            _commentBaiHocDAO = new CommentBaiHocDAO(_sqlDataAccessHelper);
            string SQLqurey = "insert into CommentBaiHoc(IDCommen, IDAcc, IDBaiHoc, NoiDung, NgayGio) values (@IDComment, @IDAcc, @IDBaiHoc, @NoiDung, @NgayGio)";
            
            int n = 1;
            _controller.ExpectAndReturn("ExecuteNonQuery", n, SQLqurey, new List<SqlParameter>());
            Assert.That(_commentBaiHocDAO.insertCommentBaiHoc(new Dto.CommentBaiHocDTO()),Is.True);
        }

        [Test]
        public void deleteCommentBaiHocTest()
        {
            //TODO Write this test
            _controller = new DynamicMock(typeof(ISqlDataAccessHelper));
            _sqlDataAccessHelper = _controller.MockInstance as ISqlDataAccessHelper;
            _commentBaiHocDAO = new CommentBaiHocDAO(_sqlDataAccessHelper);
            string SQLqurey = "delete from CommentBaiHoc Where IDComment = @IDComment";

            int n = 1;
            _controller.ExpectAndReturn("ExecuteNonQuery", n, SQLqurey, new List<SqlParameter>());
            Assert.That(_commentBaiHocDAO.deleteCommentBaiHoc(0), Is.True);
        }

        [Test]
        public void updateCommentBaiHocTest()
        {
            //TODO Write this test
            _controller = new DynamicMock(typeof(ISqlDataAccessHelper));
            _sqlDataAccessHelper = _controller.MockInstance as ISqlDataAccessHelper;
            _commentBaiHocDAO = new CommentBaiHocDAO(_sqlDataAccessHelper);
            string SQLqurey = "update CommentBaiHoc Set IDAcc = @IDAcc, IDBaiHoc = @IDBaiHoc, IDNoiDung = @NoiDung, NgayGioi = @NgayGio Where IDComment = @IDComment";

            int n = 1;
            _controller.ExpectAndReturn("ExecuteNonQuery", n, SQLqurey, new List<SqlParameter>());
            Assert.That(_commentBaiHocDAO.updateCommentBaiHoc(new Dto.CommentBaiHocDTO()), Is.True);
        }

        [Test]
        public void selectAllCommentBaiHocTest()
        {
            //TODO Write this test
            string SQLqurey = "Select * from CommentBaiHoc";
            _controller = new DynamicMock(typeof(ISqlDataAccessHelper));
            _sqlDataAccessHelper = _controller.MockInstance as ISqlDataAccessHelper;
            _commentBaiHocDAO = new CommentBaiHocDAO(_sqlDataAccessHelper);

            DataTable dt = null;
            _controller.ExpectAndReturn("ExecuteNonQuery", dt, SQLqurey);
            Assert.That(_commentBaiHocDAO.selectAllCommentBaiHoc(), Is.Null);
        }

        [Test]
        public void selectCommentBaiHocByIDCommentTest()
        {
            //TODO Write this test
            string SQLqurey = "Select * from CommentBaiHoc Where IDComment = @IDComment";
            _controller = new DynamicMock(typeof(ISqlDataAccessHelper));
            _sqlDataAccessHelper = _controller.MockInstance as ISqlDataAccessHelper;
            _commentBaiHocDAO = new CommentBaiHocDAO(_sqlDataAccessHelper);

            Dto.CommentBaiHocDTO obj = null;
            _controller.ExpectAndReturn("ExecuteNonQuery", obj, SQLqurey, new List<SqlParameter>());
            Assert.That(_commentBaiHocDAO.selectCommentBaiHocByIDComment(0), Is.Null);
        }

        [Test]
        public void selectCommentBaiHocByIDBaiHocTest()
        {
            //TODO Write this test
            
            string SQLqurey = "Select * from CommentBaiHoc where IDBaiHoc = @IDBaiHoc";
            _controller = new DynamicMock(typeof(ISqlDataAccessHelper));
            _sqlDataAccessHelper = _controller.MockInstance as ISqlDataAccessHelper;
            _commentBaiHocDAO = new CommentBaiHocDAO(_sqlDataAccessHelper);

            DataTable dt = null;
            _controller.ExpectAndReturn("ExecuteNonQuery", dt, SQLqurey, new List<SqlParameter>());
            Assert.That(_commentBaiHocDAO.selectCommentBaiHocByIDBaiHoc(0), Is.Null);
        }
    }	
}
