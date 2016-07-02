using CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedSealedClasses_Fields_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithConstFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithConstField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithInternalFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithInternalField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNewFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNewField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNewStaticFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNewStaticField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNewStaticReadOnlyFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNewStaticVolatileFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNewVolatileFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNewVolatileField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithPrivateFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithProtectedFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithProtectedField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithProtectedInternalFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithProtectedInternalField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithPublicFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithPublicField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithReadOnlyFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithStaticFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithStaticField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithStaticReadOnlyFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithStaticVolatileFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithVolatileFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithVolatileField));
        }
    }
}
