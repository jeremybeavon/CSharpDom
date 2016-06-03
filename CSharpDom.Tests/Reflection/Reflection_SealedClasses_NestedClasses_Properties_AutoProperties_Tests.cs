using CSharpDom.TestTarget.SealedClasses.NestedClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedClasses_Properties_AutoProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithInternalAutoPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNewAutoPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewAutoProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNewStaticAutoPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNewVirtualAutoPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithOverrideAutoPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithPrivateAutoPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithProtectedAutoPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithProtectedInternalAutoPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithPublicAutoPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPublicAutoProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithSealedOverrideAutoPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithStaticAutoPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithStaticAutoProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithVirtualAutoPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithVirtualAutoProperty));
        }
    }
}
