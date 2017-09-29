using CSharpDom.TestTarget.AbstractClasses.NestedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_AbstractClasses_NestedClasses_Fields_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedClassWithConstFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithConstField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithInternalFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithInternalField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewStaticFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewStaticField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewStaticReadOnlyFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewStaticVolatileFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewVolatileFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPrivateFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPrivateField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedInternalFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPublicFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPublicField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithReadOnlyFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithStaticFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithStaticField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithStaticReadOnlyFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithStaticVolatileFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithVolatileFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithVolatileField));
        }
    }
}
