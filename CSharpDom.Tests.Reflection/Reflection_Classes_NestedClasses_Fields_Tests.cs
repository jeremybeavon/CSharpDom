using CSharpDom.TestTarget.Classes.NestedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedClasses_Fields_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithNestedClassWithConstFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithConstField));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithInternalFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithInternalField));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNewFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewField));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNewStaticFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewStaticField));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNewStaticReadOnlyFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNewStaticVolatileFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNewVolatileFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewVolatileField));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithPrivateFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithProtectedFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithProtectedField));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithProtectedInternalFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithProtectedInternalField));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithPublicFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPublicField));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithReadOnlyFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithStaticFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithStaticField));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithStaticReadOnlyFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithStaticVolatileFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithVolatileFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithVolatileField));
        }
    }
}
