using CSharpDom.TestTarget.SealedClasses.NestedClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedClasses_Properties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithInternalPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithInternalProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNewPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNewStaticPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewStaticProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNewVirtualPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewVirtualProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithOverridePropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithOverrideProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithPrivatePropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithProtectedPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithProtectedInternalPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithPublicPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPublicProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithSealedOverridePropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithStaticPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithStaticProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithVirtualPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithVirtualProperty));
        }
    }
}
