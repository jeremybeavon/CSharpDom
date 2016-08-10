using CSharpDom.TestTarget.SealedClasses.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedEnums_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedEnumWith1AttributeUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithInternalNestedEnumUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestSealedClassWithPrivateNestedEnumUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedNestedEnumUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedInternalNestedEnumUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public void TestSealedClassWithPublicNestedEnumUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithPublicNestedEnum));
        }
    }
}
