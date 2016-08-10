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
            TestStructAsync(typeof(StructWithNestedStructWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedEnumWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithInternalNestedEnumUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPrivateNestedEnumUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPublicNestedEnumUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPublicNestedEnum));
        }
    }
}
