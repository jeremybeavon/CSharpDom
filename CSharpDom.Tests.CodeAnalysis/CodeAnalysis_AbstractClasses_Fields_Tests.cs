using CSharpDom.TestTarget.AbstractClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_AbstractClasses_Fields_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestAbstractClassWithConstFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithConstField));
        }

        [TestMethod]
        public void TestAbstractClassWithInternalFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithInternalField));
        }

        [TestMethod]
        public void TestAbstractClassWithNewFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNewField));
        }

        [TestMethod]
        public void TestAbstractClassWithNewStaticFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNewStaticField));
        }

        [TestMethod]
        public void TestAbstractClassWithNewStaticReadOnlyFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestAbstractClassWithNewStaticVolatileFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestAbstractClassWithNewVolatileFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestAbstractClassWithPrivateFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithPrivateField));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithProtectedField));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedInternalFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestAbstractClassWithPublicFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithPublicField));
        }

        [TestMethod]
        public void TestAbstractClassWithReadOnlyFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestAbstractClassWithStaticFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithStaticField));
        }

        [TestMethod]
        public void TestAbstractClassWithStaticReadOnlyFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestAbstractClassWithStaticVolatileFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestAbstractClassWithVolatileFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithVolatileField));
        }
    }
}
