using CSharpDom.TestTarget.SealedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_Fields_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestSealedClassWithConstFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithConstField));
        }

        [TestMethod]
        public void TestSealedClassWithInternalFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithInternalField));
        }

        [TestMethod]
        public void TestSealedClassWithNewFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNewField));
        }

        [TestMethod]
        public void TestSealedClassWithNewStaticFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNewStaticField));
        }

        [TestMethod]
        public void TestSealedClassWithNewStaticReadOnlyFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithNewStaticVolatileFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestSealedClassWithNewVolatileFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestSealedClassWithPrivateFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithPrivateField));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithProtectedField));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedInternalFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestSealedClassWithPublicFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithPublicField));
        }

        [TestMethod]
        public void TestSealedClassWithReadOnlyFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithStaticFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithStaticField));
        }

        [TestMethod]
        public void TestSealedClassWithStaticReadOnlyFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithStaticVolatileFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestSealedClassWithVolatileFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithVolatileField));
        }
    }
}
