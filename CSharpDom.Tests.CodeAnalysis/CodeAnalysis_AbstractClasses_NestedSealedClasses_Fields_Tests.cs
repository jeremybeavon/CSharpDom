using CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_AbstractClasses_NestedSealedClasses_Fields_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithConstFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithConstField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithInternalFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithInternalField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNewFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNewField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNewStaticFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNewStaticField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNewStaticReadOnlyFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNewStaticVolatileFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNewVolatileFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithPrivateFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithPrivateField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithProtectedFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithProtectedField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithProtectedInternalFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithPublicFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithPublicField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithReadOnlyFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithStaticFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithStaticField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithStaticReadOnlyFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithStaticVolatileFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithVolatileFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithVolatileField));
        }
    }
}
