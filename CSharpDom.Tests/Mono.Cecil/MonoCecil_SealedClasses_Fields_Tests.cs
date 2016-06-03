using CSharpDom.TestTarget.SealedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_Fields_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestSealedClassWithConstrFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithConstrField));
        }

        [TestMethod]
        public async Task TestSealedClassWithInternalFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithInternalField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNewFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNewField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNewStaticFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNewStaticField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNewStaticReadOnlyFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNewStaticVolatileFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNewVolatileFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNewVolatileField));
        }

        [TestMethod]
        public async Task TestSealedClassWithPrivateFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestSealedClassWithProtectedFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithProtectedField));
        }

        [TestMethod]
        public async Task TestSealedClassWithProtectedInternalFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithProtectedInternalField));
        }

        [TestMethod]
        public async Task TestSealedClassWithPublicFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithPublicField));
        }

        [TestMethod]
        public async Task TestSealedClassWithReadOnlyFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestSealedClassWithStaticFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithStaticField));
        }

        [TestMethod]
        public async Task TestSealedClassWithStaticReadOnlyFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestSealedClassWithStaticVolatileFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestSealedClassWithVolatileFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithVolatileField));
        }
    }
}
