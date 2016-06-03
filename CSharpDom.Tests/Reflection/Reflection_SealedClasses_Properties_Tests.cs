using CSharpDom.TestTarget.SealedClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_Properties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestSealedClassWithInternalPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithInternalProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNewPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNewProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNewStaticPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNewStaticProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithOverridePropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithOverrideProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithPrivatePropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithProtectedPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithProtectedProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithProtectedInternalPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithPublicPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithPublicProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithSealedOverridePropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithStaticPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithStaticProperty));
        }
    }
}
