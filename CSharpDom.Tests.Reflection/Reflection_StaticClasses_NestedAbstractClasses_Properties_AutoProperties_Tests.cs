using CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedAbstractClasses_Properties_AutoProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithInternalAutoPropertyUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithNewAutoPropertyUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewAutoProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithNewStaticAutoPropertyUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithNewVirtualAutoPropertyUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithOverrideAutoPropertyUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithPrivateAutoPropertyUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithProtectedAutoPropertyUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithProtectedInternalAutoPropertyUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithPublicAutoPropertyUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithPublicAutoProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithSealedOverrideAutoPropertyUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithStaticAutoPropertyUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithStaticAutoProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithVirtualAutoPropertyUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithVirtualAutoProperty));
        }
    }
}
