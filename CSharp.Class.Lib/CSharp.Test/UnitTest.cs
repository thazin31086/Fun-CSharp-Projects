using CSharp.Class.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Threading;

namespace CSharp.Test
{
    [TestClass]
    public class UnitTest
    {
        public object Alignment { get; private set; }

        [TestMethod]
        public void PersonWithDebuggerDisplayTest()
        {
            var p = new PersonWithDebuggerDisplay
            {
                Name = "Susan",
                Age = 45
            };
        }

        [TestMethod]
        public void Null_Coalescing_OperatorTest()
        {
            int? localdefaultage = null;
            int globaldefaultage = 56;
            int? age = null;

            int result = age ?? localdefaultage ?? globaldefaultage;
        }

        [TestMethod]
        public void TypeTestingTest()
        {
            Type targetType;
            Type convertedType;

            object convertedValue;
            object initialValue;

            initialValue = "99";

            targetType = typeof(int);
            convertedValue = Convert.ChangeType(initialValue, targetType);
            convertedType = convertedValue.GetType();

            targetType = typeof(double);
            convertedValue = Convert.ChangeType(initialValue, targetType);
            convertedType = convertedValue.GetType();
        }


        [TestMethod]
        public void ExampleInternalTest()
        {
            var p = new PersonInternal();
            p.Hello();
            p.World();
        }


        /// <summary>
        /// Conditional Preprocessor Directives
        /// </summary>
        [TestMethod]
        public void ConditionalDirectivesTest()
        {
#warning Random Warning Message
            string s = null;

#if DEBUG && RELEASE
    #error "Error"

#elif RELEASE
            s = "release";
#else
            s= "some other build (catchall else block)";
#endif
        }


        [TestMethod]
        public void CultureInfoTest()
        {
            const string australiaCultureString = "en-AU";
            const string turkeyCultureString = "tr-TR";            
            const double somenum = 23.45;

            Debug.WriteLine("Setting English");
            var ausInfo = CultureInfo.GetCultureInfo(australiaCultureString);
            Thread.CurrentThread.CurrentCulture = ausInfo;
            var aupper = "i".ToUpper();

            Debug.WriteLine(somenum);
            Debug.WriteLine(aupper);
            Debug.WriteLine(DateTime.Now);

            Debug.WriteLine("Setting Turkey");
            var tuInfo = CultureInfo.GetCultureInfo(turkeyCultureString);
            Thread.CurrentThread.CurrentCulture = tuInfo;
            var tupper = "i".ToUpper();

            Debug.WriteLine(somenum);
            Debug.WriteLine(tupper);
            Debug.WriteLine(DateTime.Now);
        }


        [TestMethod]
        public void RandomNumTest()
        {
            var r1 = new Random();

            for (int i = 0 ; i < 5; i++)
            {
                Debug.WriteLine(r1.Next());
            }
        }

        [TestMethod]
        public void UsingTuplesAsCompoundDictionary()
        {
            var t1 = Tuple.Create(1, "a");
            var t2 = Tuple.Create(2, "b");
            var t3 = Tuple.Create(3, "c");

            var d = new SortedDictionary<Tuple<int, string>, string>();

            d.Add(t1, "t1");
            d.Add(t2, "t2");
            d.Add(t3, "t3");

            foreach (var item in d)
            {
                Debug.WriteLine(item);
            }
        }


        [TestMethod]
        public void CombineEnumTest()
        {
            //bitwise OR operator
            var topRight = FlagsEnumExample.Alignments.Top | FlagsEnumExample.Alignments.Right;
            var bottomLeft = FlagsEnumExample.Alignments.Bottom | FlagsEnumExample.Alignments.Left;

            var isTopIncluded = (topRight & FlagsEnumExample.Alignments.Top) != 0;
            isTopIncluded = topRight.HasFlag(FlagsEnumExample.Alignments.Top);

            var all = topRight | bottomLeft;

            //Toggle Values
            all ^= FlagsEnumExample.Alignments.Top;
            all ^= FlagsEnumExample.Alignments.Top;
        }


        [TestMethod]
        public void GenericListTest()
        {
            Product p = new Product(1, "Shirt", "Summer Shirt");
        }


    }
}

[TestClass]
public class FlagsEnumExample
{
    [Flags]
    public enum Alignments
    {
        None = 0,
        Top = 1,
        Right = 2,
        Bottom = 4,
        Left = 8
    }
}


