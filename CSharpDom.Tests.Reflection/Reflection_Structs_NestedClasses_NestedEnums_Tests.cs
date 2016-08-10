using CSharpDom.TestTarget.Structs.NestedClasses.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedClasses_NestedEnums_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedClassWithNestedEnumWith1AttributeUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithInternalNestedEnumUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPrivateNestedEnumUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedNestedEnumUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedInternalNestedEnumUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPublicNestedEnumUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPublicNestedEnum));
        }
    }
}
