using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NUnit.Mocks;
namespace BUSTest
{
    [TestFixture]
    public class CommentBaiHocBUSTests
    {

        [Test]
        public void insertCommentBaiHocTest()
        {
            Assert.That(CommentBaiHocBUSMock.insertCommentBaiHoc(new Dto.CommentBaiHocDTO()), Is.True);
            //TODO Write this test

        }

        [Test]
        public void deleteCommentBaiHocTest()
        {
            Assert.That(CommentBaiHocBUSMock.deleteCommentBaiHoc(new int()), Is.False);
            //TODO Write this test

        }

        [Test]
        public void updateCommentBaiHocTest()
        {
            Assert.That(CommentBaiHocBUSMock.updateCommentBaiHoc(new Dto.CommentBaiHocDTO()), Is.True);
            //TODO Write this test

        }

        [Test]
        public void selectAllCommetBaiHocTest()
        {
            Assert.That(CommentBaiHocBUSMock.selectAllCommetBaiHoc(), Is.Not.Null);
            //TODO Write this test

        }

        [Test]
        public void selectCommentBaiHocByIDBaiHocTest()
        {
            Assert.That(CommentBaiHocBUSMock.selectCommentBaiHocByIDBaiHoc(new int()), Is.Not.Null);
            //TODO Write this test

        }

        [Test]
        public void selectCommentBaiHocByIDCommentTest()
        {
            Assert.That(CommentBaiHocBUSMock.selectCommentBaiHocByIDComment(new int()), Is.Null);
            //TODO Write this test

        }

      
    }
}
