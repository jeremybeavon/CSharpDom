using CSharpDom.TestTarget.SealedClasses.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_NestedEnums_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedEnumWith1AttributeUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithInternalNestedEnumUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestSealedClassWithPrivateNestedEnumUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedNestedEnumUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedInternalNestedEnumUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public void TestSealedClassWithPublicNestedEnumUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithPublicNestedEnum));
        }
    }
}
