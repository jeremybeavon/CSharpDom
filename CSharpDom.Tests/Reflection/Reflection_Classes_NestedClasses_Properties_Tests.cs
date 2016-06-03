using CSharpDom.TestTarget.Classes.NestedClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedClasses_Properties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithNestedClassWithInternalPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithInternalProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNewPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNewStaticPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewStaticProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNewVirtualPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewVirtualProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithOverridePropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithOverrideProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithPrivatePropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithProtectedPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithProtectedProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithProtectedInternalPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithPublicPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPublicProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithSealedOverridePropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithStaticPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithStaticProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithVirtualPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithVirtualProperty));
        }
    }
}
