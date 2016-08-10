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
            TestStructAsync(typeof(StructWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedEnumWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithInternalNestedEnumUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestStructWithPrivateNestedEnumUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestStructWithPublicNestedEnumUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithPublicNestedEnum));
        }
    }
}
