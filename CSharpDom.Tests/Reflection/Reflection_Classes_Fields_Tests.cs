using CSharpDom.TestTarget.Classes.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_Fields_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithConstFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithConstField));
        }

        [TestMethod]
        public async Task TestClassWithInternalFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithInternalField));
        }

        [TestMethod]
        public async Task TestClassWithNewFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNewField));
        }

        [TestMethod]
        public async Task TestClassWithNewStaticFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNewStaticField));
        }

        [TestMethod]
        public async Task TestClassWithNewStaticReadOnlyFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestClassWithNewStaticVolatileFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public async Task TestClassWithNewVolatileFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNewVolatileField));
        }

        [TestMethod]
        public async Task TestClassWithPrivateFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestClassWithProtectedFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithProtectedField));
        }

        [TestMethod]
        public async Task TestClassWithProtectedInternalFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithProtectedInternalField));
        }

        [TestMethod]
        public async Task TestClassWithPublicFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithPublicField));
        }

        [TestMethod]
        public async Task TestClassWithReadOnlyFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestClassWithStaticFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithStaticField));
        }

        [TestMethod]
        public async Task TestClassWithStaticReadOnlyFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestClassWithStaticVolatileFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestClassWithVolatileFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithVolatileField));
        }
    }
}
