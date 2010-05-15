using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NUnit.Mocks;
namespace BUSTest
{

    [TestFixture]
    public class BaiHocBUSTests
    {

        [Test]
        public void insertBaiHocTest()
        {
            Assert.That(BaiHocBUSMock.insertBaiHoc(new Dto.BaiHocDTO()),Is.False);
            //TODO Write this test

        }

        [Test]
        public void insertBaiHocAutoIncreaseTest()
        {
            Assert.That(BaiHocBUSMock.insertBaiHocAutoIncrease(new Dto.BaiHocDTO()), Is.False);
            //TODO Write this test

        }

        [Test]
        public void deleteBaiHocTest()
        {
            Assert.That(BaiHocBUSMock.deleteBaiHoc(new Dto.BaiHocDTO().TenBaiHoc), Is.True);
            //TODO Write this test

        }

        [Test]
        public void updateBaiHocTest()
        {

            Assert.That(BaiHocBUSMock.updateBaiHoc(new Dto.BaiHocDTO()), Is.True);
            //TODO Write this test

        }

        [Test]
        public void selectAllBaiHocTest()
        {
            Assert.That(BaiHocBUSMock.selectAllBaiHoc(), Is.Null);
            //TODO Write this test

        }

        [Test]
        public void selectBaiHocByIDBaiHocTest()
        {
            Assert.That(BaiHocBUSMock.selectBaiHocByIDBaiHoc(new Dto.BaiHocDTO().IDBaiHoc), Is.EqualTo(new Dto.BaiHocDTO()));
               //TODO Write this test

        }

        [Test]
        public void selectBaiHocByIDChuongTest()
        {
              Assert.That(BaiHocBUSMock.selectBaiHocByIDChuong(new Dto.BaiHocDTO().IDChuong), Is.EqualTo(new Dto.BaiHocDTO()));
            //TODO Write this test

        }

        [Test]
        public void selectIDvaTenBaiHocByIDChuongTest()
        {
              Assert.That(BaiHocBUSMock.selectIDvaTenBaiHocByIDChuong(new Dto.BaiHocDTO().IDChuong), Is.EqualTo(new Dto.BaiHocDTO()));
            //TODO Write this test

        }

      
    }
}
