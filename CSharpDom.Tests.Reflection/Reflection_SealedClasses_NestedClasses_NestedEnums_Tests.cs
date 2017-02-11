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
            TestSealedClass(typeof(SealedClassWithNestedClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithInternalNestedEnumUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPrivateNestedEnumUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedNestedEnumUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedInternalNestedEnumUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPublicNestedEnumUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithPublicNestedEnum));
        }
    }
}
