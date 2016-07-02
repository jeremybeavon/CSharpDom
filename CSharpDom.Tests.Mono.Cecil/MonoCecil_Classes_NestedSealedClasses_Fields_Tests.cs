using CSharpDom.TestTarget.Classes.NestedSealedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedSealedClasses_Fields_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithConstFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithConstField));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithInternalFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithInternalField));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNewFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNewField));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNewStaticFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNewStaticField));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNewStaticReadOnlyFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNewStaticVolatileFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNewVolatileFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNewVolatileField));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithPrivateFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithProtectedFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedField));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithProtectedInternalFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedInternalField));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithPublicFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithPublicField));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithReadOnlyFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithStaticFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithStaticField));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithStaticReadOnlyFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithStaticVolatileFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithVolatileFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithVolatileField));
        }
    }
}
