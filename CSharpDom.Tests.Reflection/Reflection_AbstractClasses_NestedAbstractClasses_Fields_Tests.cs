using CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_NestedAbstractClasses_Fields_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithConstFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithConstField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithInternalFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithInternalField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithNewFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNewField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithNewStaticFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNewStaticField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithNewStaticReadOnlyFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithNewStaticVolatileFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithNewVolatileFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNewVolatileField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithPrivateFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithProtectedFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithProtectedField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithProtectedInternalFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithProtectedInternalField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithPublicFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithPublicField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithReadOnlyFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithStaticFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithStaticField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithStaticReadOnlyFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithStaticVolatileFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithVolatileFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithVolatileField));
        }
    }
}
