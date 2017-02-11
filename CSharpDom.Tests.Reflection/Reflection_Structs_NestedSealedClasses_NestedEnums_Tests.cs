using CSharpDom.TestTarget.Structs.NestedSealedClasses.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedSealedClasses_NestedEnums_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedSealedClassWithNestedEnumWith1AttributeUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithInternalNestedEnumUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPrivateNestedEnumUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedNestedEnumUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedInternalNestedEnumUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPublicNestedEnumUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithPublicNestedEnum));
        }
    }
}
