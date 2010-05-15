using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NUnit.Mocks;
namespace BUSTest
{
    [TestFixture]
    public class BaiTapCuaBaiHocBUSTests
    {

        [Test]
        public void insertBaiTapCuaBaiHocTest()
        {
            int a = new int();
            Assert.That(BaiTapCuaBaiHocBUSMock.insertBaiTapCuaBaiHoc(new Dto.BaiTapCuaBaiHocDTO(),ref a),Is.False);
            //TODO Write this test

        }

        [Test]
        public void deleteBaiTapCuaBaiHocTest()
        {
            Assert.That(BaiTapCuaBaiHocBUSMock.deleteBaiTapCuaBaiHoc(new int()), Is.False);
            //TODO Write this test

        }

        [Test]
        public void updateBaiTapCuaBaiHocTest()
        {
            Assert.That(BaiTapCuaBaiHocBUSMock.updateBaiTapCuaBaiHoc(new Dto.BaiTapCuaBaiHocDTO()), Is.False);

            //TODO Write this test

        }

        [Test]
        public void selectAllBaiTapCuaBaiHocTest()
        {
            Assert.That(BaiTapCuaBaiHocBUSMock.selectAllBaiTapCuaBaiHoc(), Is.Not.Null);
            //TODO Write this test

        }

        [Test]
        public void selectBaiTapCuaBaiHocByIDTest()
        {
            Assert.That(BaiTapCuaBaiHocBUSMock.selectBaiTapCuaBaiHocByID(new int()), Is.Not.Null);

            //TODO Write this test

        }

        [Test]
        public void selectAllBaiTapCuaBaiHocByIDBaiHocTest()
        {
            Assert.That(BaiTapCuaBaiHocBUSMock.selectAllBaiTapCuaBaiHocByIDBaiHoc(new int()), Is.Not.Null);

            //TODO Write this test

        }

        [Test]
        public void selectBaiTapCuaBaiHocByIDBaiHocTest()
        {
            Assert.That(BaiTapCuaBaiHocBUSMock.selectBaiTapCuaBaiHocByID(new int()), Is.Not.Null);
            //TODO Write this test

        }

        [Test]
        public void selectBaiTapCuaBaiHocByIDBaiHoc2Test()
        {
            Assert.That(BaiTapCuaBaiHocBUSMock.selectBaiTapCuaBaiHocByIDBaiHoc2(new int()), Is.Not.Null);
            //TODO Write this test

        }

      
    }
}
