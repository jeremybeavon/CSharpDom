using CSharpDom.TestTarget.SealedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_Fields_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestSealedClassWithConstrFieldUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithConstrField));
        }

        [TestMethod]
        public void TestSealedClassWithInternalFieldUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithInternalField));
        }

        [TestMethod]
        public void TestSealedClassWithNewFieldUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNewField));
        }

        [TestMethod]
        public void TestSealedClassWithNewStaticFieldUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNewStaticField));
        }

        [TestMethod]
        public void TestSealedClassWithNewStaticReadOnlyFieldUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithNewStaticVolatileFieldUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestSealedClassWithNewVolatileFieldUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestSealedClassWithPrivateFieldUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithPrivateField));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedFieldUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithProtectedField));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedInternalFieldUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestSealedClassWithPublicFieldUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithPublicField));
        }

        [TestMethod]
        public void TestSealedClassWithReadOnlyFieldUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithStaticFieldUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithStaticField));
        }

        [TestMethod]
        public void TestSealedClassWithStaticReadOnlyFieldUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithStaticVolatileFieldUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestSealedClassWithVolatileFieldUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithVolatileField));
        }
    }
}
