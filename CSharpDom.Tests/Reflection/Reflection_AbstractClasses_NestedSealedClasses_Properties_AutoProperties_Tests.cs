using CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_NestedSealedClasses_Properties_AutoProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithInternalAutoPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithNewAutoPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNewAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithNewStaticAutoPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithOverrideAutoPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithPrivateAutoPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithProtectedAutoPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithProtectedInternalAutoPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithPublicAutoPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithPublicAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithSealedOverrideAutoPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithStaticAutoPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithStaticAutoProperty));
        }
    }
}
