using CSharpDom.TestTarget.Classes.NestedAbstractClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedAbstractClasses_Fields_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithConstFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithConstField));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithInternalFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithInternalField));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNewFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewField));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNewStaticFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewStaticField));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNewStaticReadOnlyFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNewStaticVolatileFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNewVolatileFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewVolatileField));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithPrivateFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithProtectedFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedField));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithProtectedInternalFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedInternalField));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithPublicFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithPublicField));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithReadOnlyFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithStaticFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithStaticField));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithStaticReadOnlyFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithStaticVolatileFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithVolatileFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithVolatileField));
        }
    }
}
