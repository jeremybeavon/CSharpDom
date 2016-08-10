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
            TestSealedClassAsync(typeof(SealedClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithInternalNestedEnumUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestSealedClassWithPrivateNestedEnumUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedNestedEnumUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedInternalNestedEnumUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public void TestSealedClassWithPublicNestedEnumUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithPublicNestedEnum));
        }
    }
}
