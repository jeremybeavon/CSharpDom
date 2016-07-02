using CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedSealedClasses_Properties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithInternalPropertyUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithInternalProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNewPropertyUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNewProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNewStaticPropertyUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNewStaticProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithOverridePropertyUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithOverrideProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithPrivatePropertyUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithProtectedPropertyUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithProtectedProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithProtectedInternalPropertyUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithPublicPropertyUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithPublicProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithSealedOverridePropertyUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithStaticPropertyUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithStaticProperty));
        }
    }
}
