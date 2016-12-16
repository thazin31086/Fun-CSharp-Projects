using System;
using System.Collections.Generic;

namespace CSharp.Class.Lib
{
    public class VendorRepository
    {
        private List<Vendor> vendors;


        public List<Vendor> Retrieve()
        {
            if (vendors == null)
            {
                vendors = new List<Vendor>();

                vendors.Add(new Vendor()
                {
                    VendorId = 1,
                    CompanyName = "ABC Corp",
                    Email = "abc@abc.com"
                });

                vendors.Add(new Vendor()
                {
                    VendorId = 2,
                    CompanyName = "BCD Corp",
                    Email = "bcd@bcd.com"
                });
            }

            //Output List Type
            //Console.WriteLine(vendors[1]);

            for (int i = 0; i < vendors.Count; i++)
            {
                Console.WriteLine(vendors[i].ToString().ToUpper());
            }
            foreach (var vendor in vendors)
            {  
                Console.WriteLine(vendor);
            }
            return vendors;
        }

        public Dictionary<string, Vendor> RetrieveWithKeys()
        {
            var vendors = new Dictionary<string, Vendor>()
            {
                { "ABC Corp", new Vendor()
                     {VendorId = 5, CompanyName= "ABC Corp", Email="abc@abc.com" }},

                { "BCD Corp", new Vendor()
                     {VendorId = 5, CompanyName= "BCD Corp", Email="bcd@bcd.com" }}
            };

            //Console.WriteLine(vendors["BCD Corp"]);
            //if (vendors.ContainsKey("bcd Corp"))
            //{
            //    Console.WriteLine(vendors["BCD Corp"]);
            //}

            //Best Practise for Finding By key
            //Vendor vendor;
            //if (vendors.TryGetValue("BCD Corp", out vendor))
            //{
            //    Console.WriteLine(vendor);
            //}

            //Loop by keys
            //foreach (var companyName in vendors.Keys)
            //{
            //    Console.WriteLine(companyName);
            //    Console.WriteLine(vendors[companyName]);
            //}

            //Loop By Values
            //foreach (var vendor in vendors.Values)
            //{
            //    Console.WriteLine(vendor);
            //}

            //Loop Dictonary 
            foreach (var element in vendors)
            {
                var vendor = element.Value;
                var key = element.Key;

                // String interpolation Syntax
                Console.WriteLine($"Key: {key} Value: {vendor}"); 
            }
            return vendors;
        }


        public IEnumerable<Vendor> RetrieveAll()
        {
            if (vendors == null)
            {
                vendors = new List<Vendor>();

                vendors.Add(new Vendor()
                {
                    VendorId = 1,
                    CompanyName = "ABC Corp",
                    Email = "abc@abc.com"
                });

                vendors.Add(new Vendor()
                {
                    VendorId = 2,
                    CompanyName = "BCD Corp",
                    Email = "bcd@bcd.com"
                });

                vendors.Add(new Vendor()
                {
                    VendorId = 3,
                    CompanyName = "CDE Corp",
                    Email = "cde@cde.com"
                });

                vendors.Add(new Vendor()
                {
                    VendorId = 4,
                    CompanyName = "EFG Corp",
                    Email = "efg@efg.com"
                });

                vendors.Add(new Vendor()
                {
                    VendorId = 5,
                    CompanyName = "GHI Corp",
                    Email = "ghi@ghi.com"
                });

            }
            return vendors;
        }
    }
}
