using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Tests
{
    [TestClass()]
    public class KwerendyToMyProductTests
    {
        [TestMethod()]
        public void GetProductsByNameTest()
        {
            Assert.AreEqual(1,KwerendyToMyProduct.GetProductsByName("Lock Nut 5").Count());
        }

        [TestMethod()]
        public void GetProductsWithNRecentReviewsTest()
        {
            Assert.AreEqual(2,KwerendyToMyProduct.GetProductsWithNRecentReviews(2).Count());
        }

        [TestMethod()]
        public void GetProductsByVendorNameTest()
        {
            Assert.AreEqual(1, KwerendyToMyProduct.GetProductsByVendorName("Allenson Cycles").Count());
        }
    }
}