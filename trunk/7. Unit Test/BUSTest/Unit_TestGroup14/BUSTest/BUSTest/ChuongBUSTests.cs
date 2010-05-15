using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NUnit.Mocks;
namespace BUSTest
{

    [TestFixture]
    public class ChuongBUSTests
    {

        [Test]
        public void insertChuongTest()
        {
            Assert.That(ChuongBUSMock.insertChuong(new Dto.ChuongDTO()), Is.True);
            //TODO Write this test

        }

        [Test]
        public void deleteChuongTest()
        {
            Assert.That(ChuongBUSMock.deleteChuong(new Dto.ChuongDTO().TenChuong), Is.False);
            //TODO Write this test

        }

        [Test]
        public void updateChuongTest()
        {
            Assert.That(ChuongBUSMock.updateChuong(new Dto.ChuongDTO()), Is.True);
            //TODO Write this test

        }

        [Test]
        public void selectAllChuongTest()
        {
            Assert.That(ChuongBUSMock.selectAllChuong(), Is.Not.Null);
            //TODO Write this test

        }

        [Test]
        public void selectChuongByIDChuongTest()
        {
            Assert.That(ChuongBUSMock.selectChuongByIDChuong(new int()), Is.Not.Null);
            //TODO Write this test

        }

        [Test]
        public void selectChuongByIDMonHocTest()
        {
            Assert.That(ChuongBUSMock.selectChuongByIDMonHoc(new int()), Is.Not.Null);
            //TODO Write this test

        }

       
    }
}
