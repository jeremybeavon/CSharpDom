using CSharpDom.TestTarget.SealedClasses.NestedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_NestedClasses_Fields_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedClassWithConstFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithConstField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithInternalFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithInternalField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewStaticFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewStaticField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewStaticReadOnlyFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewStaticVolatileFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewVolatileFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPrivateFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPrivateField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedInternalFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPublicFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPublicField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithReadOnlyFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithStaticFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithStaticField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithStaticReadOnlyFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithStaticVolatileFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithVolatileFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithVolatileField));
        }
    }
}
