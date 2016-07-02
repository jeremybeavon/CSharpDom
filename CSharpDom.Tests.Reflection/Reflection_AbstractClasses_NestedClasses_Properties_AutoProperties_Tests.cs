using CSharpDom.TestTarget.AbstractClasses.NestedClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_NestedClasses_Properties_AutoProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithInternalAutoPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNewAutoPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNewStaticAutoPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNewVirtualAutoPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithOverrideAutoPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithPrivateAutoPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithProtectedAutoPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithProtectedInternalAutoPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithPublicAutoPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPublicAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithSealedOverrideAutoPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithStaticAutoPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithStaticAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithVirtualAutoPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithVirtualAutoProperty));
        }
    }
}
