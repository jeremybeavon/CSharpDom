using CSharpDom.TestTarget.SealedClasses.NestedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_NestedClasses_Fields_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedClassWithConstFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithConstField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithInternalFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithInternalField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithNewField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewStaticFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithNewStaticField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewStaticReadOnlyFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewStaticVolatileFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewVolatileFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPrivateFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithPrivateField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithProtectedField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedInternalFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPublicFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithPublicField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithReadOnlyFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithStaticFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithStaticField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithStaticReadOnlyFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithStaticVolatileFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithVolatileFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithVolatileField));
        }
    }
}
