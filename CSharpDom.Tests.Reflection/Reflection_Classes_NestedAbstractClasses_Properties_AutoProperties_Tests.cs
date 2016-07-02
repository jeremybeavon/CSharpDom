using CSharpDom.TestTarget.Classes.NestedAbstractClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedAbstractClasses_Properties_AutoProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithInternalAutoPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNewAutoPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNewStaticAutoPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNewVirtualAutoPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithOverrideAutoPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithPrivateAutoPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithProtectedAutoPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithProtectedInternalAutoPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithPublicAutoPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithPublicAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithSealedOverrideAutoPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithStaticAutoPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithStaticAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithVirtualAutoPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithVirtualAutoProperty));
        }
    }
}
