using CSharpDom.TestTarget.Classes.NestedStructs.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedStructs_Properties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithNestedStructWithInternalPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithInternalProperty));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPrivatePropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithPrivateProperty));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPublicPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithPublicProperty));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithStaticPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithStaticProperty));
        }
    }
}
