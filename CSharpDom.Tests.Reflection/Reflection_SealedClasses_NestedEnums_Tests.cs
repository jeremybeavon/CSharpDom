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
            TestSealedClass(typeof(SealedClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithInternalNestedEnumUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestSealedClassWithPrivateNestedEnumUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedNestedEnumUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedInternalNestedEnumUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public void TestSealedClassWithPublicNestedEnumUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithPublicNestedEnum));
        }
    }
}
