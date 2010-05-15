using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NUnit.Mocks;
namespace BUSTest
{
    [TestFixture]
    public class CommentChuongBUSTests
    {

        [Test]
        public void insertCommentChuongTest()
        {
            Assert.That(CommentChuongBUSMock.insertCommentChuong(new Dto.CommentChuongDTO()), Is.True);
            //TODO Write this test

        }

        [Test]
        public void deleteCommentChuongTest()
        {
            Assert.That(CommentChuongBUSMock.deleteCommentChuong(new int()), Is.False);
            //TODO Write this test

        }

        [Test]
        public void updateCommentChuongTest()
        {
            Assert.That(CommentChuongBUSMock.updateCommentChuong(new Dto.CommentChuongDTO()), Is.True);
            //TODO Write this test

        }

        [Test]
        public void selectAllCommetChuongTest()
        {
            Assert.That(CommentChuongBUSMock.selectAllCommentChuong(), Is.Not.Null);
            //TODO Write this test

        }

        [Test]
        public void selectCommentChuongByIDChuongTest()
        {
            Assert.That(CommentChuongBUSMock.selectCommentChuongByIDChuong(new int()), Is.Null);
            //TODO Write this test

        }

        [Test]
        public void selectCommentChuongByIDCommentTest()
        {
            Assert.That(CommentChuongBUSMock.selectCommentChuongByIDComment(new int()), Is.Not.Null);
            //TODO Write this test

        }

       
    }
}
