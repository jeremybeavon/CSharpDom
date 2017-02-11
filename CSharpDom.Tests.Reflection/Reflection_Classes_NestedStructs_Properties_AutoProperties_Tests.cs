using CSharpDom.TestTarget.Classes.NestedStructs.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedStructs_Properties_AutoProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithNestedStructWithInternalAutoPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPrivateAutoPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPublicAutoPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithStaticAutoPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithStaticAutoProperty));
        }
    }
}
