using CSharpDom.TestTarget.SealedClasses.NestedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_NestedClasses_Fields_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithConstFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithConstField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithInternalFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithInternalField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNewFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNewStaticFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewStaticField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNewStaticReadOnlyFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNewStaticVolatileFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNewVolatileFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewVolatileField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithPrivateFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithProtectedFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithProtectedInternalFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedInternalField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithPublicFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPublicField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithReadOnlyFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithStaticFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithStaticField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithStaticReadOnlyFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithStaticVolatileFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithVolatileFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithVolatileField));
        }
    }
}
