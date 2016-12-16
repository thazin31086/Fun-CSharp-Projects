using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.Class.Lib.Tests
{
    [TestClass()]
    public class VendorRepositoryTests
    {
        [TestMethod()]
        public void RetrieveTest()
        {
            //Arrange 
            var repository = new VendorRepository();
            var expected = new List<Vendor>();
            expected.Add(new Vendor()
            {
                VendorId = 1,
                CompanyName = "ABC Corp",
                Email = "abc@abc.com"
            });

            expected.Add(new Vendor()
            {
                VendorId = 2,
                CompanyName = "BCD Corp",
                Email = "bcd@bcd.com"
            });

            //Act
            var actual = repository.Retrieve();

            //Assert

            CollectionAssert.Equals(expected, actual);
        }

        [TestMethod()]
        public void RetrieveWithKeysTest()
        {
            //Arrange 
            var repository = new VendorRepository();
            var expected = new Dictionary<string, Vendor>()
            {
               { "ABC Corp", new Vendor()
                     {VendorId = 5, CompanyName= "ABC Corp", Email="abc@abc.com" }},

                { "BCD Corp", new Vendor()
                     {VendorId = 5, CompanyName= "BCD Corp", Email="bcd@bcd.com" }}
            };

            //Act
            var actual = repository.RetrieveWithKeys();

            //Assert 
            CollectionAssert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void RetrieveAllTest()
        {
            //Arrage
            var repository = new VendorRepository();
            var expected = new List<Vendor>()
            {
               { new Vendor()
                     {VendorId = 1, CompanyName= "ABC Corp", Email="abc@abc.com" }},
               { new Vendor()
                     {VendorId = 2, CompanyName= "BCD Corp", Email="bcd@bcd.com" }},
               { new Vendor()
                     {VendorId = 3, CompanyName= "CDE Corp", Email="cde@cde.com" }},
               { new Vendor()
                     {VendorId = 4, CompanyName= "EFG Corp", Email="efg@efg.com" }},
               { new Vendor()
                     {VendorId = 5, CompanyName= "GHI Corp", Email="ghi@ghi.com" }}

            };

            //Act 
            var vendors = repository.RetrieveAll();
            //var vendorQuery = from v in vendors
            //                  where v.CompanyName.Contains("Corp")
            //                  orderby v.CompanyName
            //                  select v;


            //var vendorQuery = vendors.Where(FilterCompanies)
            //                         .OrderBy(OrderCompanies);


            var vendorQuery = vendors.Where(v=> v.CompanyName.Contains("Corp"))
                                     .OrderBy(v=> v.CompanyName);
            //Assert
            CollectionAssert.AreEqual(expected, vendorQuery.ToList());
        }

        //private bool FilterCompanies(Vendor v)
        //{
        //    return v.CompanyName.Contains("Corp"); 
        //}

            /// <summary>
            /// C# 6 Feature
            /// </summary>
            /// <param name="v"></param>
            /// <returns></returns>
        //private bool FilterCompanies(Vendor v) =>
        //    v.CompanyName.Contains("Corp");


        //private string OrderCompanies(Vendor v) =>
        //   v.CompanyName;
    }
}