using CSharpDom.TestTarget.Structs.NestedStaticClasses.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedStaticClasses_NestedEnums_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedStaticClassWithNestedEnumWith1AttributeUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStaticClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStaticClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithInternalNestedEnumUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStaticClassWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithPrivateNestedEnumUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStaticClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithProtectedNestedEnumUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStaticClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithProtectedInternalNestedEnumUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStaticClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithPublicNestedEnumUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStaticClassWithPublicNestedEnum));
        }
    }
}
