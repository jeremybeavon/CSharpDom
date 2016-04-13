using CSharpDom.TestTarget.Classes.NestedSealedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    public sealed partial class ClassNestedSealedClassWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithConstField()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithConstField));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithInternalField()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithInternalField));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithNewField()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNewField));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithNewStaticField()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNewStaticField));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithNewStaticReadOnlyField()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithNewStaticVolatileField()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithNewVolatileField()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNewVolatileField));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithPrivateField()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithProtectedField()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedField));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithProtectedInternalField()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedInternalField));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithPublicField()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithPublicField));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithReadOnlyField()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithStaticField()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithStaticField));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithStaticReadOnlyField()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithStaticVolatileField()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithVolatileField()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithVolatileField));
        }
    }
}