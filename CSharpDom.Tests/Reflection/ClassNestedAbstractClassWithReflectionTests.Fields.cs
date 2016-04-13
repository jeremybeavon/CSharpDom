using CSharpDom.TestTarget.Classes.NestedAbstractClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    public sealed partial class ClassNestedAbstractClassWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithConstField()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithConstField));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithInternalField()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithInternalField));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithNewField()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewField));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithNewStaticField()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewStaticField));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithNewStaticReadOnlyField()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithNewStaticVolatileField()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithNewVolatileField()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewVolatileField));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithPrivateField()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithProtectedField()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedField));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithProtectedInternalField()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedInternalField));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithPublicField()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithPublicField));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithReadOnlyField()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithStaticField()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithStaticField));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithStaticReadOnlyField()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithStaticVolatileField()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithVolatileField()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithVolatileField));
        }
    }
}