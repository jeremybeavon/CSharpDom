using CSharpDom.TestTarget.Structs.NestedClasses.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedClasses_NestedEnums_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithNestedClassWithNestedEnumWith1AttributeUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithInternalNestedEnumUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPrivateNestedEnumUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedNestedEnumUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedInternalNestedEnumUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPublicNestedEnumUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPublicNestedEnum));
        }
    }
}
