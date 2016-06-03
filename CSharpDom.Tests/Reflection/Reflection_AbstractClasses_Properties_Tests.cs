using CSharpDom.TestTarget.AbstractClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_Properties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithInternalPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithInternalProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNewPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNewProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNewStaticPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNewStaticProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNewVirtualPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNewVirtualProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithOverridePropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithOverrideProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithPrivatePropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithProtectedPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithProtectedProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithProtectedInternalPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithPublicPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithPublicProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithSealedOverridePropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithStaticPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithStaticProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithVirtualPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithVirtualProperty));
        }
    }
}
