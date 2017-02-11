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
            TestSealedClass(typeof(SealedClassWithNestedClassWithConstField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithInternalFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithInternalField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithNewField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewStaticFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithNewStaticField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewStaticReadOnlyFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewStaticVolatileFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewVolatileFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPrivateFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithPrivateField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithProtectedField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedInternalFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPublicFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithPublicField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithReadOnlyFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithStaticFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithStaticField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithStaticReadOnlyFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithStaticVolatileFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithVolatileFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithVolatileField));
        }
    }
}
