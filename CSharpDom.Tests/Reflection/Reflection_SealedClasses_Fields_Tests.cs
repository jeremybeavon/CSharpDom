using CSharpDom.TestTarget.SealedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_Fields_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestSealedClassWithConstrFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithConstrField));
        }

        [TestMethod]
        public async Task TestSealedClassWithInternalFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithInternalField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNewFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNewField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNewStaticFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNewStaticField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNewStaticReadOnlyFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNewStaticVolatileFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNewVolatileFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNewVolatileField));
        }

        [TestMethod]
        public async Task TestSealedClassWithPrivateFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestSealedClassWithProtectedFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithProtectedField));
        }

        [TestMethod]
        public async Task TestSealedClassWithProtectedInternalFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithProtectedInternalField));
        }

        [TestMethod]
        public async Task TestSealedClassWithPublicFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithPublicField));
        }

        [TestMethod]
        public async Task TestSealedClassWithReadOnlyFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestSealedClassWithStaticFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithStaticField));
        }

        [TestMethod]
        public async Task TestSealedClassWithStaticReadOnlyFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestSealedClassWithStaticVolatileFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestSealedClassWithVolatileFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithVolatileField));
        }
    }
}
