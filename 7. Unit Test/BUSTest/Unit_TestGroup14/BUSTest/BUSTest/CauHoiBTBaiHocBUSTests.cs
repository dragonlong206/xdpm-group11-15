using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NUnit.Mocks;
namespace BUSTest
{
    [TestFixture]
    public class CauHoiBTBaiHocBUSTests
    {

        [Test]
        public void insertCauHoiBTBaiHocTest()
        {
            Assert.That(CauHoiBTBaiHocBUSMock.insertCauHoiBTBaiHoc(new Dto.CauHoiBTBaiHocDTO()), Is.True);
            //TODO Write this test

        }

        [Test]
        public void deleteCauHoiBTBaiHocTest()
        {
            Assert.That(CauHoiBTBaiHocBUSMock.deleteCauHoiBTBaiHoc(new int()), Is.False);
            //TODO Write this test

        }

        [Test]
        public void deleteCauHoiBTBaiHocByIDBaiTapTest()
        {
            Assert.That(CauHoiBTBaiHocBUSMock.deleteCauHoiBTBaiHocByIDBaiTap(new int()), Is.True);
            //TODO Write this test

        }

        [Test]
        public void updateCauHoiBTBaiHocTest()
        {
            Assert.That(CauHoiBTBaiHocBUSMock.updateCauHoiBTBaiHoc(new Dto.CauHoiBTBaiHocDTO()), Is.False);
            //TODO Write this test

        }

        [Test]
        public void selectAllBaiHocTest()
        {
            Assert.That(CauHoiBTBaiHocBUSMock.selectCauHoiBTBaiHocByIDBaiTap(0), Is.Not.Null);
            //TODO Write this test

        }

        [Test]
        public void selectCauHoiBTBaiHocByIDBaiTapTest()
        {
            Assert.That(CauHoiBTBaiHocBUSMock.selectCauHoiBTBaiHocByIDBaiTap(new int()), Is.Not.Null);
            //TODO Write this test

        }

        [Test]
        public void selectCauHoiBTBaiHocByIDCauHoiTest()
        {
            Assert.That(CauHoiBTBaiHocBUSMock.selectCauHoiBTBaiHocByIDCauHoi(new int()), Is.Not.Null);
            //TODO Write this test

        }

      
    }
}
