using System;
using System.Collections.Generic;
using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace testLatest
{
    [TestClass]
    public class DynamicDataTest
    {
        public static IEnumerable<object[]> TestCasesClass1()
        {
            yield return new object[] { new Class1("1",1,new DateTime(1, 1, 1))};
        }

        [DynamicData(nameof(TestCasesClass1), typeof(DynamicDataTest), DynamicDataSourceType.Method)]
        [DataTestMethod]
        public void TestDynamicDataClass1(Class1 item)
        {
            Assert.AreEqual(new DateTime(1, 1, 1), item.Date);
            Assert.AreEqual(1, item.Num);
            Assert.AreEqual("1", item.Str);
        }

        public static IEnumerable<object[]> TestCasesClass2()
        {
            yield return new object[] { new Class2("1", 1, new DateTime(1, 1, 1)) };
        }

        [DynamicData(nameof(TestCasesClass2), typeof(DynamicDataTest), DynamicDataSourceType.Method)]
        [DataTestMethod]
        public void TestDynamicDataClass2(Class2 item)
        {
            Assert.AreEqual(new DateTime(1, 1, 1), item.Date);
            Assert.AreEqual(1, item.Num);
            Assert.AreEqual("1", item.Str);
        }
    }
}