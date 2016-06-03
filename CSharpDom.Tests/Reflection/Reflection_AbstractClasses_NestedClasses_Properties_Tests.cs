using CSharpDom.TestTarget.AbstractClasses.NestedClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_NestedClasses_Properties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithInternalPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithInternalProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNewPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNewStaticPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewStaticProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNewVirtualPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewVirtualProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithOverridePropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithOverrideProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithPrivatePropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithProtectedPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithProtectedInternalPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithPublicPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPublicProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithSealedOverridePropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithStaticPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithStaticProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithVirtualPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithVirtualProperty));
        }
    }
}
