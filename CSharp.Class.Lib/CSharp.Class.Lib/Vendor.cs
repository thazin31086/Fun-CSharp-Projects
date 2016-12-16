using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Class.Lib
{
    public class Vendor
    {
        public int VendorId { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"Vendor: { this.CompanyName} ({ this.VendorId})";
        }

        /// <summary>
        /// Overriden to support comparison
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
                return false;

            Vendor compareVendor = obj as Vendor;
            if (compareVendor != null &&
                this.VendorId == compareVendor.VendorId &&
                this.CompanyName == compareVendor.CompanyName &&
                this.Email == compareVendor.Email)
                return true; 
             
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
