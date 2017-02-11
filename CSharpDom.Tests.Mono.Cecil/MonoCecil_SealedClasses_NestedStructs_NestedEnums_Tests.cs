using CSharpDom.TestTarget.SealedClasses.NestedStructs.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_NestedStructs_NestedEnums_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedStructWithNestedEnumWith1AttributeUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithNestedEnumWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithInternalNestedEnumUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithPrivateNestedEnumUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithPublicNestedEnumUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithPublicNestedEnum));
        }
    }
}
