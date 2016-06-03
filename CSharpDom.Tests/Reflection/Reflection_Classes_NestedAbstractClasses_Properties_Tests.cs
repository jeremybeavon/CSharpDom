using CSharpDom.TestTarget.Classes.NestedAbstractClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedAbstractClasses_Properties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithInternalPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithInternalProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNewPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNewStaticPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewStaticProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNewVirtualPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewVirtualProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithOverridePropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithOverrideProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithPrivatePropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithProtectedPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithProtectedInternalPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithPublicPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithPublicProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithSealedOverridePropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithStaticPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithStaticProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithVirtualPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithVirtualProperty));
        }
    }
}
