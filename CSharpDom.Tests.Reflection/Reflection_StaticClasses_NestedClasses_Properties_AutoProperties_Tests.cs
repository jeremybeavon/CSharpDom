using CSharpDom.TestTarget.StaticClasses.NestedClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedClasses_Properties_AutoProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithInternalAutoPropertyUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNewAutoPropertyUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewAutoProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNewStaticAutoPropertyUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNewVirtualAutoPropertyUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithOverrideAutoPropertyUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithPrivateAutoPropertyUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithProtectedAutoPropertyUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithProtectedInternalAutoPropertyUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithPublicAutoPropertyUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPublicAutoProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithSealedOverrideAutoPropertyUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithStaticAutoPropertyUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithStaticAutoProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithVirtualAutoPropertyUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithVirtualAutoProperty));
        }
    }
}
