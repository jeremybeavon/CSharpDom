using CSharpDom.TestTarget.Classes.NestedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedClasses_Fields_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestClassWithNestedClassWithConstFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithConstField));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithInternalFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithInternalField));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNewFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewField));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNewStaticFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewStaticField));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNewStaticReadOnlyFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNewStaticVolatileFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNewVolatileFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewVolatileField));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithPrivateFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithProtectedFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithProtectedField));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithProtectedInternalFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithProtectedInternalField));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithPublicFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPublicField));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithReadOnlyFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithStaticFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithStaticField));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithStaticReadOnlyFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithStaticVolatileFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithVolatileFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithVolatileField));
        }
    }
}
