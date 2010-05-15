using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NUnit.Mocks;
using Dao;
using System.Collections;
namespace BUSTest
{
    [TestFixture]
    public class AccountBUSTests
    {

        [Test]
        public void insertAccountTest()
        {
          
            Assert.That(AccountBUSMock.insertAccount(new Dto.AccountDTO()),Is.False);

            //TODO Write this test

        }

        [Test]
        public void deleteAccountTest()
        {
            Assert.That(AccountBUSMock.deleteAccount(new Dto.AccountDTO().IDAcc), Is.True);

            //TODO Write this test

        }

        [Test]
        public void updateAccountTest()
        {
            Assert.That(AccountBUSMock.updateAccount(new Dto.AccountDTO()),Is.True);
            //TODO Write this test

        }

        [Test]
        public void selectAllAccountTest()
        {
            
              Assert.That(AccountBUSMock.selectAllAccount(),Is.EqualTo(new Dto.AccountDTO()));
            //TODO Write this test

        }

        [Test]
        public void selectAccountByLACTest()
        {
            //TODO Write this test
            Assert.That(AccountBUSMock.selectAccountByLAC(new Dto.AccountDTO().IDLoaiAcc), Is.EqualTo(new Dto.AccountDTO()));

        }

        [Test]
        public void selectAccountByIDACTest()
        {
            Assert.That(AccountBUSMock.selectAccountByIDAC(new Dto.AccountDTO().IDAcc), Is.EqualTo(new Dto.AccountDTO()));
            //TODO Write this test

        }

        [Test]
        public void selectAccountByEmailTest()
        {
            Assert.That(AccountBUSMock.selectAccountByEmail(new Dto.AccountDTO().Email), Is.EqualTo(new Dto.AccountDTO()));
            //TODO Write this test

        }

     
    }
}
