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
            TestStructAsync(typeof(StructWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedEnumWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithInternalNestedEnumUsingReflection()
        {
            TestStructAsync(typeof(StructWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestStructWithPrivateNestedEnumUsingReflection()
        {
            TestStructAsync(typeof(StructWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestStructWithPublicNestedEnumUsingReflection()
        {
            TestStructAsync(typeof(StructWithPublicNestedEnum));
        }
    }
}
