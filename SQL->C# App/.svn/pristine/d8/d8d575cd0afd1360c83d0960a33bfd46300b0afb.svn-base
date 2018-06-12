using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class KwerendyToMyProduct
    {
        public static List<MyProduct> GetProductsByName(string namePart)
        {
            List<MyProduct> list = new List<MyProduct>();
            DataClasses1DataContext data = new DataClasses1DataContext();
            foreach (Product item in data.Product)
            {
                list.Add(new MyProduct(item));
            }

            List<MyProduct> products = (
                from p in list
                where p.Name == namePart
                select p).ToList();
            return products;
        }

        public static List<Product> GetProductsWithNRecentReviews(int howManyReviews)
        {
            List<MyProduct> list = new List<MyProduct>();
            DataClasses1DataContext data = new DataClasses1DataContext();
            foreach (Product item in data.Product)
            {
                list.Add(new MyProduct(item));
            }
            List<Product> products = (
                from p in data.ProductReview
                orderby p.ReviewDate
                select p.Product).ToList();

            List<Product> list2 = new List<Product>();

            for (int i = products.Count - 1; i >= (products.Count - howManyReviews); i--)
            {
                list2.Add(products[i]);
            }

            return list2;

        }
        public static List<Product> GetProductsByVendorName(string vendorName)
        {
            List<MyProduct> list = new List<MyProduct>();
            DataClasses1DataContext data = new DataClasses1DataContext();
            foreach (Product item in data.Product)
            {
                list.Add(new MyProduct(item));
            }
            var list1 = from produkt in data.GetTable<Product>()
                       from vendor in data.GetTable<Vendor>()
                       from productVendor in data.GetTable<ProductVendor>()
                       where produkt.ProductID == productVendor.ProductID && productVendor.BusinessEntityID == vendor.BusinessEntityID
                           && vendor.Name == vendorName
                       select produkt;
            return list1.ToList();
        }
    }
}
