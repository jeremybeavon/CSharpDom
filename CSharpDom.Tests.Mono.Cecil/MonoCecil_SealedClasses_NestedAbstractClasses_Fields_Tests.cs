using CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_NestedAbstractClasses_Fields_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithConstFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithConstField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithInternalFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithInternalField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNewFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNewStaticFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewStaticField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNewStaticReadOnlyFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNewStaticVolatileFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNewVolatileFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewVolatileField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithPrivateFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithProtectedFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithProtectedField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithProtectedInternalFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithProtectedInternalField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithPublicFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithPublicField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithReadOnlyFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithStaticFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithStaticField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithStaticReadOnlyFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithStaticVolatileFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithVolatileFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithVolatileField));
        }
    }
}
