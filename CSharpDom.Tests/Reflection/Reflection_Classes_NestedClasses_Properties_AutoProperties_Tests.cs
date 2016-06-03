using CSharpDom.TestTarget.Classes.NestedClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedClasses_Properties_AutoProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithNestedClassWithInternalAutoPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNewAutoPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNewStaticAutoPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNewVirtualAutoPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithOverrideAutoPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithPrivateAutoPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithProtectedAutoPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithProtectedInternalAutoPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithPublicAutoPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPublicAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithSealedOverrideAutoPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithStaticAutoPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithStaticAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithVirtualAutoPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithVirtualAutoProperty));
        }
    }
}
