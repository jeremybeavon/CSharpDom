using CSharpDom.TestTarget.Structs.NestedAbstractClasses.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedAbstractClasses_NestedEnums_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedEnumWith1AttributeUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithInternalNestedEnumUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPrivateNestedEnumUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedNestedEnumUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedInternalNestedEnumUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPublicNestedEnumUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithPublicNestedEnum));
        }
    }
}
