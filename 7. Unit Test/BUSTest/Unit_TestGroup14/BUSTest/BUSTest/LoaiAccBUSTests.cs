using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NUnit.Mocks;
namespace BUSTest
{
    [TestFixture]
    public class LoaiAccBUSTests
    {

        [Test]
        public void insertLoaiAccTest()
        {
            Assert.That(LoaiAccBUSMock.insertLoaiAcc(new Dto.LoaiAccDTO()), Is.True);
            //TODO Write this test

        }

        [Test]
        public void deleteLoaiAccTest()
        {
            Assert.That(LoaiAccBUSMock.deleteLoaiAcc(new Dto.LoaiAccDTO().TenLoaiAcc), Is.False);
            //TODO Write this test

        }

        [Test]
        public void updateLoaiAccTest()
        {
            Assert.That(LoaiAccBUSMock.updateLoaiAcc(new Dto.LoaiAccDTO()), Is.True);
            //TODO Write this test

        }

        [Test]
        public void selectAllLoaiAccTest()
        {
            Assert.That(LoaiAccBUSMock.selectAllLoaiAcc(), Is.Not.Null);
            //TODO Write this test

        }

        [Test]
        public void selectLoaiAccByIDLoaiAccTest()
        {
            Assert.That(LoaiAccBUSMock.selectLoaiAccByIDLoaiAcc(new int()), Is.Null);
            //TODO Write this test

        }

    }
}
