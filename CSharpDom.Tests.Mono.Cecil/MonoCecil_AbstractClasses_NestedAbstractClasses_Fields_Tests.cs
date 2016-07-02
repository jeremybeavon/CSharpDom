using CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_NestedAbstractClasses_Fields_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithConstFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithConstField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithInternalFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithInternalField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithNewFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNewField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithNewStaticFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNewStaticField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithNewStaticReadOnlyFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithNewStaticVolatileFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithNewVolatileFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNewVolatileField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithPrivateFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithProtectedFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithProtectedField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithProtectedInternalFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithProtectedInternalField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithPublicFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithPublicField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithReadOnlyFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithStaticFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithStaticField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithStaticReadOnlyFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithStaticVolatileFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithVolatileFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithVolatileField));
        }
    }
}
