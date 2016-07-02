using CSharpDom.TestTarget.Classes.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_Properties_AutoProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithInternalAutoPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNewAutoPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNewAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNewStaticAutoPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNewVirtualAutoPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithOverrideAutoPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithPrivateAutoPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithProtectedAutoPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithProtectedInternalAutoPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithPublicAutoPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithPublicAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithSealedOverrideAutoPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithStaticAutoPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithStaticAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithVirtualAutoPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithVirtualAutoProperty));
        }
    }
}
