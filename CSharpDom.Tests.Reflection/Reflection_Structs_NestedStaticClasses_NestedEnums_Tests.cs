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
            TestStructAsync(typeof(StructWithNestedStaticClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithInternalNestedEnumUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithPrivateNestedEnumUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithProtectedNestedEnumUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithProtectedInternalNestedEnumUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithPublicNestedEnumUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithPublicNestedEnum));
        }
    }
}
