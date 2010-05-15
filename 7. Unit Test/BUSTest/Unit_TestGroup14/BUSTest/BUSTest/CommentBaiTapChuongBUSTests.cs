using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NUnit.Mocks;
namespace BUSTest
{
    [TestFixture]
    public class CommentBaiTapChuongBUSTests
    {

        [Test]
        public void insertCommentBaiTapChuongTest()
        {
            Assert.That(CommentBaiTapChuongBUSMock.insertCommentBaiTapChuong(new Dto.CommentBaiTapChuongDTO()), Is.True);
            //TODO Write this test

        }

        [Test]
        public void deleteCommentBaiTapChuongTest()
        {
            Assert.That(CommentBaiTapChuongBUSMock.deleteCommentBaiTapChuong(new int()), Is.True);

            //TODO Write this test

        }

        [Test]
        public void updateCommentBaiTapChuongTest()
        {
            Assert.That(CommentBaiTapChuongBUSMock.updateCommentBaiTapChuong(new Dto.CommentBaiTapChuongDTO()), Is.False);
            //TODO Write this test

        }

        [Test]
        public void selectAllCommetChuongTest()
        {
            Assert.That(CommentBaiTapChuongBUSMock.selectAllCommetBaiTapChuong(), Is.Not.Null);
            //TODO Write this test

        }

        [Test]
        public void selectCommentBaiTapChuongByIDBaiTapChuongTest()
        {
            Assert.That(CommentBaiTapChuongBUSMock.selectCommentBaiTapChuongByIDBTChuong(new int()), Is.Null);
            //TODO Write this test

        }

        [Test]
        public void selectCommentBaiTapChuongByIDCommentTest()
        {
            Assert.That(CommentBaiTapChuongBUSMock.selectCommentBaiTapChuongByIDComment(new int()), Is.Not.Null);
            //TODO Write this test

        }

     
    }
}
