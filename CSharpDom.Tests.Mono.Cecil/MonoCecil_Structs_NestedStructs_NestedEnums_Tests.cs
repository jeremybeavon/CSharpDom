using CSharpDom.TestTarget.Structs.NestedStructs.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedStructs_NestedEnums_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithNestedStructWithNestedEnumWith1AttributeUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedEnumWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithInternalNestedEnumUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPrivateNestedEnumUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPublicNestedEnumUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithPublicNestedEnum));
        }
    }
}
