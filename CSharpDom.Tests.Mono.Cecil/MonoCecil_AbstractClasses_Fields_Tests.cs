using CSharpDom.TestTarget.AbstractClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_Fields_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithConstrFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithConstField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithInternalFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithInternalField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNewFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNewField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNewStaticFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNewStaticField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNewStaticReadOnlyFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNewStaticVolatileFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNewVolatileFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNewVolatileField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithPrivateFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithProtectedFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithProtectedField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithProtectedInternalFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithProtectedInternalField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithPublicFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithPublicField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithReadOnlyFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithStaticFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithStaticField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithStaticReadOnlyFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithStaticVolatileFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithVolatileFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithVolatileField));
        }
    }
}
