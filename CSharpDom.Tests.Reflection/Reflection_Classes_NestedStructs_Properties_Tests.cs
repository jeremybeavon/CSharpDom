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
            TestClassAsync(typeof(ClassWithNestedStructWithInternalProperty));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPrivatePropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithPrivateProperty));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPublicPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithPublicProperty));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithStaticPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithStaticProperty));
        }
    }
}
