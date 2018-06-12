using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public static class Kwerendy
    {
        public static List<Product> GetProductsByName(string namePart)
        {
            DataClasses1DataContext dataClasses1DataContext = new DataClasses1DataContext();
            var list = dataClasses1DataContext.Product.Where(n => n.Name == namePart).ToList();
            return list;

        }

        public static List<Product> GetProductsByVendorName(string vendorName)
        {
            DataClasses1DataContext data = new DataClasses1DataContext();
            var list = from produkt in data.GetTable<Product>()
                    from vendor in data.GetTable<Vendor>()
                    from productVendor in data.GetTable<ProductVendor>()
                    where produkt.ProductID == productVendor.ProductID && productVendor.BusinessEntityID == vendor.BusinessEntityID
                        && vendor.Name == vendorName
                    select produkt;
            return list.ToList();
        }
        public static List<String> GetProductNamesByVendorName(string vendorName)
        {
            DataClasses1DataContext data = new DataClasses1DataContext();
            var list = from produkt in data.GetTable<Product>()
                    from vendor in data.GetTable<Vendor>()
                    from productVendor in data.GetTable<ProductVendor>()
                    where produkt.ProductID == productVendor.ProductID && productVendor.BusinessEntityID == vendor.BusinessEntityID
                        && vendor.Name == vendorName
                    select produkt.Name;
            return list.ToList();
        }

        public static string GetProductVendorByProductName(string productName)
        {
            DataClasses1DataContext data = new DataClasses1DataContext();
            var q = (from produkt in data.GetTable<Product>()
                     from vendor in data.GetTable<Vendor>()
                     from productVendor in data.GetTable<ProductVendor>()
                     where produkt.ProductID == productVendor.ProductID && productVendor.BusinessEntityID == vendor.BusinessEntityID
                         && produkt.Name == productName
                     select vendor.Name).ToList()[0];
            return q;
        }

        public static List<Product> GetProductsWithNRecentReviews(int howManyReviews)
        {
            DataClasses1DataContext data = new DataClasses1DataContext();

            List<Product> products = (
                from p in data.ProductReview
                orderby p.ReviewDate
                select p.Product).ToList();

            List<Product> list = new List<Product>();

            for (int i = products.Count - 1; i >= (products.Count - howManyReviews); i--)
            {
                list.Add(products[i]);
            }

            return list;

        }

        public static List<Product> GetNRecentlyReviewedProducts(int howManyProducts)
        {
            DataClasses1DataContext data = new DataClasses1DataContext();

            List<Product> products = (
                from p in data.ProductReview
                orderby p.ModifiedDate
                select p.Product).Distinct().ToList();

            List<Product> list = new List<Product>();
            for (int i = products.Count - 1; i >= (products.Count - howManyProducts); i--)
            {
                list.Add(products[i]);
            }
            return list;
        }

        public static List<Product> GetNProductsFromCategory(string categoryName, int n)
        {
            DataClasses1DataContext data = new DataClasses1DataContext();

            List<Product> list = (
                                from product in data.Product
                                from category in data.ProductCategory
                                from subcategory in data.ProductSubcategory
                                orderby product.Name
                                orderby category.Name
                                where category.ProductCategoryID == subcategory.ProductCategoryID &&
                                      product.ProductSubcategoryID == subcategory.ProductSubcategoryID
                                select product).Take(n).ToList();
            return list;

        }

        public static int GetTotalStandardCostByCategory(ProductCategory category)
        {
            DataClasses1DataContext data = new DataClasses1DataContext();

            int totalStandardCost = 0;

            List<Product> x = (
                from p in data.Product
                from s in data.ProductSubcategory
                where category.ProductCategoryID == s.ProductCategoryID
                where p.ProductSubcategoryID == s.ProductSubcategoryID
                select p).ToList();

            foreach (var p in x)
            {
                totalStandardCost += Convert.ToInt32(p.ListPrice);
            }

            return totalStandardCost;

        }

        public static List<Product> GetProductsWithNoCategory()
        {
            DataClasses1DataContext data = new DataClasses1DataContext();

            var products = (data.Product.Where(n => n.ProductSubcategoryID == null)).ToList();
            return products;

        }

        public static List<Product> GetPage(int size, int pageNumber)
        {
            DataClasses1DataContext data = new DataClasses1DataContext();

            List<Product> list = data.Product.OrderBy(a => a.ProductID).Skip(size * (pageNumber - 1)).Take(size).ToList();
            return list;
        }


        public static string GetProductAndVendorNames(this IEnumerable<Product> item)
        {
            DataClasses1DataContext data = new DataClasses1DataContext();

            var productAndVendor = item
                .Join(data.ProductVendor, p => p.ProductID, productVendor => productVendor.ProductID, (p, productVendor) => new { p, productVendor })
                .Join(data.Vendor, productVendor => productVendor.productVendor.BusinessEntityID, vendor => vendor.BusinessEntityID, (productVendor, vendor) => new { productVendor, vendor })
                .Select(produkt => produkt.productVendor.p.Name + " - " + produkt.vendor.Name);

            string pair = null;

            for (int i = 0; i < productAndVendor.Count(); i++)
            {
                pair += productAndVendor.ElementAt(i).ToString() + "\n";
            }
            return pair;
        }
    }
}
