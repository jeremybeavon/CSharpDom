using CSharpDom.TestTarget.Classes.NestedAbstractClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedAbstractClasses_Fields_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithConstFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithConstField));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithInternalFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithInternalField));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNewFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewField));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNewStaticFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewStaticField));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNewStaticReadOnlyFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNewStaticVolatileFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNewVolatileFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewVolatileField));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithPrivateFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithProtectedFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedField));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithProtectedInternalFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedInternalField));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithPublicFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithPublicField));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithReadOnlyFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithStaticFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithStaticField));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithStaticReadOnlyFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithStaticVolatileFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithVolatileFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithVolatileField));
        }
    }
}
