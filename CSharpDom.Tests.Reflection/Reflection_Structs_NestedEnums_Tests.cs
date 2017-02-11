using CSharpDom.TestTarget.Structs.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedEnums_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedEnumWith1AttributeUsingReflection()
        {
            TestStruct(typeof(StructWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedEnumWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithInternalNestedEnumUsingReflection()
        {
            TestStruct(typeof(StructWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestStructWithPrivateNestedEnumUsingReflection()
        {
            TestStruct(typeof(StructWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestStructWithPublicNestedEnumUsingReflection()
        {
            TestStruct(typeof(StructWithPublicNestedEnum));
        }
    }
}
