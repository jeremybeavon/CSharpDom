using CSharpDom.TestTarget.Classes.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_Fields_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestClassWithConstFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithConstField));
        }

        [TestMethod]
        public async Task TestClassWithInternalFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithInternalField));
        }

        [TestMethod]
        public async Task TestClassWithNewFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNewField));
        }

        [TestMethod]
        public async Task TestClassWithNewStaticFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNewStaticField));
        }

        [TestMethod]
        public async Task TestClassWithNewStaticReadOnlyFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestClassWithNewStaticVolatileFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public async Task TestClassWithNewVolatileFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNewVolatileField));
        }

        [TestMethod]
        public async Task TestClassWithPrivateFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestClassWithProtectedFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithProtectedField));
        }

        [TestMethod]
        public async Task TestClassWithProtectedInternalFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithProtectedInternalField));
        }

        [TestMethod]
        public async Task TestClassWithPublicFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithPublicField));
        }

        [TestMethod]
        public async Task TestClassWithReadOnlyFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestClassWithStaticFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithStaticField));
        }

        [TestMethod]
        public async Task TestClassWithStaticReadOnlyFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestClassWithStaticVolatileFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestClassWithVolatileFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithVolatileField));
        }
    }
}
