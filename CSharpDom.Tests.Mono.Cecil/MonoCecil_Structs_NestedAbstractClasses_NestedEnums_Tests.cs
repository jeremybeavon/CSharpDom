using CSharpDom.TestTarget.Structs.NestedAbstractClasses.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedAbstractClasses_NestedEnums_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedEnumWith1AttributeUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithInternalNestedEnumUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPrivateNestedEnumUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedNestedEnumUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedInternalNestedEnumUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPublicNestedEnumUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithPublicNestedEnum));
        }
    }
}
