using CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedAbstractClasses_Properties_AutoProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithInternalAutoPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNewAutoPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewAutoProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNewStaticAutoPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNewVirtualAutoPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithOverrideAutoPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithPrivateAutoPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithProtectedAutoPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithProtectedInternalAutoPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithPublicAutoPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithPublicAutoProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithSealedOverrideAutoPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithStaticAutoPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithStaticAutoProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithVirtualAutoPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithVirtualAutoProperty));
        }
    }
}
