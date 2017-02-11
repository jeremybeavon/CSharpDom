using CSharpDom.TestTarget.Structs.NestedSealedClasses.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedSealedClasses_NestedEnums_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithNestedSealedClassWithNestedEnumWith1AttributeUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithInternalNestedEnumUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPrivateNestedEnumUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedNestedEnumUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedInternalNestedEnumUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPublicNestedEnumUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithPublicNestedEnum));
        }
    }
}
