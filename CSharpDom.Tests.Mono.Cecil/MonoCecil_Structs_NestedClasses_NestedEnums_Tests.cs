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
            TestStruct(typeof(StructWithNestedClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithInternalNestedEnumUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPrivateNestedEnumUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedNestedEnumUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedInternalNestedEnumUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPublicNestedEnumUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithPublicNestedEnum));
        }
    }
}
