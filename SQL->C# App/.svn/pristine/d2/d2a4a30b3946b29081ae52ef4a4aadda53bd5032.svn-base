using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class MyProduct
    {
        public int _ProductID { get; set; }
        public string Name { get; set; }
        public string _ProductNumber { get; set; }
        public bool _MakeFlag { get; set; }
        public bool _FinishedGoodsFlag { get; set; }
        public string _Color { get; set; }
        public short _SafetyStockLevel { get; set; }
        public short _ReorderPoint { get; set; }
        public decimal _StandardCost { get; set; }
        public decimal _ListPrice { get; set; }
        public string _Size { get; set; }
        public string _SizeUnitMeasureCode { get; set; }
        public string _WeightUnitMeasureCode { get; set; }
        public System.Nullable<decimal> _Weight { get; set; }
        public int _DaysToManufacture { get; set; }
        public string _ProductLine { get; set; }
        public string _Class { get; set; }
        public string _Style { get; set; }
        public System.Nullable<int> _ProductSubcategoryID { get; set; }
        public System.Nullable<int> _ProductModelID { get; set; }
        public System.DateTime _SellStartDate { get; set; }
        public System.Nullable<System.DateTime> _SellEndDate { get; set; }
        public System.Nullable<System.DateTime> _DiscontinuedDate { get; set; }
        public System.Guid _rowguid { get; set; }
        public System.DateTime _ModifiedDate { get; set; }
        public string VendorName { get; set; }
        public EntitySet<ProductVendor> _ProductVendor { get; set; }

        public MyProduct(Product product)
        {
            _ProductID = product.ProductID;
            Name = product.Name;
            _ProductNumber = product.ProductNumber;
            _MakeFlag = product.MakeFlag;
            _FinishedGoodsFlag = product.FinishedGoodsFlag;
            _Color = product.Color;
            _SafetyStockLevel = product.SafetyStockLevel;
            _ReorderPoint = product.ReorderPoint;
            _StandardCost = product.StandardCost;
            _ListPrice = product.ListPrice;
            _Size = product.Size;
            _SizeUnitMeasureCode = product.SizeUnitMeasureCode;
            _WeightUnitMeasureCode = product.WeightUnitMeasureCode;
            System.Nullable<decimal> _Weight = product.Weight;
            _DaysToManufacture = product.DaysToManufacture;
            _ProductLine = product.ProductLine;
            _Class = product.Class;
            _Style = product.Style;
            System.Nullable<int> _ProductSubcategoryID = product.ProductSubcategoryID;
            System.Nullable<int> _ProductModelID = product.ProductModelID;
            System.DateTime _SellStartDate = product.SellStartDate;
            System.Nullable<System.DateTime> _SellEndDate = product.SellEndDate;
            System.Nullable<System.DateTime> _DiscontinuedDate = product.DiscontinuedDate;
            System.Guid _rowguid = product.rowguid;
            System.DateTime _ModifiedDate = product.ModifiedDate;
            _ProductVendor = product.ProductVendor;
        }


    }
}
