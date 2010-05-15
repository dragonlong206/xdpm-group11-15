using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NUnit.Mocks;
namespace BUSTest
{
    [TestFixture]
    public class CommentBaiTapBaiHocBUSTests
    {

        [Test]
        public void insertCommentBaiTapBaiHocTest()
        {
            Assert.That(CommentBaiTapBaiHocBUSMock.insertCommentBaiTapBaiHoc(new Dto.CommentBaiTapBaiHocDTO()), Is.True);
            //TODO Write this test

        }

        [Test]
        public void deleteCommentBaiTapBaiHocTest()
        {
            Assert.That(CommentBaiTapBaiHocBUSMock.deleteCommentBaiTapBaiHoc(new int()), Is.False);
            //TODO Write this test

        }

        [Test]
        public void updateCommentBaiTapBaiHocTest()
        {
            Assert.That(CommentBaiTapBaiHocBUSMock.updateCommentBaiTapBaiHoc(new Dto.CommentBaiTapBaiHocDTO()), Is.True);
            //TODO Write this test

        }

        [Test]
        public void selectAllCommetBaiHocTest()
        {
            Assert.That(CommentBaiTapBaiHocBUSMock.selectAllCommetBaiTapBaiHoc(), Is.Not.Null);
            //TODO Write this test

        }

        [Test]
        public void selectCommentBaiTapBaiHocByIDBaiTapBaiHocTest()
        {
            Assert.That(CommentBaiTapBaiHocBUSMock.selectCommentBaiTapBaiHocByIDBaiTapBaiHoc(new int()), Is.Null);
            //TODO Write this test

        }

        [Test]
        public void selectCommentBaiTapBaiHocByIDCommentTest()
        {
            Assert.That(CommentBaiTapBaiHocBUSMock.selectCommentBaiTapBaiHocByIDComment(new int()), Is.Not.Null);
            //TODO Write this test

        }

     
    }
}
