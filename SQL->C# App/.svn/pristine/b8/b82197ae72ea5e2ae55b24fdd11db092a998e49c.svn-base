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
    public class KwerendyTests
    {
        [TestMethod()]
        public void GetProductsByNameTest()
        {
            Assert.AreEqual(1, Kwerendy.GetProductsByName("Lock Nut 5").Count());
        }

        [TestMethod()]
        public void GetProductsByVendorNameTest()
        {
            Assert.AreEqual(1, Kwerendy.GetProductsByVendorName("Allenson Cycles").Count());
        }

        [TestMethod()]
        public void GetProductNamesByVendorNameTest()
        {
            List<string> list = Kwerendy.GetProductNamesByVendorName("American Bikes");
            Assert.AreEqual("HL Road Rim", list[0]);
        }

        [TestMethod()]
        public void GetProductsWithNRecentReviewsTest()
        {
            Assert.AreEqual(2, Kwerendy.GetProductsWithNRecentReviews(2).Count());
        }

        [TestMethod()]
        public void GetNRecentlyReviewedProductsTest()
        {
            Assert.AreEqual(2, Kwerendy.GetNRecentlyReviewedProducts(2).Count());
        }

        [TestMethod()]
        public void GetNProductsFromCategoryTest()
        {
            Assert.AreEqual(15, Kwerendy.GetNProductsFromCategory("Bikes", 15).Count);
        }

        [TestMethod()]
        public void GetTotalStandardCostByCategoryTest()
        {
            ProductCategory productCategory = new ProductCategory();
            productCategory.ProductCategoryID = 1;
            Assert.AreEqual(153902, Kwerendy.GetTotalStandardCostByCategory(productCategory));
        }

        [TestMethod()]
        public void GetProductsWithNoCategoryTest()
        {
            Assert.AreEqual(209,Kwerendy.GetProductsWithNoCategory().Count());
        }

        [TestMethod()]
        public void GetPageTest()
        {
            List<Product> list = Kwerendy.GetPage(3, 5);
            Assert.AreEqual("Decal 1", list[1].Name);
        }

        [TestMethod()]
        public void GetProductAndVendorNamesTest()
        {
            List<Product> list = Kwerendy.GetPage(1, 1);
           // Assert.AreEqual("Adjustable Race - Litware, Inc.", Kwerendy.GetProductAndVendorNames(list));
        }
    }
}