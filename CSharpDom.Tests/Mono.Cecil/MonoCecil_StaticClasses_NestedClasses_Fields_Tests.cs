using CSharpDom.TestTarget.StaticClasses.NestedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_StaticClasses_NestedClasses_Fields_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithConstFieldUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithConstField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithInternalFieldUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithInternalField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNewFieldUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNewStaticFieldUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewStaticField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNewStaticReadOnlyFieldUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNewStaticVolatileFieldUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNewVolatileFieldUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewVolatileField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithPrivateFieldUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithProtectedFieldUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithProtectedInternalFieldUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedInternalField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithPublicFieldUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPublicField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithReadOnlyFieldUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithStaticFieldUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithStaticField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithStaticReadOnlyFieldUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithStaticVolatileFieldUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithVolatileFieldUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithVolatileField));
        }
    }
}
