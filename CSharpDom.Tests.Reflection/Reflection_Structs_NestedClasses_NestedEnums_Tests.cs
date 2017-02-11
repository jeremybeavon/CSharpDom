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
            TestStruct(typeof(StructWithNestedClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithInternalNestedEnumUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPrivateNestedEnumUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedNestedEnumUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedInternalNestedEnumUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPublicNestedEnumUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithPublicNestedEnum));
        }
    }
}
