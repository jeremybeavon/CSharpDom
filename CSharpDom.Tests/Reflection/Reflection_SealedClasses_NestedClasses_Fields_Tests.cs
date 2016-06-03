using CSharpDom.TestTarget.SealedClasses.NestedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedClasses_Fields_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithConstFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithConstField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithInternalFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithInternalField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNewFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNewStaticFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewStaticField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNewStaticReadOnlyFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNewStaticVolatileFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNewVolatileFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewVolatileField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithPrivateFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithProtectedFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithProtectedInternalFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedInternalField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithPublicFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPublicField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithReadOnlyFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithStaticFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithStaticField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithStaticReadOnlyFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithStaticVolatileFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithVolatileFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithVolatileField));
        }
    }
}
