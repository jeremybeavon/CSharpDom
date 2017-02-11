using CSharpDom.TestTarget.Structs.NestedAbstractClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedAbstractClasses_Properties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedAbstractClassWithInternalPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithInternalProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithNewProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewStaticPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithNewStaticProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewVirtualPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithNewVirtualProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithOverridePropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPrivatePropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedInternalPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPublicPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithPublicProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithSealedOverridePropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithStaticPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithStaticProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithVirtualPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithVirtualProperty));
        }
    }
}
