using CSharpDom.TestTarget.SealedClasses.NestedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedClasses_Fields_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedClassWithConstFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithConstField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithInternalFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithInternalField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewStaticFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewStaticField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewStaticReadOnlyFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewStaticVolatileFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewVolatileFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPrivateFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPrivateField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedInternalFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPublicFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPublicField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithReadOnlyFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithStaticFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithStaticField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithStaticReadOnlyFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithStaticVolatileFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithVolatileFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithVolatileField));
        }
    }
}
