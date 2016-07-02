using CSharpDom.TestTarget.Classes.NestedSealedClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedSealedClasses_Properties_AutoProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithInternalAutoPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNewAutoPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNewAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNewStaticAutoPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithOverrideAutoPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithPrivateAutoPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithProtectedAutoPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithProtectedInternalAutoPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithPublicAutoPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithPublicAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithSealedOverrideAutoPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithStaticAutoPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithStaticAutoProperty));
        }
    }
}
