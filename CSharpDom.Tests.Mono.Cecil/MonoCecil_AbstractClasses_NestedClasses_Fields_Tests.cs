using CSharpDom.TestTarget.AbstractClasses.NestedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_NestedClasses_Fields_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithConstFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithConstField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithInternalFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithInternalField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNewFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNewStaticFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewStaticField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNewStaticReadOnlyFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNewStaticVolatileFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNewVolatileFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewVolatileField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithPrivateFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithProtectedFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithProtectedInternalFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedInternalField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithPublicFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPublicField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithReadOnlyFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithStaticFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithStaticField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithStaticReadOnlyFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithStaticVolatileFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithVolatileFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithVolatileField));
        }
    }
}
