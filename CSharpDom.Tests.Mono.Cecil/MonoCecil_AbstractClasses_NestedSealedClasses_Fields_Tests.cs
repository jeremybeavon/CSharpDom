using CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_NestedSealedClasses_Fields_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithConstFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithConstField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithInternalFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithInternalField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithNewFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNewField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithNewStaticFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNewStaticField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithNewStaticReadOnlyFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithNewStaticVolatileFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithNewVolatileFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNewVolatileField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithPrivateFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithProtectedFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithProtectedField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithProtectedInternalFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithProtectedInternalField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithPublicFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithPublicField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithReadOnlyFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithStaticFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithStaticField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithStaticReadOnlyFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithStaticVolatileFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithVolatileFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithVolatileField));
        }
    }
}
