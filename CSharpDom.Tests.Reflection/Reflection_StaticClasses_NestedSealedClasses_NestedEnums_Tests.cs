using CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedSealedClasses_NestedEnums_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithNestedEnumWith1AttributeUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithInternalNestedEnumUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithPrivateNestedEnumUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithProtectedNestedEnumUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithProtectedInternalNestedEnumUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithPublicNestedEnumUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithPublicNestedEnum));
        }
    }
}
