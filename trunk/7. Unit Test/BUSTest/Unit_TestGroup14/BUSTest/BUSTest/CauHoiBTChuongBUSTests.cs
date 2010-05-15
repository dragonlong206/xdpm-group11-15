using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NUnit.Mocks;
namespace BUSTest
{


    [TestFixture]
    public class CauHoiBTChuongBUSTests
    {

        [Test]
        public void insertCauHoiBTChuongTest()
        {
            Assert.That(CauHoiBTChuongBUSMock.insertCauHoiBTChuong(new Dto.CauHoiBTChuongDTO()), Is.False);
            //TODO Write this test

        }

        [Test]
        public void deleteCauHoiBTChuongTest()
        {
            Assert.That(CauHoiBTChuongBUSMock.deleteCauHoiBTChuong(new int()), Is.True);
            //TODO Write this test

        }

        [Test]
        public void deleteCauHoiBTChuongByIDBaiTapTest()
        {
            Assert.That(CauHoiBTChuongBUSMock.deleteCauHoiBTChuongByIDBaiTap(new int()), Is.False);
            //TODO Write this test

        }

        [Test]
        public void updateCauHoiBTChuongTest()
        {
            Assert.That(CauHoiBTChuongBUSMock.updateCauHoiBTChuong(new Dto.CauHoiBTChuongDTO()), Is.True);


            //TODO Write this test

        }

       

        [Test]
        public void selectCauHoiBTChuongByIDChuongTest()
        {
            Assert.That(CauHoiBTChuongBUSMock.selectCauHoiBTChuongByIDChuong(new int()), Is.Null);
            //TODO Write this test

        }

        [Test]
        public void selectCauHoiBTChuongByIDBaiTapTest()
        {
            Assert.That(CauHoiBTChuongBUSMock.selectCauHoiBTChuongByIDBaiTap(new int()), Is.Not.Null);
            //TODO Write this test

        }

        [Test]
        public void selectCauHoiBTChuongByIDCauHoiTest()
        {
            Assert.That(CauHoiBTChuongBUSMock.selectCauHoiBTChuongByIDCauHoi(new int()), Is.Not.Null);
            //TODO Write this test

        }

       
    }
}
