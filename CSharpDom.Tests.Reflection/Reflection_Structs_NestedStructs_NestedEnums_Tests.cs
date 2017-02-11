using CSharpDom.TestTarget.Structs.NestedStructs.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedStructs_NestedEnums_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedStructWithNestedEnumWith1AttributeUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedEnumWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithInternalNestedEnumUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPrivateNestedEnumUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPublicNestedEnumUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithPublicNestedEnum));
        }
    }
}
