using CSharpDom.TestTarget.SealedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_Fields_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestSealedClassWithConstFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithConstField));
        }

        [TestMethod]
        public void TestSealedClassWithInternalFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithInternalField));
        }

        [TestMethod]
        public void TestSealedClassWithNewFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNewField));
        }

        [TestMethod]
        public void TestSealedClassWithNewStaticFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNewStaticField));
        }

        [TestMethod]
        public void TestSealedClassWithNewStaticReadOnlyFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithNewStaticVolatileFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestSealedClassWithNewVolatileFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestSealedClassWithPrivateFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithPrivateField));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithProtectedField));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedInternalFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestSealedClassWithPublicFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithPublicField));
        }

        [TestMethod]
        public void TestSealedClassWithReadOnlyFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithStaticFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithStaticField));
        }

        [TestMethod]
        public void TestSealedClassWithStaticReadOnlyFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithStaticVolatileFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestSealedClassWithVolatileFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithVolatileField));
        }
    }
}
