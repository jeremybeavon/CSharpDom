using CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_NestedSealedClasses_Fields_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithConstFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithConstField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithInternalFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithInternalField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNewFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithNewField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNewStaticFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithNewStaticField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNewStaticReadOnlyFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNewStaticVolatileFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNewVolatileFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithPrivateFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithPrivateField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithProtectedFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithProtectedField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithProtectedInternalFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithPublicFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithPublicField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithReadOnlyFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithStaticFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithStaticField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithStaticReadOnlyFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithStaticVolatileFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithVolatileFieldUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithVolatileField));
        }
    }
}
