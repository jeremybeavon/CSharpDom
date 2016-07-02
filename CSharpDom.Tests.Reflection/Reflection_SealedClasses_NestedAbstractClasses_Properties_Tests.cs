using CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedAbstractClasses_Properties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithInternalPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithInternalProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNewPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNewStaticPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewStaticProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNewVirtualPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewVirtualProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithOverridePropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithOverrideProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithPrivatePropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithProtectedPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithProtectedProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithProtectedInternalPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithPublicPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithPublicProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithSealedOverridePropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithStaticPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithStaticProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithVirtualPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithVirtualProperty));
        }
    }
}
