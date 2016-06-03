using CSharpDom.TestTarget.AbstractClasses.NestedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_NestedClasses_Fields_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithConstFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithConstField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithInternalFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithInternalField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNewFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNewStaticFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewStaticField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNewStaticReadOnlyFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNewStaticVolatileFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNewVolatileFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewVolatileField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithPrivateFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithProtectedFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithProtectedInternalFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedInternalField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithPublicFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPublicField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithReadOnlyFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithStaticFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithStaticField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithStaticReadOnlyFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithStaticVolatileFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithVolatileFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithVolatileField));
        }
    }
}
