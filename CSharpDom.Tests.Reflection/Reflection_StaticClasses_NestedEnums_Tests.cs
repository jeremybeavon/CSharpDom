using CSharpDom.TestTarget.StaticClasses.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedEnums_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedEnumWith1AttributeUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithInternalNestedEnumUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestStaticClassWithPrivateNestedEnumUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestStaticClassWithProtectedNestedEnumUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public void TestStaticClassWithProtectedInternalNestedEnumUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public void TestStaticClassWithPublicNestedEnumUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithPublicNestedEnum));
        }
    }
}
