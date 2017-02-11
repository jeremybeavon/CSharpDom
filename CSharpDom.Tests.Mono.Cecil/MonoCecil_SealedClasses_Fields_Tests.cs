using CSharpDom.TestTarget.SealedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_Fields_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestSealedClassWithConstFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithConstField));
        }

        [TestMethod]
        public void TestSealedClassWithInternalFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithInternalField));
        }

        [TestMethod]
        public void TestSealedClassWithNewFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNewField));
        }

        [TestMethod]
        public void TestSealedClassWithNewStaticFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNewStaticField));
        }

        [TestMethod]
        public void TestSealedClassWithNewStaticReadOnlyFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithNewStaticVolatileFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestSealedClassWithNewVolatileFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestSealedClassWithPrivateFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithPrivateField));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithProtectedField));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedInternalFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestSealedClassWithPublicFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithPublicField));
        }

        [TestMethod]
        public void TestSealedClassWithReadOnlyFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithStaticFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithStaticField));
        }

        [TestMethod]
        public void TestSealedClassWithStaticReadOnlyFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithStaticVolatileFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestSealedClassWithVolatileFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithVolatileField));
        }
    }
}
