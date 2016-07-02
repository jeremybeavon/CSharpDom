using CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_NestedSealedClasses_Fields_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithConstFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithConstField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithInternalFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithInternalField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNewFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNewField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNewStaticFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNewStaticField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNewStaticReadOnlyFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNewStaticVolatileFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNewVolatileFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNewVolatileField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithPrivateFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithProtectedFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithProtectedField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithProtectedInternalFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithProtectedInternalField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithPublicFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithPublicField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithReadOnlyFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithStaticFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithStaticField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithStaticReadOnlyFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithStaticVolatileFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithVolatileFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithVolatileField));
        }
    }
}
