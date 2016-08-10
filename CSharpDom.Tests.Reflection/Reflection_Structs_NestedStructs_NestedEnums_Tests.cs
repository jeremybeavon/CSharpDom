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
            TestStructAsync(typeof(StructWithNestedStructWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedEnumWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithInternalNestedEnumUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPrivateNestedEnumUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPublicNestedEnumUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPublicNestedEnum));
        }
    }
}
