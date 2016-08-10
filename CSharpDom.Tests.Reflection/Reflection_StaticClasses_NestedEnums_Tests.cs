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
            TestStaticClassAsync(typeof(StaticClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithInternalNestedEnumUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestStaticClassWithPrivateNestedEnumUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestStaticClassWithProtectedNestedEnumUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public void TestStaticClassWithProtectedInternalNestedEnumUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public void TestStaticClassWithPublicNestedEnumUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithPublicNestedEnum));
        }
    }
}
