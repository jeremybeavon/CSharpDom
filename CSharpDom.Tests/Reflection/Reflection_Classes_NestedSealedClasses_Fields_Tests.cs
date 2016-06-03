using CSharpDom.TestTarget.Classes.NestedSealedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedSealedClasses_Fields_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithConstFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithConstField));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithInternalFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithInternalField));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNewFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNewField));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNewStaticFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNewStaticField));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNewStaticReadOnlyFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNewStaticVolatileFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNewVolatileFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNewVolatileField));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithPrivateFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithProtectedFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedField));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithProtectedInternalFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedInternalField));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithPublicFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithPublicField));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithReadOnlyFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithStaticFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithStaticField));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithStaticReadOnlyFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithStaticVolatileFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithVolatileFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithVolatileField));
        }
    }
}
