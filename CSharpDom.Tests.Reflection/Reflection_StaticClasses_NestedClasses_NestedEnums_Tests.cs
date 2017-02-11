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
            TestStaticClass(typeof(StaticClassWithNestedClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithInternalNestedEnumUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPrivateNestedEnumUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedNestedEnumUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedInternalNestedEnumUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPublicNestedEnumUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithPublicNestedEnum));
        }
    }
}
