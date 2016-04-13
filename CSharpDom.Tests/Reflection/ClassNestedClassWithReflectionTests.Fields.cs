using CSharpDom.TestTarget.Classes.NestedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    public sealed partial class ClassNestedClassWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithConstField()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithConstField));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithInternalField()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithInternalField));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithNewField()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewField));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithNewStaticField()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewStaticField));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithNewStaticReadOnlyField()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithNewStaticVolatileField()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithNewVolatileField()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewVolatileField));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithPrivateField()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithProtectedField()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithProtectedField));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithProtectedInternalField()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithProtectedInternalField));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithPublicField()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPublicField));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithReadOnlyField()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithStaticField()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithStaticField));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithStaticReadOnlyField()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithStaticVolatileField()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithVolatileField()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithVolatileField));
        }
    }
}