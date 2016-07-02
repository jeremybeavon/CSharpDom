using CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedAbstractClasses_Fields_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithConstFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithConstField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithInternalFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithInternalField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNewFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNewStaticFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewStaticField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNewStaticReadOnlyFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNewStaticVolatileFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNewVolatileFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewVolatileField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithPrivateFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithProtectedFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithProtectedField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithProtectedInternalFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithProtectedInternalField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithPublicFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithPublicField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithReadOnlyFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithStaticFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithStaticField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithStaticReadOnlyFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithStaticVolatileFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithVolatileFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithVolatileField));
        }
    }
}
