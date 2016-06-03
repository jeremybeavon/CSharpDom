using CSharpDom.TestTarget.Classes.NestedSealedClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedSealedClasses_Properties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithInternalPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithInternalProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNewPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNewProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNewStaticPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNewStaticProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithOverridePropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithOverrideProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithPrivatePropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithProtectedPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithProtectedInternalPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithPublicPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithPublicProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithSealedOverridePropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithStaticPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithStaticProperty));
        }
    }
}
