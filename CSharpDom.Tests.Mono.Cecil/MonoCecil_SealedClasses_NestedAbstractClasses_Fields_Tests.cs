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
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithConstField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithInternalFieldUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithInternalField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNewFieldUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNewStaticFieldUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewStaticField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNewStaticReadOnlyFieldUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNewStaticVolatileFieldUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNewVolatileFieldUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithPrivateFieldUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithPrivateField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithProtectedFieldUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithProtectedField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithProtectedInternalFieldUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithPublicFieldUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithPublicField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithReadOnlyFieldUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithStaticFieldUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithStaticField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithStaticReadOnlyFieldUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithStaticVolatileFieldUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithVolatileFieldUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithVolatileField));
        }
    }
}
