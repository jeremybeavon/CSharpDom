using CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_AbstractClasses_NestedAbstractClasses_Fields_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithConstFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithConstField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithInternalFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithInternalField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithNewFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNewField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithNewStaticFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNewStaticField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithNewStaticReadOnlyFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithNewStaticVolatileFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithNewVolatileFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithPrivateFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithPrivateField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithProtectedFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithProtectedField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithProtectedInternalFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithPublicFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithPublicField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithReadOnlyFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithStaticFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithStaticField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithStaticReadOnlyFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithStaticVolatileFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithVolatileFieldUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithVolatileField));
        }
    }
}
