using CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedAbstractClasses_Fields_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithConstFieldUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithConstField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithInternalFieldUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithInternalField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithNewFieldUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithNewStaticFieldUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewStaticField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithNewStaticReadOnlyFieldUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithNewStaticVolatileFieldUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithNewVolatileFieldUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewVolatileField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithPrivateFieldUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithProtectedFieldUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithProtectedField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithProtectedInternalFieldUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithProtectedInternalField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithPublicFieldUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithPublicField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithReadOnlyFieldUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithStaticFieldUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithStaticField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithStaticReadOnlyFieldUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithStaticVolatileFieldUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithVolatileFieldUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithVolatileField));
        }
    }
}
