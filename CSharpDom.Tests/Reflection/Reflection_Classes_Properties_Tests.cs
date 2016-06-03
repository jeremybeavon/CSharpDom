using CSharpDom.TestTarget.Classes.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_Properties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithInternalPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithInternalProperty));
        }

        [TestMethod]
        public async Task TestClassWithNewPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNewProperty));
        }

        [TestMethod]
        public async Task TestClassWithNewStaticPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNewStaticProperty));
        }

        [TestMethod]
        public async Task TestClassWithNewVirtualPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNewVirtualProperty));
        }

        [TestMethod]
        public async Task TestClassWithOverridePropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithOverrideProperty));
        }

        [TestMethod]
        public async Task TestClassWithPrivatePropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestClassWithProtectedPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithProtectedProperty));
        }

        [TestMethod]
        public async Task TestClassWithProtectedInternalPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public async Task TestClassWithPublicPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithPublicProperty));
        }

        [TestMethod]
        public async Task TestClassWithSealedOverridePropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public async Task TestClassWithStaticPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithStaticProperty));
        }

        [TestMethod]
        public async Task TestClassWithVirtualPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithVirtualProperty));
        }
    }
}
