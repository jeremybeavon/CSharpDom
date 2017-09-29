using CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_NestedSealedClasses_Fields_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithConstFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithConstField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithInternalFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithInternalField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNewFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNewField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNewStaticFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNewStaticField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNewStaticReadOnlyFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNewStaticVolatileFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNewVolatileFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithPrivateFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithPrivateField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithProtectedFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithProtectedField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithProtectedInternalFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithPublicFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithPublicField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithReadOnlyFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithStaticFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithStaticField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithStaticReadOnlyFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithStaticVolatileFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithVolatileFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithVolatileField));
        }
    }
}
