using CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_NestedAbstractClasses_Fields_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithConstFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithConstField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithInternalFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithInternalField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNewFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithNewField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNewStaticFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithNewStaticField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNewStaticReadOnlyFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNewStaticVolatileFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNewVolatileFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithPrivateFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithPrivateField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithProtectedFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithProtectedField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithProtectedInternalFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithPublicFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithPublicField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithReadOnlyFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithStaticFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithStaticField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithStaticReadOnlyFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithStaticVolatileFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithVolatileFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithVolatileField));
        }
    }
}
