using CSharpDom.TestTarget.SealedClasses.NestedClasses.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedClasses_NestedEnums_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedClassWithNestedEnumWith1AttributeUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithInternalNestedEnumUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPrivateNestedEnumUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedNestedEnumUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedInternalNestedEnumUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPublicNestedEnumUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPublicNestedEnum));
        }
    }
}
