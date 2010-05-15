using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NUnit.Mocks;
namespace BUSTest
{

    [TestFixture]
    public class MonHocBUSTests
    {

        [Test]
        public void insertMonHocTest()
        {
            Assert.That(MonHocBUSMock.insertMonHoc(new Dto.MonHocDTO()), Is.True);
            //TODO Write this test

        }

        [Test]
        public void deleteMonHocTest()
        {
            Assert.That(MonHocBUSMock.deleteMonHoc(new Dto.MonHocDTO().TenMonHoc), Is.False);
            //TODO Write this test

        }

        [Test]
        public void updateMonHocTest()
        {
            Assert.That(MonHocBUSMock.updateMonHoc(new Dto.MonHocDTO()), Is.True);
            //TODO Write this test

        }

        [Test]
        public void selectAllMonHocTest()
        {
            Assert.That(MonHocBUSMock.selectAllMonHoc(), Is.Not.Null);
            //TODO Write this test

        }

        [Test]
        public void selectMonHocByIDMonHocTest()
        {
            Assert.That(MonHocBUSMock.selectMonHocByIDMonHoc(new int()), Is.Null);
            //TODO Write this test

        }

    
    }
}
