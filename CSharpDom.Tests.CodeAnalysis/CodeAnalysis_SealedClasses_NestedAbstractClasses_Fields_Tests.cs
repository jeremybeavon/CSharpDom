using CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_NestedAbstractClasses_Fields_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithConstFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithConstField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithInternalFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithInternalField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNewFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNewStaticFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewStaticField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNewStaticReadOnlyFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNewStaticVolatileFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNewVolatileFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithPrivateFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithPrivateField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithProtectedFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithProtectedField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithProtectedInternalFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithPublicFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithPublicField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithReadOnlyFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithStaticFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithStaticField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithStaticReadOnlyFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithStaticVolatileFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithVolatileFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithVolatileField));
        }
    }
}
