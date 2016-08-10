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
            TestStructAsync(typeof(StructWithNestedAbstractClassWithInternalProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNewProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewStaticPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNewStaticProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewVirtualPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNewVirtualProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithOverridePropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPrivatePropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedInternalPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPublicPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithPublicProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithSealedOverridePropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithStaticPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithStaticProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithVirtualPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithVirtualProperty));
        }
    }
}
