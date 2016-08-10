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
            TestStructAsync(typeof(StructWithNestedStaticClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithInternalNestedEnumUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithPrivateNestedEnumUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithProtectedNestedEnumUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithProtectedInternalNestedEnumUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithPublicNestedEnumUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithPublicNestedEnum));
        }
    }
}
