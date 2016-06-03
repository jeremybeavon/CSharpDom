using CSharpDom.TestTarget.AbstractClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_Fields_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithConstrFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithConstrField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithInternalFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithInternalField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNewFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNewField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNewStaticFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNewStaticField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNewStaticReadOnlyFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNewStaticVolatileFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNewVolatileFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNewVolatileField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithPrivateFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithProtectedFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithProtectedField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithProtectedInternalFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithProtectedInternalField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithPublicFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithPublicField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithReadOnlyFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithStaticFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithStaticField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithStaticReadOnlyFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithStaticVolatileFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithVolatileFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithVolatileField));
        }
    }
}
