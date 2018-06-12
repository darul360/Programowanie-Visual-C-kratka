using System;
using Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository;

namespace CRUD_Api_Test
{
    [TestClass]
    public class CRUD_Api_Test
    {
        [TestMethod]
        public void TestAdding() 
        {
            ApiCatalyst apc = new ApiCatalyst();
            DateTime date = new DateTime(2008, 11, 3);
            apc.CatalystAddCard("Test", "TestNumber", 10, 2021, date);

            object card = apc.GetCard("TestNumber");
            CreditCard actualyType = (CreditCard)card;
            Assert.AreEqual("TestNumber", actualyType.CardNumber);
            apc.CatalystDeleteCard("TestNumber");

        }

        [TestMethod]
        public void TestDeleting() 
        {
            ApiCatalyst apc = new ApiCatalyst();
            DateTime date = new DateTime(2008, 11, 3);

            //DODAWANIA KARTY + TEST
            apc.CatalystAddCard("Test2", "TestNumber2", 10, 2021, date);
            object card = apc.GetCard("TestNumber2");
            CreditCard actualyType = (CreditCard)card;
            Assert.AreEqual("TestNumber2", actualyType.CardNumber);

            //USUWANIE KARTY + TEST
            apc.CatalystDeleteCard("TestNumber2");
            object card2 = apc.GetCard("TestNumber2");
            Assert.AreEqual(null, card2);
        }

        [TestMethod]
        public void TestUpdate()
        {
            ApiCatalyst apc = new ApiCatalyst();
            DateTime date = new DateTime(2008, 11, 3);

            //DODAWANIA KARTY + TEST
            apc.CatalystAddCard("Test3", "TestNumber3", 10, 2021, date);
                object card = apc.GetCard("TestNumber3");
                CreditCard actualyType = (CreditCard)card;
                    Assert.AreEqual("TestNumber3", actualyType.CardNumber);

            //UPDATE+TEST
            apc.UpdateCardType("TestNumber3", "RandomType");
                object card2 = apc.GetCard("TestNumber3");
                    CreditCard actualyTypeUp = (CreditCard)card2;
                        Assert.AreEqual("RandomType", actualyTypeUp.CardType);

            apc.CatalystDeleteCard("TestNumber3");
        }

        [TestMethod]
        public void TestRead()
        {
            ApiCatalyst apc = new ApiCatalyst();
            DateTime date = new DateTime(2008, 11, 3);
            //DODAWANIA KARTY + TEST
            apc.CatalystAddCard("Test4", "TestNumber4", 10, 2021, date);
            object card = apc.GetCard("TestNumber4");
            CreditCard actualyType = (CreditCard)card;
            Assert.AreEqual("TestNumber4", actualyType.CardNumber);

            //GET+TEST
            object card2 = apc.GetCard("TestNumber4");
            CreditCard actualyTypeGet = (CreditCard)card2;
            Assert.AreEqual("Test4", actualyTypeGet.CardType);

            apc.CatalystDeleteCard("TestNumber4");
        }

    }
}
