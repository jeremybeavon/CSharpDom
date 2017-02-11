using CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedAbstractClasses_Fields_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithConstFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithConstField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithInternalFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithInternalField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNewFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithNewField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNewStaticFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithNewStaticField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNewStaticReadOnlyFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNewStaticVolatileFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNewVolatileFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithPrivateFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithPrivateField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithProtectedFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithProtectedField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithProtectedInternalFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithPublicFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithPublicField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithReadOnlyFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithStaticFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithStaticField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithStaticReadOnlyFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithStaticVolatileFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithVolatileFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithVolatileField));
        }
    }
}
