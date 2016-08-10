using CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedStaticClasses_NestedEnums_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithNestedEnumWith1AttributeUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithInternalNestedEnumUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithPrivateNestedEnumUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithProtectedNestedEnumUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithProtectedInternalNestedEnumUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithPublicNestedEnumUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithPublicNestedEnum));
        }
    }
}
