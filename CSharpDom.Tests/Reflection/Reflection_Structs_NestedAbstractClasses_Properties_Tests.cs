using CSharpDom.TestTarget.Structs.NestedAbstractClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedAbstractClasses_Properties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithInternalPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithInternalProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNewPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNewProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNewStaticPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNewStaticProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNewVirtualPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNewVirtualProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithOverridePropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithOverrideProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithPrivatePropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithProtectedPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithProtectedInternalPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithPublicPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithPublicProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithSealedOverridePropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithStaticPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithStaticProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithVirtualPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithVirtualProperty));
        }
    }
}
