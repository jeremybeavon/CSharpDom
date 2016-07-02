using CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_StaticClasses_NestedSealedClasses_Fields_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithConstFieldUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithConstField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithInternalFieldUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithInternalField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNewFieldUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNewField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNewStaticFieldUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNewStaticField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNewStaticReadOnlyFieldUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNewStaticVolatileFieldUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNewVolatileFieldUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNewVolatileField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithPrivateFieldUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithProtectedFieldUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithProtectedField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithProtectedInternalFieldUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithProtectedInternalField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithPublicFieldUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithPublicField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithReadOnlyFieldUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithStaticFieldUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithStaticField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithStaticReadOnlyFieldUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithStaticVolatileFieldUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithVolatileFieldUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithVolatileField));
        }
    }
}
