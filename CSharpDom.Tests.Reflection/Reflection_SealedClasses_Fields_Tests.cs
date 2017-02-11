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
            TestSealedClass(typeof(SealedClassWithConstField));
        }

        [TestMethod]
        public void TestSealedClassWithInternalFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithInternalField));
        }

        [TestMethod]
        public void TestSealedClassWithNewFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNewField));
        }

        [TestMethod]
        public void TestSealedClassWithNewStaticFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNewStaticField));
        }

        [TestMethod]
        public void TestSealedClassWithNewStaticReadOnlyFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithNewStaticVolatileFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestSealedClassWithNewVolatileFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestSealedClassWithPrivateFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithPrivateField));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithProtectedField));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedInternalFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestSealedClassWithPublicFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithPublicField));
        }

        [TestMethod]
        public void TestSealedClassWithReadOnlyFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithStaticFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithStaticField));
        }

        [TestMethod]
        public void TestSealedClassWithStaticReadOnlyFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithStaticVolatileFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestSealedClassWithVolatileFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithVolatileField));
        }
    }
}
