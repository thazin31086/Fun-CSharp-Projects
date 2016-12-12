using System.Diagnostics;

namespace CSharp.Class.Lib
{
    [DebuggerDisplay("Person name : {Name}, Age : {Age} years old")]
    public class PersonWithDebuggerDisplay
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
