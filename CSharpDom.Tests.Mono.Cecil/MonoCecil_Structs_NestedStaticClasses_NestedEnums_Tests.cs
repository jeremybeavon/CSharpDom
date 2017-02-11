using CSharpDom.TestTarget.Structs.NestedStaticClasses.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedStaticClasses_NestedEnums_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithNestedStaticClassWithNestedEnumWith1AttributeUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStaticClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStaticClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithInternalNestedEnumUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStaticClassWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithPrivateNestedEnumUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStaticClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithProtectedNestedEnumUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStaticClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithProtectedInternalNestedEnumUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStaticClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithPublicNestedEnumUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStaticClassWithPublicNestedEnum));
        }
    }
}
