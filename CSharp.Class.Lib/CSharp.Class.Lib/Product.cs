using System;
using System.Collections.Generic;

/// <summary>
/// Generic List Exercise
/// </summary>
namespace CSharp.Class.Lib
{
    public class Product
    {
        public Product()
        {
            #region Generic List
            var coloroptions = new List<string>() { "Red", "Expresso", "White", "Navy" };
            //coloroptions.Add("Red");
            //coloroptions.Add("Expresso");
            //coloroptions.Add("White");
            //coloroptions.Add("Navy");

            coloroptions.Insert(2, "Purple");
            coloroptions.Remove("White");
            Console.WriteLine(coloroptions);
            #endregion Generic List

            #region Dictionary 
            //var states = new Dictionary<string, string>();
            //states.Add("NSW", "New South");
            //states.Add("SA", "South Australia");
            //states.Add("WA", "Western Australia");
            //states.Add("NT", "Nothern Terriory");
            //states.Add("TAS", "Tasmania");
            //states.Add("QLD", "Queensland");

            var states = new Dictionary<string, string>()
            {
                { "NSW", "New South"},
                { "SA", "South Australia"},
                { "WA", "Western Australia"},
                { "NT", "Nothern Terriory"},
                { "TAS", "Tasmania" },
                { "QLD", "Queensland"}
            };

            Console.WriteLine(states);
            #endregion Dictionary
        }

        public Product(int productid, string productname, string productdescription) : this()
        {
            this.productId = productId;
            this.productname = productname;
            this.productdescription = productdescription;
        }

        #region Properties
        public int productId { get; set; }
        public string productname { get; set; }
        public string productdescription { get; set; }
        #endregion
    }
}
