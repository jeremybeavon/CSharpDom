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
            TestStructAsync(typeof(StructWithNestedSealedClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithInternalNestedEnumUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPrivateNestedEnumUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedNestedEnumUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedInternalNestedEnumUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPublicNestedEnumUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithPublicNestedEnum));
        }
    }
}
