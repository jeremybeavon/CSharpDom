using CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_StaticClasses_NestedAbstractClasses_Fields_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithConstFieldUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithConstField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithInternalFieldUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithInternalField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithNewFieldUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithNewStaticFieldUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewStaticField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithNewStaticReadOnlyFieldUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithNewStaticVolatileFieldUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithNewVolatileFieldUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewVolatileField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithPrivateFieldUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithProtectedFieldUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithProtectedField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithProtectedInternalFieldUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithProtectedInternalField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithPublicFieldUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithPublicField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithReadOnlyFieldUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithStaticFieldUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithStaticField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithStaticReadOnlyFieldUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithStaticVolatileFieldUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithVolatileFieldUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithVolatileField));
        }
    }
}
