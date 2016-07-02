using CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedSealedClasses_Fields_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithConstFieldUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithConstField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithInternalFieldUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithInternalField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNewFieldUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNewField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNewStaticFieldUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNewStaticField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNewStaticReadOnlyFieldUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNewStaticVolatileFieldUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNewVolatileFieldUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNewVolatileField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithPrivateFieldUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithProtectedFieldUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithProtectedField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithProtectedInternalFieldUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithProtectedInternalField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithPublicFieldUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithPublicField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithReadOnlyFieldUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithStaticFieldUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithStaticField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithStaticReadOnlyFieldUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithStaticVolatileFieldUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithVolatileFieldUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithVolatileField));
        }
    }
}
