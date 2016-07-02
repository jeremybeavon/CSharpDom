using CSharpDom.TestTarget.StaticClasses.NestedClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedClasses_Properties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithInternalPropertyUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithInternalProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNewPropertyUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNewStaticPropertyUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewStaticProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNewVirtualPropertyUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewVirtualProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithOverridePropertyUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithOverrideProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithPrivatePropertyUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithProtectedPropertyUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithProtectedInternalPropertyUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithPublicPropertyUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPublicProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithSealedOverridePropertyUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithStaticPropertyUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithStaticProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithVirtualPropertyUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithVirtualProperty));
        }
    }
}
