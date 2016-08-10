using CSharpDom.TestTarget.StaticClasses.NestedClasses.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedClasses_NestedEnums_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedClassWithNestedEnumWith1AttributeUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithInternalNestedEnumUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPrivateNestedEnumUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedNestedEnumUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedInternalNestedEnumUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPublicNestedEnumUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPublicNestedEnum));
        }
    }
}
