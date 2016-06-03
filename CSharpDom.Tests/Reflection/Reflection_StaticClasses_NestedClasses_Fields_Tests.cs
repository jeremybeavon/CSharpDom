using CSharpDom.TestTarget.StaticClasses.NestedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedClasses_Fields_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithConstFieldUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithConstField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithInternalFieldUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithInternalField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNewFieldUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNewStaticFieldUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewStaticField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNewStaticReadOnlyFieldUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNewStaticVolatileFieldUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNewVolatileFieldUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewVolatileField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithPrivateFieldUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithProtectedFieldUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithProtectedInternalFieldUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedInternalField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithPublicFieldUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPublicField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithReadOnlyFieldUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithStaticFieldUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithStaticField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithStaticReadOnlyFieldUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithStaticVolatileFieldUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithVolatileFieldUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithVolatileField));
        }
    }
}
