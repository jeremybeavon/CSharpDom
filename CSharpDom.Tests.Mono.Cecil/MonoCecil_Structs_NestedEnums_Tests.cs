using CSharpDom.TestTarget.Structs.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedEnums_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithNestedEnumWith1AttributeUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedEnumWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithInternalNestedEnumUsingMonoCecil()
        {
            TestStruct(typeof(StructWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestStructWithPrivateNestedEnumUsingMonoCecil()
        {
            TestStruct(typeof(StructWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestStructWithPublicNestedEnumUsingMonoCecil()
        {
            TestStruct(typeof(StructWithPublicNestedEnum));
        }
    }
}
