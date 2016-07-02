using CSharpDom.TestTarget.AbstractClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_Properties_AutoProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithInternalAutoPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNewAutoPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNewAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNewStaticAutoPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNewVirtualAutoPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithOverrideAutoPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithPrivateAutoPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithProtectedAutoPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithProtectedInternalAutoPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithPublicAutoPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithPublicAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithSealedOverrideAutoPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithStaticAutoPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithStaticAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithVirtualAutoPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithVirtualAutoProperty));
        }
    }
}
