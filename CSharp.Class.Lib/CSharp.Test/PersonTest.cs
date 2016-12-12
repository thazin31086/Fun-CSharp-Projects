using CSharp.Class.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp.Test
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void PersonWithDebuggerDisplayTest()
        {
            var p = new PersonWithDebuggerDisplay
            {
                Name = "Susan",
                Age = 45
            };           
        }
}
}
