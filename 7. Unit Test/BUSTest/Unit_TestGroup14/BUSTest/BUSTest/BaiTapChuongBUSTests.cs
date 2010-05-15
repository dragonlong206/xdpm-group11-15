using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NUnit.Mocks;
namespace BUSTest
{
    [TestFixture]
    public class BaiTapChuongBUSTests
    {

        [Test]
        public void insertBaiTapChuongTest()
        {
            int a = new int();
            Assert.That(BaiTapChuongBUSMock.insertBaiTapChuong(new Dto.BaiTapChuongDTO(),ref a), Is.False);
            //TODO Write this test

        }

        [Test]
        public void deleteBaiTapChuongTest()
        {
            Assert.That(BaiTapChuongBUSMock.deleteBaiTapChuong(new Dto.BaiHocDTO().IDChuong), Is.True);
            //TODO Write this test

        }

        [Test]
        public void updateBaiTapChuongTest()
        {
            Assert.That(BaiTapChuongBUSMock.updateBaiTapChuong(new Dto.BaiTapChuongDTO()), Is.False);
            //TODO Write this test

        }

        [Test]
        public void selectAllBaiTapChuongTest()
        {
            Assert.That(BaiTapChuongBUSMock.selectAllBaiTapChuong(), Is.Null);
            //TODO Write this test

        }

        [Test]
        public void selectBaiTapChuongByIDTest()
        {
            Assert.That(BaiTapChuongBUSMock.selectBaiTapChuongByID(new Dto.BaiTapChuongDTO().IDBaiTap), Is.Not.Null);
            //TODO Write this test

        }

        [Test]
        public void selectBaiTapChuongByIDChuongTest()
        {
            Assert.That(BaiTapChuongBUSMock.selectBaiTapChuongByIDChuong(new Dto.BaiTapChuongDTO().IDChuong),Is.Not.Null);
            //TODO Write this test

        }

     
    }
}
